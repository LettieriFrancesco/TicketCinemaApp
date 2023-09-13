using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TicketCinemaApp
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string usernameConfig = ConfigurationManager.AppSettings["username"];
            string passwordConfig = ConfigurationManager.AppSettings["password"];

            string usernameInserito = TextBox1.Text;
            string passwordInserito = TextBox2.Text;

            if(usernameInserito == usernameConfig && passwordInserito == passwordConfig)
            {
                HttpCookie cookie = new HttpCookie("CINEMA_COOKIE");
                cookie.Values["Username"] = usernameInserito;
                cookie.Expires = DateTime.Now.AddDays(1);
                Response.Cookies.Add(cookie);
                Response.Redirect("Prenotazione.aspx");
            }
            else
            {
                Response.Cookies["CINEMA_COOKIE"].Expires = DateTime.Now.AddDays(-1);

            }
        }
    }
}