using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            MyServ1111.MyService serv = new MyServ1111.MyService();
            serv.UserDetailsValue = new MyServ1111.UserDetails {
            userName= "Kevin",
            password = "1234"};

            lbl_Kevin.Text = serv.SayHello("Kevin from Web Service");
            lbl_Kevin.BackColor = Color.Red;
        }
    }
}