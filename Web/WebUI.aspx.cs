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
        CalculatorBaseSoapClient client = new CalculatorBaseSoapClient();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAction_Click(object sender, EventArgs e)
        {
            decimal x = Convert.ToDecimal(txtnumberOne.Text);
            decimal y = Convert.ToDecimal(txtnumberTwo.Text);
            lblSol.Text = client.Plus(x, y).ToString();
        }

        protected void btnInc_Click(object sender, EventArgs e)
        {
            decimal x = Convert.ToDecimal(txtnumberOne.Text);
            decimal y = Convert.ToDecimal(txtnumberTwo.Text);
            lblSol.Text = client.Subtraction(x, y).ToString();
        }

        protected void btnMul_Click(object sender, EventArgs e)
        {
            decimal x = Convert.ToDecimal(txtnumberOne.Text);
            decimal y = Convert.ToDecimal(txtnumberTwo.Text);
            lblSol.Text = client.Multiply(x, y).ToString();
        }

        protected void btnDiv_Click(object sender, EventArgs e)
        {
            decimal x = Convert.ToDecimal(txtnumberOne.Text);
            decimal y = Convert.ToDecimal(txtnumberTwo.Text);
            lblSol.Text = client.Divide(x, y).ToString();
        }


    }
}