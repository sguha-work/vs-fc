using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        public Dictionary<string, Dictionary<string, Dictionary<string, string>>> decodeJSON(String jsonString)
        {
            JavaScriptSerializer ser = new JavaScriptSerializer() { MaxJsonLength = 86753090 };
            var data = ser.Deserialize<Dictionary<String, Dictionary<String, Dictionary<String, String>>>>(jsonString);
            //dynamic data = Json.Decode(jsonString);
            return data;
        }

        public String getChartData(String chartName, String data)
        {
            JavaScriptSerializer ser = new JavaScriptSerializer() { MaxJsonLength = 86753090 };
            var chartData = ser.Deserialize<Dictionary<String, Dictionary<String, Dictionary<String, String>>>>(data);
            return chartData[chartName]["data"]["JSON"].ToString();
        }
    }
}
