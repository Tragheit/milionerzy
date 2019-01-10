using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace milionerzy
{
    public partial class NieOdbiera : UserControl
    {
        public NieOdbiera()
        {
            InitializeComponent();
        }

        private void ZamknijClicked(Object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
