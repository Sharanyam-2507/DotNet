using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.ModelBinding;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FirstWebForm
{
    public partial class Dashboard : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                List<Employee> employees = new List<Employee>();
                employees.Add(new Employee() { EmpId=1001, Name="Taehyung", Designation="Doctor"});
                employees.Add(new Employee() { EmpId =1002, Name = "Jimin", Designation = "Singer" });
                employees.Add(new Employee() { EmpId =1003, Name = "Jungkook", Designation = "Dancer" });
                ViewState["EmpData"] = employees;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Button1.Text ="You are Logged In as:"+ Convert.ToString(Session["Username"]);
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Button2.Text = "Email id is:" + Convert.ToString(Session["Email"]);
        }

        protected void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Label1.Text = "Selected values is:" + ListBox1.SelectedValue.ToString();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            List<string> dataFromSession = (List<string>)Session["Kdrama"];
            ListBox2.DataSource = dataFromSession;
            ListBox2.DataBind();
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            HttpCookie varRaedCookie=Request.Cookies["RemindMe"];
            Button4.Text = varRaedCookie.Value;

            HttpCookie varprefCookie = Request.Cookies["Preferences"];
            string cookieValue = varprefCookie.Value;
            string[] splits = cookieValue.Split(':');

            ApplyColor(splits[0], "BackColor");
            ApplyColor(splits[1], "ForeColor");


        }

        private void ApplyColor(string color, string property)
        {
            System.Drawing.Color resultcolor = System.Drawing.Color.White;
            switch (color)
            {
                case "Purple": resultcolor = System.Drawing.Color.Purple;
                    break;
                case "White":
                    resultcolor = System.Drawing.Color.White;
                    break;
                default:
                    resultcolor = System.Drawing.Color.Tomato;
                    break;
            }
            if (property =="BackColor")
            {
                ListBox1.BackColor = resultcolor;
                ListBox2.BackColor = resultcolor;
            }
            else if (property == "ForeColor")
            {
                ListBox1.ForeColor = resultcolor;
                ListBox2.ForeColor = resultcolor;
            }
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            GridView1.DataSource = ViewState["EmpData"];
            GridView1.DataBind();
        }
    }
}