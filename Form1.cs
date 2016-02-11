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

            // setup the event section
            CheckBox[] checkBoxArray = object_prepareFormElements.getEventCheckBoxes(System.IO.File.ReadAllText("dataSource/event-data.json"));
            foreach(CheckBox cb in checkBoxArray)
            {
                panel_fcve_events.Controls.Add(cb);
            }
            
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

            // setting chart xAxisName
            String chartXAxisName = object_prepareFormElements.getChartInfo("xAxisName", chartType, System.IO.File.ReadAllText("dataSource/final.json"));
            txt_fcve_chart_xaxis_name.Text = chartXAxisName;

            // setting chart yAxisName
            String chartYAxisName = object_prepareFormElements.getChartInfo("yAxisName", chartType, System.IO.File.ReadAllText("dataSource/final.json"));
            txt_fcve_chart_yaxis_name.Text = chartYAxisName;

            // setting up the chart data grid
            dgv_fcve_chart_data.DataSource = object_prepareFormElements.getChartDataOnly(txt_fcve_json_data.Text);

            //setting up theme
            if (rb_fcve_theme_zune.Checked)
            {
                rb_fcve_theme_zune.Checked = false;
            }
            if (rb_fcve_theme_ocean.Checked)
            {
                rb_fcve_theme_ocean.Checked = false;
            }
            if (rb_fcve_theme_carbon.Checked)
            {
                rb_fcve_theme_carbon.Checked = false;
            }
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
            // loading the chart
            String dataForChart = txt_fcve_json_data.Text; 
            wb_fcve_chart.DocumentText = object_prepareFormElements.getHTMLPageData(dataForChart, "chart-container", (wb_fcve_chart.Width-10), (wb_fcve_chart.Height-10));

            // converting JSON data to XML
            txt_fcve_xml_data.Text = object_prepareFormElements.convertJSONToXML(txt_fcve_json_data.Text.ToString());

            // changing the data grid value
            dgv_fcve_chart_data.DataSource = object_prepareFormElements.getChartDataOnly(txt_fcve_json_data.Text);
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

        private void tb_fcve_chart_width_MouseUp(object sender, MouseEventArgs e)
        {
            txt_fcve_json_data.Text = object_prepareFormElements.setChartWidthHeight(txt_fcve_json_data.Text, txt_fcve_chart_width.Text, txt_fcve_chart_height.Text);
        }

        private void tb_fcve_chart_height_MouseUp(object sender, MouseEventArgs e)
        {
            txt_fcve_json_data.Text = object_prepareFormElements.setChartWidthHeight(txt_fcve_json_data.Text, txt_fcve_chart_width.Text, txt_fcve_chart_height.Text);
        }

       
        private void txt_fcve_chart_caption_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txt_fcve_chart_caption.Focused && e.KeyChar == (char)Keys.Return)
            {
                txt_fcve_json_data.Text = object_prepareFormElements.setChartCaption(txt_fcve_json_data.Text.ToString(), txt_fcve_chart_caption.Text.ToString());
            }
        }

        private void txt_fcve_chart_caption_Enter(object sender, EventArgs e)
        {
            showToolTip(sender);
        }

        

        private void txt_fcve_chart_sub_caption_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txt_fcve_chart_sub_caption.Focused && e.KeyChar == (char)Keys.Return)
            {
                txt_fcve_json_data.Text = object_prepareFormElements.setChartSubCaption(txt_fcve_json_data.Text.ToString(), txt_fcve_chart_sub_caption.Text.ToString());
            }
        }

        private void txt_fcve_chart_sub_caption_Enter(object sender, EventArgs e)
        {
            showToolTip(sender);
        }

        private void txt_fcve_chart_xaxis_name_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txt_fcve_chart_xaxis_name.Focused && e.KeyChar == (char)Keys.Return)
            {
                txt_fcve_json_data.Text = object_prepareFormElements.setChartXAxisName(txt_fcve_json_data.Text.ToString(), txt_fcve_chart_xaxis_name.Text.ToString());
            }
        }

        private void txt_fcve_chart_xaxis_name_Enter(object sender, EventArgs e)
        {
            showToolTip(sender);
        }

        private void txt_fcve_chart_yaxis_name_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txt_fcve_chart_yaxis_name.Focused && e.KeyChar == (char)Keys.Return)
            {
                txt_fcve_json_data.Text = object_prepareFormElements.setChartXAxisName(txt_fcve_json_data.Text.ToString(), txt_fcve_chart_yaxis_name.Text.ToString());
            }
        }

        private void txt_fcve_chart_yaxis_name_Enter(object sender, EventArgs e)
        {
            showToolTip(sender);
        }

        private void showToolTip(object sender)
        {
            TextBox TB = (TextBox)sender;
            int visibleTime = 3000;  //in milliseconds
            ToolTip tt = new ToolTip();
            tt.Show("Type and press Enter to effect", TB, 50, 20, visibleTime);
        }

        private void rb_fcve_theme_zune_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_fcve_theme_zune.Focused)
            {
                txt_fcve_json_data.Text = object_prepareFormElements.setChartTheme(txt_fcve_json_data.Text, "zune");
            }
            
        }

        private void rb_fcve_theme_ocean_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_fcve_theme_ocean.Focused)
            {
                txt_fcve_json_data.Text = object_prepareFormElements.setChartTheme(txt_fcve_json_data.Text, "ocean");
            }
            
        }

        private void rb_fcve_theme_carbon_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_fcve_theme_carbon.Focused)
            {
                txt_fcve_json_data.Text = object_prepareFormElements.setChartTheme(txt_fcve_json_data.Text, "carbon");
            }
            
        }

       

        

        

        

        

        

        

        

        

       

        
    }
}
