using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace Calculator.WebService
{
    /// <summary>
    /// Summary description for CalculatorBase
    /// </summary>
    [WebService(Namespace = "http://calculatorproject.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    [System.Web.Script.Services.ScriptService]
    public class CalculatorBase : System.Web.Services.WebService
    {
        [WebMethod(Description = "Plus Operation", CacheDuration = 10, EnableSession = true)]
        public decimal Plus(decimal a, decimal b)
        {
            decimal c = a + b;
            List<string> plusOp;

            if (Session["PlusOp"] == null)
                plusOp = new List<string>();
            else
                plusOp = (List<string>)Session["PlusOp"];
            string plusReturn = a.ToString() + " + " + b.ToString() + " = " + c.ToString();
            plusOp.Add(plusReturn);
            Session["PlusOp"] = plusOp;
            return c;
        }

        [WebMethod(EnableSession = true)]
        public List<string> GetAllCalc()
        {
            if (Session["PlusOp"] == null)
            {
                List<string> plusOp = new List<string>() {
                   "Empty"
                };
                return plusOp;
            }
            else
                return (List<string>)Session["PlusOp"];
        }

        [WebMethod(Description = "Subtraction Operation", CacheDuration = 10)]
        public decimal Subtraction(decimal a, decimal b)
        {
            return a - b;
        }

        [WebMethod(Description = "Multiply Operation", CacheDuration = 10)]
        public decimal Multiply(decimal a, decimal b)
        {
            return a * b;
        }

        [WebMethod(Description = "Multiply Operation", CacheDuration = 10)]
        public decimal Divide(decimal a, decimal b)
        {
            return a / b;
        }


    }
}
