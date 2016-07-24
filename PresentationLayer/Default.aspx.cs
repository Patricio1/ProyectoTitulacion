using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessObject;
using DataAccessLayer;


namespace PresentationLayer
{
    public partial class Default : System.Web.UI.Page
    {
        Estudiante estudiante = new Estudiante();
        EstudianteDAL estudianteDAL = new EstudianteDAL();
        protected void Page_Load(object sender, EventArgs e)
        {

            //GridView1.DataSource=estudianteDAL.ListarEstudiantes();
            //GridView1.DataBind();
            //localhost.Service1 ls = new localhost.Service1();
            //GridView1.DataSource= ls.GetEstudiantes();
            //GridView1.DataBind();


        }

        protected void Button11_Click1(object sender, EventArgs e)
        {
            if (Button11.Text.Contains("OK"))
            {
                
                CheckBox1.Checked = true;
                CheckBox2.Checked = true;
                CheckBox3.Checked = true;
                CheckBox4.Checked = true;
                CheckBox5.Checked = true;
                CheckBox6.Checked = true;
                CheckBox7.Checked = true;
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

        protected void btnBuscarCedula_Click(object sender, EventArgs e)
        {
            try
            {
                estudiante = estudianteDAL.GetEstudianteById(TextBox10.Text);
                TextBox1.Text = estudiante.Nombre + " " + estudiante.Apellido;
                TextBox2.Text = estudiante.NumeroCreditos.ToString();
                TextBox3.Text = estudiante.Carrera;
                if (estudiante.CreditosMalla)
                { 
                    CheckBox2.Checked = true; Button4.CssClass = "btn btn-xs btn-success"; Button4.Text = "OK"; 
                } else { 
                    CheckBox2.Checked = false; Button4.Text = "Por Verificar"; Button4.CssClass = "btn btn-xs btn-warning"; 
                }
                if (estudiante.Idiomas) 
                { CheckBox1.Checked = true; Button5.CssClass = "btn btn-xs btn-success"; Button5.Text = "OK"; 
                } else { 
                    CheckBox1.Checked = false; Button5.Text = "Por Verificar"; Button5.CssClass = "btn btn-xs btn-warning"; 
                }
                if (estudiante.CCFF) 
                { CheckBox3.Checked = true; Button6.CssClass = "btn btn-xs btn-success"; Button6.Text = "OK"; 
                } else {
                    CheckBox3.Checked = false; Button6.Text = "Por Verificar"; Button6.CssClass = "btn btn-xs btn-warning"; 
                }
                if (estudiante.Practicas) 
                { CheckBox4.Checked = true; Button7.CssClass = "btn btn-xs btn-success"; Button7.Text = "OK"; 
                } else { CheckBox4.Checked = false; Button7.Text = "Por Verificar"; Button7.CssClass = "btn btn-xs btn-warning"; 
                }
                if (estudiante.Vinculacion) { 
                    CheckBox5.Checked = !false; Button8.CssClass = "btn btn-xs btn-success"; Button8.Text = "OK"; 
                } else { CheckBox5.Checked = false; Button8.Text = "Por Verificar"; Button8.CssClass = "btn btn-xs btn-warning"; 
                }
                if (estudiante.ValoresPagados)
                { CheckBox6.Checked = !false; Button9.CssClass = "btn btn-xs btn-success"; Button9.Text = "OK"; 
                } else { CheckBox6.Checked = false; Button9.Text = "Por Verificar"; Button9.CssClass = "btn btn-xs btn-warning"; 
                }
            }catch(Exception ex){
            }
        }
    }
}