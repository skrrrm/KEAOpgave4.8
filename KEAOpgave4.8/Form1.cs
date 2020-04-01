using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KEAOpgave4._8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCalc_Click(object sender, EventArgs e)
        {
            listBoxResult.Items.Clear(); // Clearing listbox

            // Variables
            int sum, x = 0, y = 1, i = 0, count = 0;

            // try-catch for wrong input
            try
            {
                i = Convert.ToInt32(textBoxInput.Text); // Converting text to int
            }
            catch
            {
                MessageBox.Show("Numbers only!", "ERROR!", MessageBoxButtons.OK); // error
            }

            // adding zero and 1 to the first two items of the list (first two fibonacci numbers)
            listBoxResult.Items.Add(x);
            listBoxResult.Items.Add(y);

            // + 2 cause were adding the first two fibonacci numbers to the list outside of the loop.
            // This way the input number of [i] corresponds to the number of items in the list.
            // Maybe not the best solution?
            while (count + 2 < i)
            {
                sum = x + y; // 0+1=1,  1+1=2,  1+2=3,  3+2=5,  5+3=8 and so on
                listBoxResult.Items.Add(sum); // adding sum to list while the loop runs

                // See sum comment right above
                x = y;  
                y = sum; 

                count++; // so we can use user input for how many fibonacci numbers we want to show
            }
        }
    }
}
