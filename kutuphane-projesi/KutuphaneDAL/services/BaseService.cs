using KutuphaneDAL.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using Dapper;
using System.Data.SqlClient;
using System.Data;

namespace KutuphaneDAL.services
{
    public class BaseService : IBase
    {
        private readonly string _conStr;

        public BaseService(string conStr) 
        {
            _conStr = conStr;   
        }

        public List<dynamic> GetData(string cmdtext, Dictionary<string, object> parameters)
        {
            using(SqlConnection con = new SqlConnection(_conStr)) 
            {
                try
                {
                    var dynamicParameters = new DynamicParameters();

                    foreach (var item in parameters)
                    {
                        dynamicParameters.Add(item.Key, item.Value);
                    }
                    
                    var result = con.Query(cmdtext, dynamicParameters, null, true, 999999).ToList();
                    return result;
                }
                catch(Exception hata)
                {
                    return new List<dynamic>();
                }
            }
        }

        public int PostData(string cmdText, Dictionary<string, object> parameters)
        {
            using(SqlConnection con = new SqlConnection(_conStr))
            {
                var dynamicParamaters = new DynamicParameters();

                foreach (var item in parameters)
                {
                    dynamicParamaters.Add(item.Key, item.Value);
                }

                var result = con.Execute(cmdText, dynamicParamaters, null, 999999);
                return result;
            }
        }

        public List<dynamic> GetStoredProcerude(string cmdText, Dictionary<string, object> parameters, CommandType cmdType)
        {
            using(SqlConnection con = new SqlConnection(_conStr))
            {
                var dynamicParameters = new DynamicParameters();

                foreach(var item in parameters)
                {
                    dynamicParameters.Add(item.Key, item.Value);
                }

                var result = con.Query(cmdText, dynamicParameters, null, true, 999999, cmdType).ToList();
                return result;
            }
        }
    }
}
