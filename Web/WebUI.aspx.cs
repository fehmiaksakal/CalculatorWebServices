using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Web.WebServiceRef;
namespace Web
{
    public partial class WebUI : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAction_Click(object sender, EventArgs e)
        {
           
            try
            {
 CalculatorBaseSoapClient client = new CalculatorBaseSoapClient();
            decimal x = Convert.ToDecimal(txtnumberOne.Text);
            decimal y = Convert.ToDecimal(txtnumberTwo.Text);
            decimal a  = client.Plus(x , y);
            }
            catch (Exception ex)
            {

                throw;
            }

        }
    }
}