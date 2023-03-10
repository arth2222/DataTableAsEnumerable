using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataBaseLayer;

namespace Tverrfaglig
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Text();
            }
        }
        public void Text()
        {
            DBLayer dbl = new DBLayer();
            var GetAllDataFromArlyAI = dbl.GetAllDataFromArlyText();
            var arlyText = "";
            foreach (DataRow row in GetAllDataFromArlyAI.AsEnumerable())
            {
                arlyText = row["text"].ToString();
            }
            ArlyText.Text = arlyText;
        }

        protected void Admin_Click(object sender, EventArgs e)
        {
            Response.Redirect("Admin.aspx");
        }
    }
}