using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FireGameLovepreet
{
    public partial class Form1 : Form
    {
        //global declaration of the variable for timer that is used to opn the next page 
        int tmr = 0;
        public Form1()
        {
            InitializeComponent();
        }
        //timer code that is used to open the another page of the class 
        private void timer1_Tick(object sender, EventArgs e)
        {
            tmr = tmr + 10;
            if (tmr==50) {
                timer1.Enabled = false;
                GameArea obj = new GameArea();
                obj.Visible = true;
            }
        }
    }
}
