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
    public partial class ListaPytań : UserControl
    {
        public ListaPytań()
        {
            InitializeComponent();
        }

        public void changeRate(int nrPytania)
        {
            foreach(Control e in tableLayoutPanel1.Controls.OfType<Button>())
            {
                if (e.Name.Equals("pytanie" + nrPytania))
                    e.BackColor = Color.DarkOrange;
                else
                    e.BackColor = Color.Transparent;
            }
        }
        public int GetWynik()
        {
            int result = 0;

            foreach (Control e in tableLayoutPanel1.Controls.OfType<Button>())
            {
                if (e.BackColor == Color.DarkOrange)
                    result += Int32.Parse(e.Name.Substring(7));
            }
            return result;
        }

        public string showAward()
        {
            String result = "";

            foreach (Control e in tableLayoutPanel1.Controls.OfType<Button>())
            {
                if (e.BackColor == Color.DarkOrange)
                    result += e.Text;
            }
            return result;
        }
    }
}
