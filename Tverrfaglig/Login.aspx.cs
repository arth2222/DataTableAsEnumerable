using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataBaseLayer;

namespace Tverrfaglig
{
    public partial class Login : System.Web.UI.Page
    {
        private DBLayer dbl = new DBLayer();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Tibake_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx");
        }

        protected void LoggInn_Click(object sender, EventArgs e)
        {
            var GetAllDataFromArlyAI = dbl.GetAllDataFromArlyText();
            var LoginPassword = "";
            foreach (DataRow row in GetAllDataFromArlyAI.AsEnumerable())
            {
                LoginPassword = row["passord"].ToString();
            }
            string enteredPassword = passwordTextbox.Text;
            if (enteredPassword == LoginPassword)
            {
                FormsAuthentication.RedirectFromLoginPage(LoginPassword, false);
            }
            else
            {
                WrongPassword.Visible = true;
            }
        }
    }
}