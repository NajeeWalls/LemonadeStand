using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LemonadeStand
{
    public partial class RevenueForm : Form
    {
        private decimal lemonsDecimal;
        private decimal cupsOfSugarDecimal;
        private int iceCubeInteger;
        private decimal totalExpenseDecimal;
        private int paperCupInteger;
        private const int STARTING_CUPS_PER_PITCHER = 12;
        
        //property blocks

        public decimal pitcherlemonsDecimal
        {
            set
            {
                lemonsDecimal = value;
            }
        }

        public decimal pitchercupsOfSugarDecimal
        {
            set
            {
                cupsOfSugarDecimal = value;
            }
        }

        public int pitchericeCubeInteger
        {
            set
            {
                iceCubeInteger = value;
            }
        }

        public decimal profitExpenseDecimal
        {
            set
            {
                totalExpenseDecimal = value;
            }
        }
        public int profitPaperCupInteger
        {
            set
            {
                paperCupInteger = value;
            }
        }



        public RevenueForm()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            //2014 update: I don't know why I decided to declare all these variables here.
            
            int cupsPerPitcherInteger;
            int revLemons;
            decimal revSugar;
            int revIceCube;
            decimal revPricePerCup;
            decimal potentailRevenue;
            decimal totalprofits;
            int cupsOfLemonade;

            

            revLemons = int.Parse(lemonsTextBox.Text);
            revSugar = decimal.Parse(sugarTextBox.Text);
            revIceCube = int.Parse(iceTextBox.Text);
            revPricePerCup = decimal.Parse(priceTextBox.Text);

            

            // No ice in cup = 12 cups per pitcher
            //for every ice cube per cup, and extra cup of lemonade can be made
            //This is the number of cups per pitcher
            cupsPerPitcherInteger = STARTING_CUPS_PER_PITCHER + revIceCube;
            

            //Find the lowest number of potentail cups each item can make
            
            if ((cupsOfSugarDecimal/revSugar) < (lemonsDecimal/revLemons))
            {//cast into an integer
                lemonsDecimal = (cupsOfSugarDecimal / revSugar);
            }

            if ((iceCubeInteger / revIceCube) < lemonsDecimal)
            {
                lemonsDecimal = (iceCubeInteger / revIceCube);
            }
            /*if (paperCupInteger < lemonsDecimal)
            {
                lemonsDecimal = paperCupInteger;
            }
            */
            //2014 update: added a int cast here.
            cupsOfLemonade = (int)(lemonsDecimal * cupsPerPitcherInteger);
            
            if (paperCupInteger < cupsOfLemonade)
            {
                cupsOfLemonade = paperCupInteger;
            }

            lemonadeTextBox.Text = cupsOfLemonade.ToString();
       
            //multiply the number of cups that can be made by the price of cups for potentail revenue.
            
            potentailRevenue = (cupsOfLemonade * revPricePerCup);
            revenueTextBox.Text = potentailRevenue.ToString("C");
            //subtract the revenue from the expense of inventory for total profits.
            
            totalprofits = (potentailRevenue - totalExpenseDecimal);
            profitsTextBox.Text = totalprofits.ToString("C");

            if (totalprofits > 0)
            {
                profitsTextBox.BackColor = Color.Green;
            }
            else
            {
                profitsTextBox.BackColor = Color.Red;
            }




        }

    }
}
