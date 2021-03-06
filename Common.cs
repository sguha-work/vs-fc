﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Xml;
using Newtonsoft.Json;
using System.Xml.Linq;
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

        /// <summary>
        /// decode json string
        /// </summary>
        /// <param name="jsonString"></param>
        /// <returns></returns>
        public Dictionary<string, Dictionary<string, Dictionary<String, String>>> decodeJSON(String jsonString)
        {
            JavaScriptSerializer ser = new JavaScriptSerializer() { MaxJsonLength = 86753090 };
            var data = ser.Deserialize<Dictionary<String, Dictionary<String, Dictionary<String, String>>>>(jsonString);
            return data;
        }

       

        /// <summary>
        /// Filetr the chart specific data from chartName and total chartData
        /// </summary>
        /// <param name="chartType"></param>
        /// <param name="data"></param>
        /// <returns></returns>
        public String getChartData(String chartType, String data)
        {
            JavaScriptSerializer ser = new JavaScriptSerializer() { MaxJsonLength = 86753090 };
            var chartData = ser.Deserialize<Dictionary<String, Dictionary<String, Dictionary<String, String>>>>(data);
            return chartData[chartType]["data"]["JSON"].ToString();
        }

        /// <summary>
        /// Prepare the web page from chart data
        /// </summary>
        /// <param name="chartData"></param>
        /// <returns></returns>
        public String prepareHTMLDataFromChartData(String chartData, String chartContainer, int width, int height)
        {
            // Initiating the display html text
            String htmlToDisplay = "<!DOCTYPE html><html><head><meta http-equiv='X-UA-Compatible' content='IE=10' >";
            // Declaring the libraries links of FusionCharts which are necessary
            String[] fusionChartsLibraryLinks = new String[] {"http://static.fusioncharts.com/code/latest/fusioncharts.js", "http://static.fusioncharts.com/code/latest/fusioncharts.charts.js"};

            String[] fusionChartsThemesLibraryLinks = new String[] { "http://static.fusioncharts.com/code/latest/themes/fusioncharts.theme.carbon.js", "http://static.fusioncharts.com/code/latest/themes/fusioncharts.theme.ocean.js", "http://static.fusioncharts.com/code/latest/themes/fusioncharts.theme.zune.js" };
            
            
        

            // Preparing the script tags for every libraries
            String fcScriptLink = "";
            foreach(String link in fusionChartsLibraryLinks) 
            {
                fcScriptLink = fcScriptLink + "<script type='text/javascript' src='" + link + "'></script>";
            }

            if(chartData.IndexOf("\"theme\"")!=-1)
            {
                foreach (String link in fusionChartsThemesLibraryLinks)
                {
                    fcScriptLink = fcScriptLink + "<script type='text/javascript' src='" + link + "'></script>";
                }
            }

            chartContainer = "chart-container";
            String container = "<div id='"+chartContainer+"' style='width:"+width+"px; height:"+height+"px;'></div>";

            // preparing chart code    
            String chartCode = "<script type='text/javascript'>FusionCharts.ready(function(){ var chart = new FusionCharts(" + chartData + "); " + checkAndGetEventCode() + "chart.render();});</script>";

            // preparing the final out put html
            htmlToDisplay += fcScriptLink + "</head><body>" + container + chartCode + "</body></html>";
            return htmlToDisplay;
        }

        private String checkAndGetEventCode()
        {
            String eventCode = "";
            String[] eventFiles =  System.IO.Directory.GetFiles("dataSource/events", "*.js");
            if (eventFiles.Length > 0) 
            {
                foreach (String file in eventFiles)
                {
                    String eventName = file.Split('.')[0].Split('\\')[1];
                    String eventCodeText = System.IO.File.ReadAllText(file);
                    eventCode += eventCodeText + System.IO.File.ReadAllText(file) + "chart.addEventListener('" + eventName + "'," + eventName + ");";
                }
            }
            return eventCode;
        }

        public String getChartInfo(String info, String chartType, String data)
        {
            String infoFromChart = "";
            String chartData = Uri.UnescapeDataString(getChartData(chartType, data));
            Chart object_chart = Chart.getInstance();
            switch (info)
            { 
                case "caption":
                    infoFromChart = object_chart.getChartCaption(chartData);
                break;
                
                case "subCaption":
                    infoFromChart = object_chart.getChartSubCaption(chartData);
                break;

                case "widthheight":
                    infoFromChart = object_chart.getChartWidthHeight(chartData);
                break;
                
                case "xAxisName":
                infoFromChart = object_chart.getChartXAxisName(chartData);
                break;

                case "yAxisName":
                infoFromChart = object_chart.getChartYAxisName(chartData);
                break;
            }
            return infoFromChart;
        }

        public String setChartInfo(String info, String chartData, String newValue)
        {
            String redefinedChartData = "";

            return redefinedChartData;
        }

        public String setChartWidthHeight(String chartData, String width, String height)
        {
            Chart object_chart = Chart.getInstance();
            return object_chart.setChartWidthHeight(chartData, width, height);
        }

        public String convertJSONToXML(String jsonData)
        {
            dynamic obj = JsonConvert.DeserializeObject<dynamic>(jsonData);
            XDocument xdoc = JsonConvert.DeserializeXNode(JsonConvert.SerializeObject(obj.dataSource), "chart");              
            return xdoc.ToString();
        }

        public String setChartCaption(String chartData, String caption)
        {
            Chart object_chart = Chart.getInstance();
            return object_chart.setChartCaption(chartData, caption);
        }

        public String setChartSubCaption(String chartData, String subCaption)
        {
            Chart object_chart = Chart.getInstance();
            return object_chart.setChartSubCaption(chartData, subCaption);
        }

        public String setChartXAxisName(String chartData, String chartXAxisName)
        {
            Chart object_chart = Chart.getInstance();
            return object_chart.setChartXAxisName(chartData, chartXAxisName);
        }

        public String setChartYAxisName(String chartData, String chartYAxisName)
        {
            Chart object_chart = Chart.getInstance();
            return object_chart.setChartYAxisName(chartData, chartYAxisName);
        }

        public dynamic getChartDataOnly(String chartData)
        {
            Chart object_chart = Chart.getInstance();
            return object_chart.getChartDataOnly(chartData);
        }

        public String setChartTheme(String chartData, String themeName)
        {
            Chart object_chart = Chart.getInstance();
            return object_chart.setChartTheme(chartData, themeName);
        }
        
    }
}
