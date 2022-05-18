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
    public partial class AlumnosUpd : Form
    {

        private Form1 form1;
        private AlumnosQry alumnosQry;

        public AlumnosUpd()
        {
            InitializeComponent();
        }

        public AlumnosUpd(Form1 form1, AlumnosQry alumnosQry)
        {
            InitializeComponent();
            this.form1 = form1;
            this.alumnosQry = alumnosQry;
        }

        private void AlumnosUpd_Load(object sender, EventArgs e)
        {

        }
    }
}
