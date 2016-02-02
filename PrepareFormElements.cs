using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
namespace fc_ve
{
    class PrepareFormElements
    {
        public List<String> prepareChartTypes(String chartDataJSON)
        {
            List<String> chartTypes = new List<String>();
            Common commonObject = Common.getInstance();
            Dictionary<string, Dictionary<string, Dictionary<string, string>>> chartData = commonObject.decodeJSON(chartDataJSON);
            foreach (string chartType in chartData.Keys)
            {
                if (chartData[chartType]["data"]["JSON"] != "")
                {
                    chartTypes.Add(chartType.ToString().ToUpper());
                }
                
            }
            return chartTypes;
        }
        public String getChartData(String chartName, String data)
        { 
            Common commonObject = Common.getInstance();
            String chartData = commonObject.getChartData(chartName, data);
            return Uri.UnescapeDataString(chartData).Replace("\n", Environment.NewLine);
        }
    }
}
