using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OneforAllWinForms
{
    public partial class FormFibonaci : Form
    {
        public FormFibonaci()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1 != null && textBox2 != null)
            {
                try
                {
                    foreach (Control control in groupBox1.Controls)
                    {
                        RadioButton rb = control as RadioButton;
                        if (rb != null && rb.Checked)
                        {
                            
                           string str= rb.Text;


                            break;
                        }
                    }
                }
                catch (Exception ex) { }
            }
        }

        class Fibo
        {
            
            public void start(string str)
            {
                if (str.Equals("int")) {
                    int start, end;
                }
                else if (str.Equals("uint")) {
                    uint start, end;
                }
                else if (str.Equals("double")) {
                    double start, end;
                }
                else if (str.Equals("ulong")) {
                    ulong start, end;
                }

            }
        }

    }
}
