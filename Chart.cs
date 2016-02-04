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

        public String getChartCaption(String chartData)
        {
            String chartCaption = null;
            Int32 indexOfCaption = chartData.IndexOf("caption");
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
    }
}
