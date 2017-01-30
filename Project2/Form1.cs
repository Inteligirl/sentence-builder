using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project2
{
    public partial class project2 : Form
    {
        public project2()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {   //exit application
            this.Close();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {   //clear label
            sentenceLabel.Text = " ";
        }

        //button controls to add each letter or word to sentence label
        private void upperAButton_Click(object sender, EventArgs e)
        {
            sentenceLabel.Text += "A";
        }

        private void lowerAButton_Click(object sender, EventArgs e)
        {
            sentenceLabel.Text += "a";
        }

        private void upperAnButton_Click(object sender, EventArgs e)
        {
            sentenceLabel.Text += "An";
        }

        private void lowerAnButton_Click(object sender, EventArgs e)
        {
            sentenceLabel.Text += "an";
        }

        private void upperTheButton_Click(object sender, EventArgs e)
        {
            sentenceLabel.Text += "The";
        }

        private void lowerTheButton_Click(object sender, EventArgs e)
        {
            sentenceLabel.Text += "the";
        }

        private void manButton_Click(object sender, EventArgs e)
        {
            sentenceLabel.Text += "man";
        }

        private void womanButton_Click(object sender, EventArgs e)
        {
            sentenceLabel.Text += "woman";
        }

        private void dogButton_Click(object sender, EventArgs e)
        {
            sentenceLabel.Text += "dog";
        }

        private void catButton_Click(object sender, EventArgs e)
        {
            sentenceLabel.Text += "cat";
        }

        private void carButton_Click(object sender, EventArgs e)
        {
            sentenceLabel.Text += "car";
        }

        private void bicycleButton_Click(object sender, EventArgs e)
        {
            sentenceLabel.Text += "bicycle";
        }

        private void beautifulButton_Click(object sender, EventArgs e)
        {
            sentenceLabel.Text += "beautiful";
        }

        private void bigButton_Click(object sender, EventArgs e)
        {
            sentenceLabel.Text += "big";
        }

        private void smallButton_Click(object sender, EventArgs e)
        {
            sentenceLabel.Text += "small";
        }

        private void strangeButton_Click(object sender, EventArgs e)
        {
            sentenceLabel.Text += "strange";
        }

        private void lookedAtButton_Click(object sender, EventArgs e)
        {
            sentenceLabel.Text += "looked at";
        }

        private void rodeButton_Click(object sender, EventArgs e)
        {
            sentenceLabel.Text += "rode";
        }

        private void spokeToButton_Click(object sender, EventArgs e)
        {
            sentenceLabel.Text += "spoke to";
        }

        private void laughedAtButton_Click(object sender, EventArgs e)
        {
            sentenceLabel.Text += "laughed at";
        }

        private void droveButton_Click(object sender, EventArgs e)
        {
            sentenceLabel.Text += "drove";
        }

        private void spaceButton_Click(object sender, EventArgs e)
        {
            sentenceLabel.Text += " ";
        }

        private void periodButton_Click(object sender, EventArgs e)
        {
            sentenceLabel.Text += ".";
        }

        private void exclamationButton_Click(object sender, EventArgs e)
        {
            sentenceLabel.Text += "!";
        }
    }
}
