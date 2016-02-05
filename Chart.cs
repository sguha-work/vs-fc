using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            chartData = chartData.Replace("'","\"");
            String [] widthHeight= new String [2];
            {
                Int32 indexOfWidth = chartData.ToLower().IndexOf("width:");
                if (indexOfWidth == -1)
                {
                    widthHeight[0] = "";
                    widthHeight[1] = "";
                    
                }
                else
                {
                    Int32 index = indexOfWidth;
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
                        widthHeight[0] += chartData[index];
                        index++;
                    }
               
                }
            }
            {
                Int32 indexOfHeight = chartData.ToLower().IndexOf("height:");
                if (indexOfHeight == -1)
                {
                    widthHeight[0] = "";
                    widthHeight[1] = "";
                    
                }
                else
                {
                    Int32 index = indexOfHeight;
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
                        widthHeight[1] += chartData[index];
                        index++;
                    }

                }
            }


            return String.Join(",", widthHeight);

        }

        public String setChartWidthHeight(String chartData, Int32 width, Int32 height, Boolean isWidthChanged, Boolean isHeightChanged) 
        {
            Char[] newChartData = new Char[chartData.Length];
            
            {
                Int32 indexOfWidth = chartData.ToLower().IndexOf("width:");
                Int32 index, flag = 0;
                for (index = 0; index < chartData.Length; index++ )
                {
                    if (index <= indexOfWidth+6)
                    {
                        newChartData[index] = chartData[index];
                    }

                }
                
            }
            return chartData;
        }
    }
}
