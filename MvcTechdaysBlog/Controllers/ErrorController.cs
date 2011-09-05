using System;
using System.Web.Mvc;

namespace MvcTechdaysBlog.Controllers
{
    public partial class ErrorController : Controller
    {
        public virtual ActionResult Error1()
        {
            throw new ArgumentException("hey ho... you have some argument issues!");
        }
        public virtual ActionResult Error2()
        {
            throw new ApplicationException("hey ho... you have some serious issues!");
        }
    }
}
