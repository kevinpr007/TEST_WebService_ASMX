using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;

namespace WebServiceApp
{
    /// <summary>
    /// Summary description for MyService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class MyService : System.Web.Services.WebService
    {
        [WebMethod]
        public string HelloWorld()
        {
            return Context.User.Identity.Name + ", Authen. type: " + Context.User.Identity.AuthenticationType +
            ", Authenticated: " + Context.User.Identity.IsAuthenticated.ToString() + ", " +
            DateTime.Now.Minute + ":".ToString() + DateTime.Now.Second;
        }
        
        //---------------------

        public UserDetails User;
        [WebMethod]
        [SoapHeader("User", Required = true)]
        public string SayHello(string userName)
        {
            if (User != null)
            {
                if (User.IsValid())
                    return string.Format("Hello...{0} {1} ☺ ", userName,
                        DateTime.Now.ToString("tt") == "AM" ? " good morning " : " good evening ");
                else
                    return "Error in authentication";
            }
            else
            {
                return "Error in authentication";
            }
        }
    }
}
