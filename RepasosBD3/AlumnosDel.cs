using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;

namespace RepasosBD3
{
    public partial class AlumnosDel : Form
    {
        private Form1 form1;
        private AlumnosQry alumnosQry;

        public AlumnosDel()
        {
            InitializeComponent();
        }

        public AlumnosDel(Form1 form1, AlumnosQry alumnosQry)
        {
            InitializeComponent();
            this.form1 = form1;
            this.alumnosQry = alumnosQry;
        }

        private void AlumnosDel_Load(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT idalumno, nombre FROM alumnos2", form1.cn);
            DataSet ds = new DataSet();
            da.Fill(ds);

            comboBox1.DataSource = ds.Tables[0];
            comboBox1.ValueMember = "idalumno";
            comboBox1.DisplayMember = "nombre";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex != -1)
            {
                SqlCommand cm = new SqlCommand();

                cm.Connection = form1.cn;
                cm.CommandText = "DELETE FROM alumnos2 WHERE idalumno = " + comboBox1.SelectedValue;
                form1.cn.Open();
                cm.ExecuteNonQuery();
                form1.cn.Close();

                foreach (Form form in Application.OpenForms)
                {
                    if (form.GetType() == typeof(AlumnosQry))
                    {
                        ((AlumnosQry)form).consulta();
                        form.Activate();
                        form.BringToFront();
                    }
                }

                this.Dispose();
            }
            else
            {
                MessageBox.Show("Seleccione Alumno");
            }
        }
    }
}
