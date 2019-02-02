using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Callculatorapp
{
    public partial class Form1 : Form
    {

        Double value = 0;
        String Op = "";
        bool Op_pressed = false;

        public Form1()
        {
            InitializeComponent();
        }


        private void Bt1_Click(object sender, EventArgs e)
        {
            if ((Tbresult.Text == "0")||(Op_pressed))
                Tbresult.Clear();

            Op_pressed = false;
            Button b = (Button)sender;
            Tbresult.Text = Tbresult.Text + b.Text;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Tbresult.Text = "0";
        }

        private void Op_click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            Op = b.Text;
            value = Double.Parse(Tbresult.Text);
            Tbvalue.Text = Op+value.ToString();
            Op_pressed = true;
        }

        private void Btequal_Click(object sender, EventArgs e)
        {
            Tbvalue.Clear();

            switch (Op)
            {
                case"+":
                    Tbresult.Text = (value + double.Parse(Tbresult.Text)).ToString();
                    break;
                case "-":
                    Tbresult.Text = (value - double.Parse(Tbresult.Text)).ToString();
                    break;
                case "*":
                    Tbresult.Text = (value * double.Parse(Tbresult.Text)).ToString();
                    break;
                case "/":
                    Tbresult.Text = (value / double.Parse(Tbresult.Text)).ToString();
                    break;
                default:
                    break;
               
            }


            


        }

        private void Btcancel_Click(object sender, EventArgs e)
        {
            Tbvalue.Clear();
            Tbresult.Text="0";
            value = 0;
        }
    }
}
