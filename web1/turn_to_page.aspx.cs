using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace web1
{
    public partial class turn_to_page : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["username"]==null)
            {
                Response.Write("请输入用户名！！！" + "<br/>");
            }
            else
            {
                
                String loginname = Session["username"].ToString();
                Response.Write("登录用户是:" + Request.Cookies[loginname].Values["username"].ToString() + "<br/>");
                Response.Write("登录次数是:" + Request.Cookies[loginname]["count"].ToString() + "<br/>");
            }
        }
    }
}