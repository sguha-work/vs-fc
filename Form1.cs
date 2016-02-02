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

            cb_fcve_chart_type.DataSource = object_prepareFormElements.prepareChartTypes(System.IO.File.ReadAllText("dataSource/final.json"));
        }

        
        private void cb_fcve_chart_type_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int selectedIndex = cb_fcve_chart_type.SelectedIndex;
            Object selectedItem = cb_fcve_chart_type.SelectedItem;
            String chartType = selectedItem.ToString().ToLower();
            txt_fcve_json_data.Text = object_prepareFormElements.getChartData(chartType, System.IO.File.ReadAllText("dataSource/final.json"));
            
        }

       

        

       

        
    }
}
