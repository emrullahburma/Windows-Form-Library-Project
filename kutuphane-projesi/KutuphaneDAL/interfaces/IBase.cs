using System.Collections.Generic;
using System.Data;

namespace KutuphaneDAL.interfaces
{
    public interface IBase
    {
        List<dynamic> GetData(string cmdtext, Dictionary<string, object> parameter);
        int PostData(string cmdText, Dictionary<string, object> parameter);
        List<dynamic> GetStoredProcerude(string cmdText, Dictionary<string, object> parameters, CommandType cmdType);
    }
}
