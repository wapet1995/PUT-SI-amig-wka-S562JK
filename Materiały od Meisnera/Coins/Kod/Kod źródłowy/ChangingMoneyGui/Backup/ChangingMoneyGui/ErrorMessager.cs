using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace ChangingMoneyGui
{
    public static class ErrorMessager
    {
        private static bool _showError = false;
        public static bool ShowError
        {
            get { return _showError; }
            set { _showError = value; }
        }

        public static void NotInstalledInThisDirectory()
        {
            if (!ShowError) return;

            MessageBox.Show("W tym katalogu nie jest zainstalowany SWI-PROLOG",
                "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void FileNotFound(Exception e)
        {
            if (!ShowError) return;

            MessageBox.Show("Nastąpił błąd podczas inicjalizacji programu SWI-PROLOG:\n" + e.Message,
                "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void InitializationError(Exception e)
        {
            if (!ShowError) return;

            MessageBox.Show("Nastąpił błąd podczas inicjalizacji programu SWI-PROLOG:\n" + e.Message,
                        "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void NoCodeReaded()
        {
            if (!ShowError) return;

            MessageBox.Show("Nie wczytano żadnego kodu do programu",
                        "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
