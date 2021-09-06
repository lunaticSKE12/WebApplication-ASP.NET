using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            CheckAge(int.Parse(Request.Cookies["UserSetting"].Value));
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int years = DateTime.Now.Year;
            int age = years - int.Parse(txtYears.Text);
            WriteCookie(age);
            CheckAge(int.Parse(Request.Cookies["UserSetting"].Value));


        }

        private void CheckAge(int age)
        {
            if (age >= 15)
            {
                // Server.Transfer("Member.aspx");
                Response.Redirect("Member.aspx");
            }
            else
            {
                Response.Write("Error !!");
            }
        }

        private void WriteCookie(int age)
        {
            HttpCookie userCookie = new HttpCookie("UserSetting");
            userCookie.Value = age.ToString();
            userCookie.Expires = DateTime.Now.AddDays(3d);
            Response.Cookies.Add(userCookie);
        }


        private int ReadCookie()
        {
            HttpCookie userCookies = Request.Cookies["UserSetting"];
            return int.Parse(userCookies.Value);
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}