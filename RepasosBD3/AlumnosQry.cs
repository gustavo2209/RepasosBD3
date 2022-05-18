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
    public partial class AlumnosQry : Form
    {
        private Form1 form1;

        public AlumnosQry()
        {
            InitializeComponent();
        }

        public AlumnosQry(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
        }

        private void AlumnosQry_Load(object sender, EventArgs e)
        {
            consulta();
        }

        public void consulta()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM alumnos2", form1.cn);
            DataSet ds = new DataSet();
            da.Fill(ds);

            dataGridView1.DataSource = ds.Tables[0];
        }
    }
}
