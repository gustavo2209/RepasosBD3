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

        }
    }
}
