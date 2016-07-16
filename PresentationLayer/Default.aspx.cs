using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PresentationLayer
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button11_Click1(object sender, EventArgs e)
        {
            if (Button11.Text.Contains("OK"))
            {
                CheckBox1.Checked = !false;
                CheckBox2.Checked = !false;
                CheckBox3.Checked = !false;
                CheckBox4.Checked = !false;
                CheckBox5.Checked = !false;
                CheckBox6.Checked = !false;
                CheckBox7.Checked = !false;
                Button4.CssClass = "btn btn-xs btn-success";
                Button5.CssClass = "btn btn-xs btn-success";
                Button6.CssClass = "btn btn-xs btn-success";
                Button7.CssClass = "btn btn-xs btn-success";
                Button8.CssClass = "btn btn-xs btn-success";
                Button9.CssClass = "btn btn-xs btn-success";
                Button4.Text = "OK";
                Button5.Text = "OK";
                Button6.Text = "OK";
                Button7.Text = "OK";
                Button8.Text = "OK";
                Button9.Text = "OK";

                Button11.Text = "Desmarcar Todos";
                Button11.CssClass = "btn btn-xs btn-warning";
            }
            else
            {
                CheckBox1.Checked = false;
                CheckBox2.Checked = false;
                CheckBox3.Checked = false;
                CheckBox4.Checked = false;
                CheckBox5.Checked = false;
                CheckBox6.Checked = false;
                CheckBox7.Checked = false;

                Button4.CssClass = "btn btn-xs btn-warning";
                Button5.CssClass = "btn btn-xs btn-warning";
                Button6.CssClass = "btn btn-xs btn-warning";
                Button7.CssClass = "btn btn-xs btn-warning";
                Button8.CssClass = "btn btn-xs btn-warning";
                Button9.CssClass = "btn btn-xs btn-warning";
                Button4.Text = "Por Verificar";
                Button5.Text = "Por Verificar";
                Button6.Text = "Por Verificar";
                Button7.Text = "Por Verificar";
                Button8.Text = "Por Verificar";
                Button9.Text = "Por Verificar";

                Button11.Text = "Marcar todos como OK";
                Button11.CssClass = "btn btn-xs btn-success";
            }
        }
    }
}