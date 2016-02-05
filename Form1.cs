using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace fc_ve
{
    public partial class form_fcve : Form
    {
        PrepareFormElements object_prepareFormElements;
        public form_fcve()
        {
            InitializeComponent();
        }

        private void form_vbfc_Load(object sender, EventArgs e)
        {
            object_prepareFormElements = new PrepareFormElements();
            this.initializeFormElements(); 
        }

        private void initializeFormElements()
        {
            // Loads the chart types from data source
            cb_fcve_chart_type.DataSource = object_prepareFormElements.prepareChartTypes(System.IO.File.ReadAllText("dataSource/final.json"));
            Object selectedItem = cb_fcve_chart_type.SelectedItem;
            startLoadingTheChart(selectedItem);
        }

        public void startLoadingTheChart(Object selectedItem)
        {
            String chartType = selectedItem.ToString().ToLower();
            txt_fcve_json_data.Text = object_prepareFormElements.getChartData(chartType, System.IO.File.ReadAllText("dataSource/final.json"));

            // setting chart caption to text box
            txt_fcve_chart_caption.Text = object_prepareFormElements.getChartInfo("caption", chartType, System.IO.File.ReadAllText("dataSource/final.json"));

            // setting chart sub caption to text box
            txt_fcve_chart_sub_caption.Text = object_prepareFormElements.getChartInfo("subCaption", chartType, System.IO.File.ReadAllText("dataSource/final.json"));

            //setting chart width height to text box
            String widthHeight = object_prepareFormElements.getChartInfo("widthheight", chartType, System.IO.File.ReadAllText("dataSource/final.json"));
            Int32 width = Convert.ToInt32(widthHeight.Split(',')[0].Split('%')[0]);
            Int32 height = Convert.ToInt32(widthHeight.Split(',')[1].Split('%')[0]);
            tb_fcve_chart_width.Value = width;
            tb_fcve_chart_height.Value = height;
            txt_fcve_chart_width.Text = width.ToString() + "%";
            txt_fcve_chart_height.Text = height.ToString() + "%";


        }

        /// <summary>
        /// Called when chart type is changed and load the data for the chart from data source
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cb_fcve_chart_type_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int selectedIndex = cb_fcve_chart_type.SelectedIndex;
            Object selectedItem = cb_fcve_chart_type.SelectedItem;
            startLoadingTheChart(selectedItem);
            
        }

        private void txt_fcve_json_data_TextChanged(object sender, EventArgs e)
        {
            
            String dataForChart = txt_fcve_json_data.Text; 
            wb_fcve_chart.DocumentText = object_prepareFormElements.getHTMLPageData(dataForChart, "chart-container", (wb_fcve_chart.Width-10), (wb_fcve_chart.Height-10));
        }

        /// <summary>
        /// Show the updated width value to the text box txt_fcve_chart_width
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tb_fcve_chart_width_Scroll(object sender, EventArgs e)
        {
            int chartWidth = tb_fcve_chart_width.Value;
            txt_fcve_chart_width.Text = chartWidth.ToString() + "%";
            MessageBox.Show(object_prepareFormElements.setChartWidthHeight(txt_fcve_json_data.Text, txt_fcve_chart_width.Text, txt_fcve_chart_height.Text));
        }

        /// <summary>
        /// Show the updated width value to the text box txt_fcve_chart_height 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tb_fcve_chart_height_Scroll(object sender, EventArgs e)
        {
            int chartHeight = tb_fcve_chart_height.Value;
            txt_fcve_chart_height.Text = chartHeight.ToString() + "%";
        }

        

        

       

        
    }
}
