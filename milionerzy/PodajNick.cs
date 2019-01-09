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
    public partial class PodajNick : UserControl
    {
        public String nick;

        public PodajNick()
        {
            InitializeComponent();
        }

        private void startButtonClicked(object sender, EventArgs e)
        {
            nick = podajNickTextBox.Text;

            var temp = new NowaGra(nick);
            temp.Parent = this;
            temp.Dock = DockStyle.Fill;
            temp.BringToFront();
        }
    }
}
