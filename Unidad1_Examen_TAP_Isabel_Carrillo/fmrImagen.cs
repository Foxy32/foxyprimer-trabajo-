using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Unidad1_Examen_TAP_Isabel_Carrillo
{
    public partial class fmrImagen : Form
    {
        int x, y;
        public fmrImagen(int x, int y)
        {
            InitializeComponent();
            this.x = x;
            this.y = y;
        }

        private void fmrImagen_Load(object sender, EventArgs e)
        {
            this.Location = new Point(x, y);
        }

        
    }
}
