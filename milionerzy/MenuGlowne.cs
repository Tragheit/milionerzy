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
    public partial class MenuGlowne : UserControl
    {
        public MenuGlowne()
        {
            InitializeComponent();
        }

        private void nowaGraClicked(object sender, EventArgs e)
        {
            var temp = new PodajNick();
            temp.Parent = this;
            temp.Dock = DockStyle.Fill;
            temp.BringToFront();
        }

        private void statystykiClicked(object sender, EventArgs e)
        {
            FindForm().WindowState = FormWindowState.Maximized;
            this.MinimumSize = this.Size;
            this.MaximumSize = this.Size;

            var temp = new Statystyki();     
            temp.Parent = this;
            temp.Dock = DockStyle.Fill;
            temp.BringToFront();
        }

        private void koniecGryClicked(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
