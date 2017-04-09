using System.Collections.Generic;

namespace ChangingMoneyGui
{
    public interface IQueryExecuter
    {
        Dictionary<string, string> Run(params object[] vars);
        Dictionary<string, string> Next();
    }
}