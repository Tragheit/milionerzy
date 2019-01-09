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
    public partial class Wygrana : UserControl
    {
        public Wygrana(String nick)
        {
            InitializeComponent();
            this.graczNick.Text = nick;
        }
    }
}
