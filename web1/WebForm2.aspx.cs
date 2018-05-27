using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace web1
{
  
    public partial class WebForm2 : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }
        
        private string getname()
        {
            string username = this.TextBox1.Text;
            Session["username"] = username;
            return username;
        }
        
        
        protected void Button1_Click1(object sender, EventArgs e)
        {
            String username = getname();
            String co = "1";
            if(Request.Cookies[username]==null)
            {
                HttpCookie hcookie = new HttpCookie(username);
                hcookie.Values["username"] = this.TextBox1.Text;
                //hcookie.Values.Add("username", username);
                hcookie.Values["count"] = "1";
                //hcookie.Values.Add("count", "1");
                hcookie.Expires = DateTime.Now.AddDays(20);
                Response.Cookies.Add(hcookie);
            }
            else
            {
                HttpCookie hcookie = new HttpCookie(username);
                hcookie.Values["username"] = this.TextBox1.Text;
                //hcookie.Values.Add("username", username);
                 hcookie.Values["count"] = (Convert.ToInt32(Request.Cookies[username].Values["count"])+ 1).ToString();
                //hcookie.Values.Add("count", (Convert.ToInt32(Request.Cookies[username].Values["count"]) + 1).ToString());
                hcookie.Expires = DateTime.Now.AddDays(20);
               
                Response.AppendCookie(hcookie);

            }
            Response.Redirect("turn_to_page.aspx");
        }
    }
}