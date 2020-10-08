using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace ReturnOfMasters
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        IReport[] ReportArray = new IReport[5];
        //counter is the tracker for the array's position
        int counter = 0;

        // I am using the same code for each of the different master buttons
    
        private void HatMasterBtn_Click(object sender, EventArgs e)
        {
            //take in the data from the textbox and the number counter
            String name = nametxtbox.Text;
            int clothingAmount = (int) articleCounter.Value;
            
            //check that the name is not empty and the number is above 0
            if (name != "" && clothingAmount != 0)
            {
                ReportArray[counter] = new HatMaster(name, clothingAmount);
                counter++;
            }
            if (name == "" || clothingAmount == 0)
            {
                MessageBox.Show("Please enter a name or a number above 0.");
            }

            
        }
        private void PantsMasterBtn_Click(object sender, EventArgs e)
        {

            String name = nametxtbox.Text;
            int clothingAmount = (int)articleCounter.Value;
            if (name != "" && clothingAmount != 0)
            {
                ReportArray[counter] = new PantsMaster(name, clothingAmount);
                counter++;
            }
            if (name == "" || clothingAmount == 0)
            {
                MessageBox.Show("Please enter a name or a number above 0.");
            }

        }
        private void RingMasterBtn_Click(object sender, EventArgs e)
        {


            String name = nametxtbox.Text;
            int clothingAmount = (int)articleCounter.Value;
            if (name != "" && clothingAmount != 0)
            {
                ReportArray[counter] = new RingMaster(name, clothingAmount);
                counter++;
            }
            if (name == "" || clothingAmount == 0)
            {
                MessageBox.Show("Please enter a name or a number above 0.");
            }

        }

        private void PersonBtn_Click(object sender, EventArgs e)
        {
            //Person just takes the name
            String name = nametxtbox.Text;
            if (name != "")
            {
                ReportArray[counter] = new Person(name);
                counter++;
            }
            if (name == "")
            {
                MessageBox.Show("Please enter a name or a number above 0.");
            }
        }








        private void RollCallBtn_Click(object sender, EventArgs e)
        {
            //check that the array is not empty if so then run through the contents
            if (counter != 0)
            {
                for (int i = 0; i < counter; i++)
                {
                    MessageBox.Show(ReportArray[i].Report());
                }
            }
            //if the array is empty tell the user it is empty
            if(counter == 0)
            {
                MessageBox.Show("You have not entered any people or masters.");
            }
            //check if the array is full and if so tell the user
            if(counter == 5)
            {
                MessageBox.Show("You have entered the max amount of people!");
            }

        }


    }
}
