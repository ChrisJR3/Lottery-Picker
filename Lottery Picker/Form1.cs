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

        string[] lottery = new string[20];

        private void generateButton_Click(object sender, EventArgs e)
        {
            //names.Add(randomNumber1, randomNumber2, randomNumber3, randomNumber4, randomNumber5, randomNumber6);

            outputLabel.Text = "";

            for (int i = 0; i < 7; i++)
            {
                int value = randomNumber1 = randGenerator.Next(1, 50);

                if (lottery.Contains(value))
                {
                    value = randomNumber2;
                }
                lottery.Add(value);
            }
            outputLabel.Text += lottery[];
        }
    }
}
