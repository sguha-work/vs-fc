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
        /// <summary>
        /// Prepare the chart types
        /// </summary>
        /// <param name="chartDataJSON"></param>
        /// <returns></returns>
        public List<String> prepareChartTypes(String chartDataJSON)
        {
            List<String> chartTypes = new List<String>();
            Common object_common = Common.getInstance();
            Dictionary<string, Dictionary<string, Dictionary<string, string>>> chartData = object_common.decodeJSON(chartDataJSON);
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
            Common object_common = Common.getInstance();
            String chartData = object_common.getChartData(chartName, data);
            return Uri.UnescapeDataString(chartData).Replace("\n", Environment.NewLine);
        }

        /// <summary>
        /// Call common function to get HTML content
        /// </summary>
        /// <param name="chartData"></param>
        /// <param name="chartContainer"></param>
        /// <param name="width"></param>
        /// <param name="height"></param>
        /// <returns></returns>
        public String getHTMLPageData(String chartData, String chartContainer, int width, int height)
        {
            Common object_common = Common.getInstance();
            String htmlData = object_common.prepareHTMLDataFromChartData(chartData, chartContainer, width, height);
            return htmlData;
        }

        public String getChartInfo(String info, String chartType, String data)
        {
            String infoFromChart = "";
            Common object_common = Common.getInstance();
            infoFromChart = object_common.getChartInfo(info, chartType, data);
            return infoFromChart;
        }

        public String setChartWidthHeight(String chartData, String width, String height)
        {
            Common object_common = Common.getInstance();
            return object_common.setChartWidthHeight(chartData, width, height);
        }
    }
}
