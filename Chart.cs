using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using Newtonsoft.Json;
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
            try
            {
                dynamic obj = JsonConvert.DeserializeObject<dynamic>(chartData);
                if (obj.dataSource.chart.subCaption != null)
                {
                    chartSubCaption = obj.dataSource.chart.subCaption.Value;
                }
                else if (obj.dataSource.chart.subcaption != null)
                {
                    chartSubCaption = obj.dataSource.chart.subcaption.Value;
                }
                else
                {
                    chartSubCaption = "";
                }
            }
            catch (Exception e)
            {
                chartSubCaption = "";
            }
            return chartSubCaption;
        }

        /// <summary>
        /// Fetch out chart width height
        /// </summary>
        /// <param name="chartData"></param>
        /// <returns></returns>
        public String getChartWidthHeight(String chartData)
        {
            String [] widthHeight= new String [2];
            dynamic obj = JsonConvert.DeserializeObject<dynamic>(chartData);
            widthHeight[0] = obj.width;
            widthHeight[1] = obj.height;
            return String.Join(",", widthHeight);

        }

        /// <summary>
        /// Set the new height width of chart and return the new JSON data with modified height width
        /// </summary>
        /// <param name="chartData"></param>
        /// <param name="width"></param>
        /// <param name="height"></param>
        /// <returns></returns>
        public String setChartWidthHeight(String chartData, String width, String height) 
        {
            dynamic obj = JsonConvert.DeserializeObject<dynamic>(chartData);
            obj.width = width;
            obj.height = height;
            return JsonConvert.SerializeObject(obj, Formatting.Indented);
        }

        public String setChartCaption(String chartData, String caption)
        {
            dynamic obj = JsonConvert.DeserializeObject<dynamic>(chartData);
            obj.dataSource.chart.caption = caption;
            return JsonConvert.SerializeObject(obj, Formatting.Indented);
        }
    }
}
