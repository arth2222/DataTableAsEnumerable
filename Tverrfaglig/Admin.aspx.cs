using DataBaseLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Tverrfaglig
{
    public partial class Admin : System.Web.UI.Page
    {
        private DBLayer dbl = new DBLayer();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Text();
            }
        }
        protected void Text()
        {
            var GetAllDataFromArlyAI = dbl.GetAllDataFromArlyText();
            var arlytext = "";
            foreach (DataRow row in GetAllDataFromArlyAI.AsEnumerable())
            {
                arlytext = row["text"].ToString();
            }
            EditArlyText.Text = arlytext;
        }

        protected void EditArlyTextButton_Click(object sender, EventArgs e)
        {
            dbl.EditTextOnButton(EditArlyText.Text);
            Text();
        }
        protected void Tilbake_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx");
        }
    }
}