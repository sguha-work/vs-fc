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
        public form_fcve()
        {
            InitializeComponent();
        }

        private void form_vbfc_Load(object sender, EventArgs e)
        {
            this.initializeFormElements();
        }

        private void initializeFormElements()
        {
            PrepareFormElements p = new PrepareFormElements();
            //MessageBox.Show(Path.GetFullPath("dataSource/final.json"));
            cb_chartType.DataSource = p.prepareChartTypes(System.IO.File.ReadAllText("dataSource/final.json"));
        }

       

        

       

        
    }
}
