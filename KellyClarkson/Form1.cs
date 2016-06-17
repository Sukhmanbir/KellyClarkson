using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KellyClarkson
{
    public partial class kellyClarksonForm : Form
    {
        const int five = 5;
        const int three = 3;
        int i;

        public kellyClarksonForm()
        {
            InitializeComponent();
        }

        private void outputRichTextBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void kellyClarksonForm_Load(object sender, EventArgs e)
        {
            for (i = 1; i <= 100; i++)
            {
                if (i % three == 0 && i % five == 0)
                {
                    outputRichTextBox.Text += "Kelly Clarkson\n\n";
                }
                else if (i % five == 0)
                {
                    outputRichTextBox.Text += "Clarkson\n\n";
                }
                else if (i % three == 0)
                {
                    outputRichTextBox.Text += "Kelly\n\n";
                }
                else if (i % three != 0 && i % five != 0)
                {
                    int number = i;
                    outputRichTextBox.Text += number.ToString() + "\n\n";
                }
            }
        }
    }
}
