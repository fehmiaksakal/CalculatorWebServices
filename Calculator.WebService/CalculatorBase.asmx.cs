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
        [WebMethod]
        public decimal Plus(decimal a, decimal b)
        {
            return a + b;
        }

        [WebMethod]
        public decimal Subtraction(decimal a, decimal b)
        {
            return a - b;
        }

        [WebMethod]
        public decimal Multiply(decimal a, decimal b)
        {
            return a * b;
        }

        [WebMethod]
        public decimal Divide(decimal a, decimal b)
        {
            return a / b;
        }


    }
}
