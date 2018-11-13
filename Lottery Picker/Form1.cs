using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lottery_Picker
{
    public partial class Form1 : Form
    {
        Random randGenerator = new Random();

        int counter = 1;
        int randomNumber1;
        int randomNumber2;
        int randomNumber3;
        int randomNumber4;
        int randomNumber5;
        int randomNumber6;

        public Form1()
        {
            InitializeComponent();
        }

        private void generateButton_Click(object sender, EventArgs e)
        {
            randomNumber1 = randGenerator.Next(6, 50);
            randomNumber2 = randGenerator.Next(6, 50);
            randomNumber3 = randGenerator.Next(6, 50);
            randomNumber4 = randGenerator.Next(6, 50);
            randomNumber5 = randGenerator.Next(6, 50);
            randomNumber6 = randGenerator.Next(6, 50);

            while (counter < 6)
            {
                winningNumberLabel.Text = "";

                winningNumberLabel.Text = randomNumber1 + ", " + randomNumber2 + ", " + randomNumber3 + ", " + randomNumber4 + ", " + randomNumber5 + ", " + randomNumber6;

                if (randomNumber1 < randomNumber2 && randomNumber1 < randomNumber3 && randomNumber1 < randomNumber4 && randomNumber1 < randomNumber5 && randomNumber1 < randomNumber6)
                {
                    winningNumberLabel.Text = randomNumber1 + ", ";
                }
                else if (randomNumber2 < randomNumber1 && randomNumber2 < randomNumber3 && randomNumber2 < randomNumber4 && randomNumber2 < randomNumber5 && randomNumber2 < randomNumber6)
                {
                    winningNumberLabel.Text = randomNumber2 + ", ";
                }
                else if(randomNumber3 < randomNumber1 && randomNumber3 < randomNumber2 && randomNumber3 < randomNumber4 && randomNumber3 < randomNumber5 && randomNumber3 < randomNumber6)
                {
                    winningNumberLabel.Text = randomNumber3 + ", ";
                }
                else if(randomNumber4 < randomNumber1 && randomNumber4 < randomNumber3 && randomNumber4 < randomNumber2 && randomNumber4 < randomNumber5 && randomNumber4 < randomNumber6)
                {
                    winningNumberLabel.Text = randomNumber4 + ", ";
                }
                else if(randomNumber5 < randomNumber1 && randomNumber5 < randomNumber3 && randomNumber5 < randomNumber4 && randomNumber5 < randomNumber2 && randomNumber5 < randomNumber6)
                {
                    winningNumberLabel.Text = randomNumber5 + ", ";
                }
                else if(randomNumber6 < randomNumber1 && randomNumber6 < randomNumber3 && randomNumber6 < randomNumber4 && randomNumber6 < randomNumber5 && randomNumber6 < randomNumber2)
                {
                    winningNumberLabel.Text = randomNumber6 + ", ";
                }

                //if (randomNumber1 < randomNumber2 && randomNumber1 < randomNumber3 && randomNumber1 < randomNumber4 && randomNumber1 < randomNumber5 && randomNumber1 < randomNumber6)
                //{
                //    winningNumberLabel.Text += randomNumber1 + ", ";
                //}
                //else if (randomNumber2 < randomNumber1 && randomNumber2 < randomNumber3 && randomNumber2 < randomNumber4 && randomNumber2 < randomNumber5 && randomNumber2 < randomNumber6)
                //{
                //    winningNumberLabel.Text += randomNumber2 + ", ";
                //}
                //else if (randomNumber3 < randomNumber1 && randomNumber3 < randomNumber2 && randomNumber3 < randomNumber4 && randomNumber3 < randomNumber5 && randomNumber3 < randomNumber6)
                //{
                //    winningNumberLabel.Text += randomNumber3 + ", ";
                //}
                //else if (randomNumber4 < randomNumber1 && randomNumber4 < randomNumber3 && randomNumber4 < randomNumber2 && randomNumber4 < randomNumber5 && randomNumber4 < randomNumber6)
                //{
                //    winningNumberLabel.Text += randomNumber4 + ", ";
                //}
                //else if (randomNumber5 < randomNumber1 && randomNumber5 < randomNumber3 && randomNumber5 < randomNumber4 && randomNumber5 < randomNumber2 && randomNumber5 < randomNumber6)
                //{
                //    winningNumberLabel.Text += randomNumber5 + ", ";
                //}
                //else if (randomNumber6 < randomNumber1 && randomNumber6 < randomNumber3 && randomNumber6 < randomNumber4 && randomNumber6 < randomNumber5 && randomNumber6 < randomNumber2)
                //{
                //    winningNumberLabel.Text += randomNumber6 + ", ";
                //}

                counter++;
            }
            counter = 1;
        }
    }
}
