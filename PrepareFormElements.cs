using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fc_ve
{
    class PrepareFormElements
    {
        public List<String> prepareChartTypes(String chartDataJSON)
        {
            List<String> chartTypes = new List<String>();
            Common commonObject = Common.getInstance();
            dynamic chartData = commonObject.decodeJSON(chartDataJSON);
            foreach (dynamic item in chartData)
            {
                
            }
            return chartTypes;
        }
    }
}
