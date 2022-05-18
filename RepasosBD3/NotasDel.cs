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
    public partial class NotasDel : Form
    {
        private Form1 form1;
        private NotasQry notasQry;

        public NotasDel()
        {
            InitializeComponent();
        }

        public NotasDel(Form1 form1, NotasQry notasQry)
        {
            InitializeComponent();
            this.form1 = form1;
            this.notasQry = notasQry;
        }

        private void NotasDel_Load(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT idalumno, nombre FROM alumnos2", form1.cn);
            DataSet ds = new DataSet();
            da.Fill(ds);

            comboBox1.DataSource = ds.Tables[0];
            comboBox1.ValueMember = "idalumno";
            comboBox1.DisplayMember = "nombre";

            CboNotas();
        }

        private void CboNotas()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT idnota, nota FROM notas WHERE idalumno = " + comboBox1.SelectedValue, form1.cn);
            DataSet ds = new DataSet();
            da.Fill(ds);

            comboBox2.DataSource = ds.Tables[0];
            comboBox2.ValueMember = "idnota";
            comboBox2.DisplayMember = "nota";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex != -1)
            {
                SqlCommand cm = new SqlCommand();

                cm.Connection = form1.cn;
                cm.CommandText = "DELETE FROM notas WHERE idnota = " + comboBox2.SelectedValue;
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
                MessageBox.Show("Seleccione nota a retirar");
            }
        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            CboNotas();
        }
    }
}
