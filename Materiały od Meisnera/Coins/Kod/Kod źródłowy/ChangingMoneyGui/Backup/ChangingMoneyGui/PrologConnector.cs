using System;
using System.Collections.Generic;
using System.IO;
using SbsSW.SwiPlCs;
using SbsSW.SwiPlCs.Exceptions;

namespace ChangingMoneyGui
{
    public static class PrologConnector
    {
        private static string _path;
        public static string Path
        {
            get { return _path; }
            set
            {
                if (Directory.Exists(value))
                {
                    _path = value;
                    tryConnect();
                    ErrorMessager.ShowError = true;
                }
            }
        }

        static PrologConnector()
        {
            Code = new List<string>();
        }

        public static List<string> Code { get; set; }

        private static bool _isConnected = false;
        public static bool IsConnected { get { return _isConnected; } }

        private static void tryConnect()
        {
            if (!isProperDirectory()) return;

            setEnvironmentVariables();

            tryInitializeEngine();

            checkInitialized();
        }

        private static bool isProperDirectory()
        {
            if (File.Exists(string.Format("{0}\\{1}", Path, "boot32.prc")))
                return true;

            ErrorMessager.NotInstalledInThisDirectory();
            return false;
        }

        private static void tryInitializeEngine()
        {
            try
            {
                initialization();
            }
            catch (PlException e)
            {
                ErrorMessager.FileNotFound(e);
            }
            catch (FileNotFoundException e)
            {
                ErrorMessager.NotInstalledInThisDirectory();
            }
            catch (AccessViolationException e)
            {
                try
                {
                    initialization();
                }
                catch (Exception ex)
                {
                    ErrorMessager.InitializationError(ex);
                }
            }
        }

        private static void initialization()
        {
            PlEngine.Initialize(new string[] { "-q" });

            if (Code.Count == 0)
            {
                ErrorMessager.NoCodeReaded();
                return;
            }

            foreach(string c in Code)
                PlQuery.PlCall(c);
        }

        private static bool checkInitialized()
        {
            if (PlEngine.IsInitialized)
                _isConnected = true;
            else
            {
                _isConnected = false;
                Dispose();
            }

            return IsConnected;
        }

        private static void setEnvironmentVariables()
        {
            Environment.SetEnvironmentVariable("SWI_HOME_DIR", Path);
            Environment.SetEnvironmentVariable("PATH", String.Format(@"{0}\bin", Path));
            Environment.SetEnvironmentVariable("LIB", String.Format(@"{0}\lib", Path));
        }

        public static void Dispose()
        {
            PlEngine.PlCleanup();
        }
    }
}