using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace fc_ve
{
    class Chart
    {
        private static Chart object_chart = null;
        private Chart()
        { 
        
        }

        public static Chart getInstance()
        {
            if (object_chart != null)
            {
                return object_chart;
            }
            else
            {
                object_chart = new Chart();
                return object_chart;
            }
        }

        /// <summary>
        /// fetch out the chart caption from chart data
        /// </summary>
        /// <param name="chartData"></param>
        /// <returns></returns>
        public String getChartCaption(String chartData)
        {
            String chartCaption = null;
            Int32 indexOfCaption = chartData.ToLower().IndexOf("\"caption");
            if (indexOfCaption == -1)
            {
                return chartCaption;
            }
            else
            {
                Int32 index = indexOfCaption;
                while (chartData[index] != ':') 
                {
                    index++;
                }
                index+=1;
                while (chartData[index] != '"')
                {
                    index++;
                }
                index += 1;
                while (chartData[index] != '"')
                {
                    chartCaption += chartData[index];
                    index++;
                }
                    return chartCaption;
            }
            
        }



        /// <summary>
        /// Fetch out chart sub caption
        /// </summary>
        /// <param name="chartData"></param>
        /// <returns></returns>
        public String getChartSubCaption(String chartData)
        {
            String chartSubCaption = null;
            Int32 indexOfSubCaption = chartData.ToLower().IndexOf("\"subcaption");
            if (indexOfSubCaption == -1)
            {
                return chartSubCaption;
            }
            else
            {
                Int32 index = indexOfSubCaption;
                while (chartData[index] != ':')
                {
                    index++;
                }
                index += 1;
                while (chartData[index] != '"')
                {
                    index++;
                }
                index += 1;
                while (chartData[index] != '"')
                {
                    chartSubCaption += chartData[index];
                    index++;
                }
                return chartSubCaption;
            }

        }

        /// <summary>
        /// Fetch out chart width height
        /// </summary>
        /// <param name="chartData"></param>
        /// <returns></returns>
        public String getChartWidthHeight(String chartData)
        {
            
            String [] widthHeight= new String [2];
            JavaScriptSerializer ser = new JavaScriptSerializer() { MaxJsonLength = 86753090 };
            var data = ser.Deserialize<Dictionary<String, object>>(chartData);
            widthHeight[0] = data["width"].ToString();
            widthHeight[1] = data["height"].ToString();

            return String.Join(",", widthHeight);

        }

        public String setChartWidthHeight(String chartData, String width, String height) 
        {
            JavaScriptSerializer ser = new JavaScriptSerializer() { MaxJsonLength = 86753090 };
            var data = ser.Deserialize<Dictionary<String, object>>(chartData);
            return data["width"].ToString();
            //return chartData;
        }
    }
}
