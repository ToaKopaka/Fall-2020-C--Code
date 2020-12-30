using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace ExcitingVirtualPet
{
    public partial class Form1 : Form
    {

        BinaryFormatter binaryFormatter = new BinaryFormatter();

        PetClass PetA = new PetClass();


        int counter = 0;
        //Extra feature mailman and it also uses events
        Mailman Man = new Mailman();

        public Form1()
        {
            InitializeComponent();
            Man.Mail += PetA.MailAttack;
        }


        private void UpdateView()
        {
            //set up everything that needs to be checked or changed everytime the app updates
            hungerMeter.Value = PetA.petHunger;
            thirstMeter.Value = PetA.petThirst;
            boredomMeter.Value = PetA.petBoredom;
            affectionMeter.Value = PetA.petAffection;

            waterAmountBar.Value = PetA.currentWater;
            foodAmountBar.Value = PetA.currentFood;
            //check mailman counter
            if (counter >= 5)
            {
                //Extra feature mailman and it also uses events
                Man.MailArrives(1);


                MailAttkLabel.Text = PetA.Attacks.ToString();
                counter = 0;
                UpdateView();
            }



            //check every update if the pet will leave
            if (PetA.maybeTakePetAway(PetA) != false)
            {
                //replace image with lack of cat
                petPictureBox.Image = Properties.Resources.cat_leaving;

                //disable buttons
                feedCatButton.Enabled = false;
                catWaterButton.Enabled = false;
                catPlayButton.Enabled = false;
                petCatButton.Enabled = false;
            }

            TrickLabel.Text = PetA.TricksLearned.ToString();


            //Check every update to see if 5 pet or play actions have been done to make the pet tired and fall asleep
            //User wont be able to use buttons as there will be a message box on their screen saying pet is asleep
            if (PetA.SleepCounter > 5)
            {
                MessageBox.Show("Your pet is asleep");
                PetA.SleepCounter = 0;
            }


        }

        private void feedCatButton_Click(object sender, EventArgs e)
        {
            //Changing from the code being in the button events to their own classes for encapsulation
            PetA.feedPet(PetA);
            UpdateView();
            counter++;

        }

        private void catWaterButton_Click(object sender, EventArgs e)
        {
            PetA.waterPet(PetA);
            UpdateView();
            counter++;
        }

        private void catPlayButton_Click(object sender, EventArgs e)
        {
            PetA.playPet(PetA);
            UpdateView();
            counter++;
        }

        private void petCatButton_Click(object sender, EventArgs e)
        {
            PetA.petPet(PetA);
            UpdateView();
            counter++;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            PetA.InitializeBird();
            petPictureBox.Image = PetA.Picture;
            PetA.InitializeFrames();
            UpdateView();
            counter = 0;
        }

        private void CatButton_Click(object sender, EventArgs e)
        {
            PetA.InitializeCat();
            petPictureBox.Image = PetA.Picture;
            PetA.InitializeFrames();
            UpdateView();
            counter = 0;
            MailAttkLabel.Text = "0";
        }

        private void DogButton_Click(object sender, EventArgs e)
        {
            PetA.InitializeDog();
            petPictureBox.Image = PetA.Picture;
            PetA.InitializeFrames();
            UpdateView();
            counter = 0;
            MailAttkLabel.Text = "0";
        }

        private void BirdButton_Click(object sender, EventArgs e)
        {
            PetA.InitializeBird();
            petPictureBox.Image = PetA.Picture;
            PetA.InitializeFrames();
            UpdateView();
            counter = 0;
            MailAttkLabel.Text = "0";

        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                String filename = saveFileDialog1.FileName;

                using (Stream output = File.Create(filename))
                {
                    binaryFormatter.Serialize(output, PetA);
                }
                //keep getting an error with saving where it can't serialize the timer?
                //Don't really know what to do with that


            }
        }

        private void LoadBtn_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                String filename = openFileDialog1.FileName;

                using (Stream input = File.OpenRead(filename))
                {
                    PetA = (PetClass)binaryFormatter.Deserialize(input);
                }

            }
        }
    }

}
