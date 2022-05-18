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
    public partial class AlumnosIns : Form
    {
        private Form1 form1;
        private AlumnosQry alumnosQry;

        public AlumnosIns()
        {
            InitializeComponent();
        }

        public AlumnosIns(Form1 form1, AlumnosQry alumnosQry)
        {
            InitializeComponent();
            this.form1 = form1;
            this.alumnosQry = alumnosQry;
        }

        private void AlumnosIns_Load(object sender, EventArgs e)
        {

        }
    }
}
