using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CardPicker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Card3PIC_Click(object sender, EventArgs e)
        {
            CardLB.Text = "You picked the Two of Clubs!";
        }

        private void Card5PIC_Click(object sender, EventArgs e)
        {
            CardLB.Text = "You picked the Ten of Spades!";
        }

        private void Card4PIC_Click(object sender, EventArgs e)
        {
            CardLB.Text = "You picked the Ace of Spades!";
        }

        private void CardLB_Click(object sender, EventArgs e)
        {
            CardLB.Text = "";
        }

        private void Card2PIC_Click(object sender, EventArgs e)
        {
            CardLB.Text = "You picked the Seven of Diamonds!";
        }

        private void Card1PIC_Click(object sender, EventArgs e)
        {
            CardLB.Text = "You picked the Red Joker!";
        }
    }
}
