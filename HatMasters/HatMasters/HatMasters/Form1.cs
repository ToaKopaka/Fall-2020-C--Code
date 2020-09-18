using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HatMasters
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
        }
        //counter initialization to keep track of how many masters have been added to array
        int counter = 0;

        //sentinals for goo input checking
        Boolean goodInputName = false;
        Boolean goodInputNum = false;

        //initializing variables to pass data into to pass into the class
        String name;
        byte hats;

        //creating object array
        HatMaker[] masters = new HatMaker[20];
        






        private void rollCallBtn_Click(object sender, EventArgs e)
        {

            //iterate over the array and print out data 
            for (int i = 0; i < masters.Length; i++){
                if(masters[i] != null)
                {
                    masters[i].printInfo();
                }

                
            }
            //reset counter so you can add more masters to list after printing it out
            counter = 0;
           

        }

        private void MakeHatMasterBtn_Click(object sender, EventArgs e)
        {

                //use form input and assign it
                hats = (byte)numericUpDown1.Value;
                name = nametxtbox.Text;


                //input checker
                if(name == "")
                {

                MessageBox.Show("Please enter a real name");
                }
                if (hats == 0)
                {

                    MessageBox.Show("Please enter a number above 0");
                }
                if (name != "")
                {

                    goodInputName = true;
                }
                if (hats != 0)
                {

                    goodInputNum = true;
                }


            if (goodInputName == true & goodInputNum == true)
            {
                if (counter < 20)
                {
                    //insert new object at the index of the counter variable
                    masters[counter] = new HatMaker(name, hats);
                    nameoutlabel.Text = ("You have made a new master thier name is " + name + " and the number of hats they have is " + hats);
                    counter++;
                }
                else
                {
                    nameoutlabel.Text = ("You have entered the max number of hat masters");
                }
            }


        }

       
        
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
