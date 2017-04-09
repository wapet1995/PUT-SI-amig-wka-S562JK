using System;
using System.Collections.Generic;
using SbsSW.SwiPlCs;

namespace ChangingMoneyGui
{
    public class ChangingMoneyExecuter : IQueryExecuter
    {
        private PlQuery _q;
        private string[] _varNames;

        public Dictionary<string, string> Run(params object[] vars)
        {
            if(_q != null) _q.Dispose();

            string query = string.Format("change({0}, [{1}], [{2}]).", vars);
            _q = new PlQuery(query);
            _varNames = vars[1].ToString().Replace(" ", "").Split(',');

            return getResult();
        }

        public Dictionary<string, string> Next()
        {
            return getResult();
        }

        private Dictionary<string, string> getResult()
        {
            Dictionary<string, string> result = new Dictionary<string, string>();

            foreach (PlQueryVariables qv in _q.SolutionVariables)
            {
                foreach (string v in _varNames)
                    result.Add(v, qv[v].ToString());
                break;
            }
            return result;
        }

        ~ChangingMoneyExecuter()
        {
            if(_q != null)
                _q.Dispose();
        }
    }
}