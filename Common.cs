using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Web.Helpers;
using System.Web.Script.Serialization;
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
            JavaScriptSerializer ser = new JavaScriptSerializer() { MaxJsonLength = 86753090 };
            var data = ser.Deserialize<Dictionary<string, Dictionary<string, Dictionary<string, string>>>>(jsonString);
            //dynamic data = Json.Decode(jsonString);
            return data;
        }
    }
}
