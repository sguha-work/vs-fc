﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Windows.Forms;
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

        public String convertJSONToXML(String jsonData)
        {
            Common object_common = Common.getInstance();
            return object_common.convertJSONToXML(jsonData);
        }

        public String setChartCaption(String chartData, String caption)
        {
            Common object_common = Common.getInstance();
            return object_common.setChartCaption(chartData, caption);
        }

        public String setChartSubCaption(String chartData, String subCaption)
        {
            Common object_common = Common.getInstance();
            return object_common.setChartSubCaption(chartData, subCaption);
        }

        public String setChartXAxisName(String chartData, String chartXAxisName)
        {
            Common object_common = Common.getInstance();
            return object_common.setChartXAxisName(chartData, chartXAxisName);
        }

        public String setChartYAxisName(String chartData, String chartYAxisName)
        {
            Common object_common = Common.getInstance();
            return object_common.setChartYAxisName(chartData, chartYAxisName);
        }

        public dynamic getChartDataOnly(String chartData)
        {
            Common object_common = Common.getInstance();
            return object_common.getChartDataOnly(chartData);
        }

        public String setChartTheme(String chartData, String themeName)
        {
            Common object_common = Common.getInstance();
            return object_common.setChartTheme(chartData, themeName);
        }

        public CheckBox[] getEventCheckBoxes(String eventDataJson)
        {
            
            JavaScriptSerializer ser = new JavaScriptSerializer() { MaxJsonLength = 86753090 };
            Dictionary<String, String> eventDataList = ser.Deserialize<Dictionary<String, String>>(eventDataJson);
            CheckBox[] checkboxArray = new CheckBox[eventDataList.Count-1];
            int count = 1; 
            foreach (String eventName in eventDataList.Keys)
            {
                if (eventName.ToLower() != "ready")
                {
                    CheckBox cb = new CheckBox();
                    cb.Location = new System.Drawing.Point(10, (25 * count) + 2);
                    cb.Name = "cb_fcve_" + eventName;
                    cb.Text = eventName;
                    cb.AutoSize = true;
                    checkboxArray[count - 1] = cb;
                    count++;
                }
            }
            return checkboxArray;
        }

        public TextBox[] getEventTextBoxes(String eventDataJson)
        {

            JavaScriptSerializer ser = new JavaScriptSerializer() { MaxJsonLength = 86753090 };
            Dictionary<String, String> eventDataList = ser.Deserialize<Dictionary<String, String>>(eventDataJson);
            TextBox[] textboxArray = new TextBox[eventDataList.Count - 1];
            int count = 1;
            foreach (String eventName in eventDataList.Keys)
            {
                if (eventName.ToLower() != "ready")
                {
                    TextBox tb = new TextBox();
                    tb.Width = 349;
                    tb.Height = 344;
                    tb.Name = "txt_fcve_" + eventName;
                    tb.AccessibleName = "txt_fcve_" + eventName;
                    tb.Text = "\n\nvar "+eventName+" = (function(){\n //write your code here\n});".Replace("\n", System.Environment.NewLine);
                    tb.Multiline = true;
                    
                    textboxArray[count - 1] = tb;
                    tb.Visible = false;
                    count++;
                }
            }
            return textboxArray;
        }

       
    }
}
