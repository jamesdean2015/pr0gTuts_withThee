using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Spreadsheet_Ranking_Solution
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //counters to find out how many of each p1, p2 and p3
            int onesCounter = 0;
            int twosCounter = 0;
            int threesCounter = 0;

            //grab the input from text box
            string p = textBox1.Text;

            //declare an array to hold data in textbox and grab only the numbers
            string[] pStringArray = { "0", "0", "0" };
            pStringArray[0] = p.Substring(1, 1);
            pStringArray[1] = p.Substring(3, 1);
            pStringArray[2] = p.Substring(5, 1);

            //convert the numbers from string array to int array
            int[] pIntArray = Array.ConvertAll(pStringArray, s => int.Parse(s));

            //use a counter function to fill the counter variables with how many ones twos and threes there are
            foreach (int element in pIntArray)
            {
                if (pIntArray[element] == 1)
                {
                    onesCounter++;
                }
                else if (pIntArray[element]==2)
                {
                    twosCounter++;
                }
                else if (pIntArray[element]==3)
                {
                    threesCounter++;
                }
            }

            //show what the counters are
            MessageBox.Show("counter variables" + "\n" + onesCounter + "\n" + twosCounter + "\n" + threesCounter + "\n");

            do
            {
                foreach (int element in pIntArray)
                {

                    if (element == 1)
                    {
                        
                        if (onesCounter > 1)
                        {
                            pIntArray[element] = 2;
                            onesCounter -= 1;
                            twosCounter += 1;
                        }
                        MessageBox.Show("1'sCounter= " + onesCounter + "\n " + "P" + pIntArray[0] + "P" + pIntArray[1] + "P" + pIntArray[2]);
                    }

                    if (element == 2)
                    {
                        if (twosCounter > 1)
                        {
                            pIntArray[element] = 3;
                            twosCounter -= 1;
                            threesCounter += 1;

                        }
                        MessageBox.Show("2s counter= " +  twosCounter + "\n " + "P" + pIntArray[0] + "P" + pIntArray[1] + "P" + pIntArray[2]);
                    }

                    if (element == 3)
                    {
                        if (threesCounter > 1)
                        {
                            pIntArray[element] = 4;
                            threesCounter -= 1;
                        }
                        MessageBox.Show("3 counter= " +  threesCounter + "\n " + "P" + pIntArray[0] + "P" + pIntArray[1] + "P" + pIntArray[2]);
                    }
                }
            } while (onesCounter > 1 || twosCounter > 1 || threesCounter > 1);
            
            textBox2.Text = "P" + pIntArray[0] + "P" + pIntArray[1] + "P" + pIntArray[2];
         
        }
    }
    
}
