using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project4
{
    public partial class Form1 : Form
    {
        /*
         *This is a basic program which genrates a random value, and prompts the user to guess the value.
         *and responds accordingly    
         */
        int value, guesses;
        Random rand = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            guesses++;
            label1.Text = "Guess: " + guesses.ToString();
            if (numericUpDown1.Value == value)
            {
                textBox1.Text = "Correct! The number was " + value.ToString() + ". You got it right in ";
                if (guesses == 1) {
                    textBox1.Text = textBox1.Text + "1 guess! Incredible!";
                }
                else if (guesses > 1 && guesses < 4)
                {
                    textBox1.Text = textBox1.Text + guesses.ToString() +" guesses. Great job!";
                }
                else if (guesses > 3 && guesses < 9)
                {
                    textBox1.Text = textBox1.Text + guesses.ToString() + " guesses. Well done.";
                }
                else
                {
                    textBox1.Text = textBox1.Text + guesses.ToString() + " guesses. Took you long enough.";
                }
                textBox1.Text = textBox1.Text + "\r\nPress start game to play again.";
            }
            else if (numericUpDown1.Value < value)
            {
                textBox1.Text = "That guess is too low.";
            }
            else if (numericUpDown1.Value > value)
            {
                textBox1.Text = "That guess is too high.";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            guesses = 0;
            label1.Text = "Guess: " + guesses.ToString();
            value = rand.Next(100) + 1 ;
            textBox1.Text = "Random number generated! Enter your guess into the numeric field and press Guess to see if you're right, can you get it right in less than five guesses?";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
