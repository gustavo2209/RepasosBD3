using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        }
    }
}
