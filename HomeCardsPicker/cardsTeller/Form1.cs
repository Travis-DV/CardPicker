using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//MORE RANDOM - mom


namespace cardsTeller
{
    public partial class Form1 : Form
    {

        public List<string[]> cards = new List<string[]>();

        public Form1()
        {
            InitializeComponent();
        }

        private void centerlb(string messige)
        {
            CardLB.Text = $"Number {messige}";
            int heightbuffer = 35;
            int width = (this.Size.Width/2) - (CardLB.Width / 2);
            int height = (this.Size.Height/2) - (CardLB.Height / 2) + heightbuffer;
            CardLB.Location = new System.Drawing.Point(width, height);
            CardLB.Visible = true;
        }

        private void getpic()
        {
            string startingdir = $"{Application.StartupPath}\\PNG-cards-1.3/";
            //C:\\Users\\travis\\OneDrive - Findley\\Coding\\vscode\\c#\\homec#\\cardsTeller\\PNG-cards-1.3/
            string[] cardnumb = { "ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "jack", "queen", "king" };
            string[] cardcolors = { "spades", "diamonds", "hearts", "clubs" };

            cards.Add( new string[] {startingdir, cardnumb[RandomNumber.Between(0, 11)], cardcolors[RandomNumber.Between(0, 3)] });
        }

        private void setpics()
        {
            cards = new List<string[]>();
            for (int i = 0; i < 5; i++)
            {
                getpic();
            }
            Card1PIC.Image = Image.FromFile($"{cards[0][0]}{cards[0][1]}_of_{cards[0][2]}.png");
            Card2PIC.Image = Image.FromFile($"{cards[1][0]}{cards[1][1]}_of_{cards[1][2]}.png");
            Card3PIC.Image = Image.FromFile($"{cards[2][0]}{cards[2][1]}_of_{cards[2][2]}.png");
            Card4PIC.Image = Image.FromFile($"{cards[3][0]}{cards[3][1]}_of_{cards[3][2]}.png");
            Card5PIC.Image = Image.FromFile($"{cards[4][0]}{cards[4][1]}_of_{cards[4][2]}.png");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            setpics();
        }

        private void randomize_Click(object sender, EventArgs e)
        {
            setpics();
        }

        private void Card1PIC_Click(object sender, EventArgs e)
        {
            centerlb($"You pulled a {cards[0][1]} of {cards[0][2]}");
        }

        private void Card2PIC_Click(object sender, EventArgs e)
        {
            centerlb($"You pulled a {cards[1][1]} of {cards[1][2]}");
        }

        private void Card3PIC_Click(object sender, EventArgs e)
        {
            centerlb($"You pulled a {cards[2][1]} of {cards[2][2]}");
        }

        private void Card4PIC_Click(object sender, EventArgs e)
        {
            centerlb($"You pulled a {cards[3][1]} of {cards[3][2]}");
        }

        private void Card5PIC_Click(object sender, EventArgs e)
        {
            centerlb($"You pulled a {cards[4][1]} of {cards[4][2]}");
        }
    }

    public static class RandomNumber
    {
        private static readonly RNGCryptoServiceProvider _generator = new RNGCryptoServiceProvider();
        public static int Between(int minimumValue, int maximumValue)
        {
            byte[] randomNumbers = new byte[1];
            _generator.GetBytes(randomNumbers);
            double asciiValueOfRandomCharacter = Convert.ToDouble(randomNumbers[0]);
            double multiplier = Math.Max(0, (asciiValueOfRandomCharacter / 255d) - 0.00000000001d);
            int range = (maximumValue - 1) - minimumValue;
            double randomValueInRange = Math.Floor(multiplier * range);
            return (int)(minimumValue + randomValueInRange);
        }
    }
}
