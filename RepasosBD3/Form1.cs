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
    public partial class Form1 : Form
    {
        public SqlConnection cn;
        private AlumnosQry alumnosQry;
        private NotasQry notasQry;

        public Form1()
        {
            InitializeComponent();
            cn = new SqlConnection("Data Source=(local);Initial Catalog=parainfo;Integrated Security=SSPI;");
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void consultaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(AlumnosQry))
                {
                    form.Activate();
                    return;
                }
            }

            alumnosQry = new AlumnosQry(this);
            alumnosQry.MdiParent = this;
            alumnosQry.Show();
            alumnosQry.BringToFront();
        }

        private void nuevoAlumnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AlumnosIns alumnosIns = new AlumnosIns(this, alumnosQry);

            alumnosIns.MdiParent = this;
            alumnosIns.Show();
        }

        private void retirarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AlumnosDel alumnosDel = new AlumnosDel(this, alumnosQry);

            alumnosDel.MdiParent = this;
            alumnosDel.Show();
        }

        private void actualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AlumnosUpd alumnosUpd = new AlumnosUpd(this, alumnosQry);

            alumnosUpd.MdiParent = this;
            alumnosUpd.Show();
        }

        private void consultaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(NotasQry))
                {
                    form.Activate();
                    return;
                }
            }

            notasQry = new NotasQry(this);
            notasQry.MdiParent = this;
            notasQry.Show();
            notasQry.BringToFront();
        }

        private void nuevaNotaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NotasIns notasIns = new NotasIns(this, notasQry);

            notasIns.MdiParent = this;
            notasIns.Show();
        }

        private void retirarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            NotasDel notasDel = new NotasDel(this, notasQry);

            notasDel.MdiParent = this;
            notasDel.Show();
        }

        private void actualizarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            NotasUpd notasUpd = new NotasUpd(this, notasQry);

            notasUpd.MdiParent = this;
            notasUpd
                .Show();
        }

        private void promedioDeAlumnosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cantidadDeNotasPorAlumnoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
