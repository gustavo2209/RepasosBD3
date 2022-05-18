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
    public partial class NotasIns : Form
    {

        private Form1 form1;
        private NotasQry notasQry;

        public NotasIns()
        {
            InitializeComponent();
        }

        public NotasIns(Form1 form1, NotasQry notasQry)
        {
            InitializeComponent();
            this.form1 = form1;
            this.notasQry = notasQry;
        }

        private void NotasIns_Load(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT idalumno, nombre FROM alumnos2", form1.cn);
            DataSet ds = new DataSet();
            da.Fill(ds);

            comboBox1.DataSource = ds.Tables[0];
            comboBox1.ValueMember = "idalumno";
            comboBox1.DisplayMember = "nombre";

            for(int i=0; i<=20; i++)
            {
                comboBox2.Items.Add("" + i);
            }

            comboBox2.SelectedIndex = 14;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex != -1)
            {
                SqlCommand cm = new SqlCommand();
                cm.Connection = form1.cn;
                cm.CommandText = "INSERT INTO notas VALUES(" + comboBox1.SelectedValue + ", " + comboBox2.SelectedIndex + ")";
                //MessageBox.Show(cm.CommandText); // PARA SABER LOS POSIBLES ERRORES AL HACER LA CONSULTA
                form1.cn.Open();
                cm.ExecuteNonQuery();
                form1.cn.Close();

                foreach (Form form in Application.OpenForms)
                {
                    if (form.GetType() == typeof(NotasQry))
                    {
                        ((NotasQry)form).consulta();
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
