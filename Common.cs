using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Helpers;
namespace fc_ve
{
    class Common
    {
        private static Common instance= null;
        private Common() 
        {
        }
        public static Common getInstance()
        {
            if (instance != null) 
            {
                return instance;
            } 
            else 
            {
                instance = new Common();
                return instance;
            }
        }
        public dynamic decodeJSON(String jsonString)
        {
            dynamic data = Json.Decode(jsonString);
            return data;
        }
    }
}
