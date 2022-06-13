using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DealOrNotDeal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Control> all = this.Controls.OfType<Control>().ToList();
            List<Control> allBoxes = all.Where(x => x is PictureBox).ToList();

            addClickEvent(allBoxes);

            makeElementsVisible(all);

            startBtn.Visible = false;
            pickLabel.Visible = true;
            myBoxLabel.Visible = false;
            gameLabel.Visible = false;
            openBoxLabel.Visible = false;
            bankOfferLabel.Visible = false;
            answerYes.Visible = false;
            answerNo.Visible = false;

            makeBoxesData(Program.boxesData);
            makeBoxes(Program.boxes, Program.boxNumeric, Program.boxesData);
            makePrices(Program.prices);
        }

        private void answerYes_Click(object sender, EventArgs e)
        {
            if (bankOfferLabel.Text == "Смяна на кутиите")
            {
                pickLabel.Visible = true;
                answerYes.Visible = false;
                answerNo.Visible = false;
                bankOfferLabel.Visible = false;
            }
            else
            {
                double offer = calculateBankOffer();

                bankOfferLabel.Text = $"Вие си тръгвате с {offer:f2} лв. Във вашата кутия има {Program.yourBox.FirstOrDefault().Value:f2} лв.";
                List<Control> allControls = this.Controls.OfType<Control>().ToList();
                makeControlsEnabledFalse(allControls);
                answerYes.Visible = false;
                answerNo.Visible = false;
                newGame.Enabled = true;
            }

        }

        private void answerNo_Click(object sender, EventArgs e)
        {
            List<Control> allBoxes = this.Controls.OfType<Control>().Where(x => x is PictureBox).ToList();
            makeControlsEnabledTrue(allBoxes);
            int boxToOffer = calculateBoxToOffer();
            gameLabel.Text = $"Кутии до офертата на банката: {boxToOffer}";
            gameLabel.Visible = true;
            bankOfferLabel.Visible = false;
            answerYes.Visible = false;
            answerNo.Visible = false;
            openBoxLabel.Visible = true;
            bankOfferLabel.Text = "";
        }

        private void newGame_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private static void makeControlsEnabledFalse(List<Control> controls)
        {
            foreach (var item in controls)
            {
                item.Enabled = false;
            }
        }

        private static void makeControlsEnabledTrue(List<Control> controls)
        {
            foreach (var item in controls)
            {
                item.Enabled = true;
            }
        }

        private void addClickEvent(List<Control> allBoxes)
        {
            foreach (var item in allBoxes)
            {
                item.Click += onClick;
            }
        }

        private void onClick(object sender, EventArgs e)
        {
            PictureBox box = sender as PictureBox;
            int yourBoxKey = Program.yourBox.FirstOrDefault().Key;
            Control pictureBox = this.Controls.OfType<Control>().Where(x => x is PictureBox).FirstOrDefault(x => x.Name == $"pictureBox{yourBoxKey}");
            List<Control> textBoxes = this.Controls.OfType<Control>().Where(x => x is TextBox).ToList();
            List<Control> allBoxes = this.Controls.OfType<Control>().Where(x => x is PictureBox).ToList();
            playGame(box, myBoxLabel, pickLabel, gameLabel, openBoxLabel,
                textBoxes, bankOfferLabel, answerYes, answerNo, pictureBox, allBoxes);
        }

        private static void makePrices(List<double> prices)
        {
            prices.Add(0.01);
            prices.Add(0.1);
            prices.Add(0.2);
            prices.Add(0.5);
            prices.Add(1);
            prices.Add(5);
            prices.Add(10);
            prices.Add(20);
            prices.Add(50);
            prices.Add(100);
            prices.Add(200);
            prices.Add(300);
            prices.Add(500);
            prices.Add(750);
            prices.Add(1000);
            prices.Add(2500);
            prices.Add(5000);
            prices.Add(7500);
            prices.Add(10000);
            prices.Add(12500);
            prices.Add(15000);
            prices.Add(25000);
            prices.Add(50000);
            prices.Add(100000);
        }

        private static void makeBoxesData(Dictionary<int, double> boxesData)
        {
            boxesData.Add(1, 0.01);
            boxesData.Add(2, 0.1);
            boxesData.Add(3, 0.2);
            boxesData.Add(4, 0.5);
            boxesData.Add(5, 1);
            boxesData.Add(6, 5);
            boxesData.Add(7, 10);
            boxesData.Add(8, 20);
            boxesData.Add(9, 50);
            boxesData.Add(10, 100);
            boxesData.Add(11, 200);
            boxesData.Add(12, 300);
            boxesData.Add(13, 500);
            boxesData.Add(14, 750);
            boxesData.Add(15, 1000);
            boxesData.Add(16, 2500);
            boxesData.Add(17, 5000);
            boxesData.Add(18, 7500);
            boxesData.Add(19, 10000);
            boxesData.Add(20, 12500);
            boxesData.Add(21, 15000);
            boxesData.Add(22, 25000);
            boxesData.Add(23, 50000);
            boxesData.Add(24, 100000);
        }

        private static void makeBoxes(Dictionary<int, double> boxes, int boxNumeric, Dictionary<int, double> boxesData)
        {
            while (boxesData.Count != 0)
            {
                Random rnd = new Random();
                int num = rnd.Next(1, 25);
                if (boxesData.ContainsKey(num))
                {
                    boxes.Add(boxNumeric, boxesData[num]);
                    boxNumeric++;
                    boxesData.Remove(num);
                }
            }
        }

        private static void makeElementsVisible(List<Control> all)
        {
            foreach (var item in all)
            {
                item.Visible = true;
            }
        }

        private static void playGame(Control pictureBox, Control myBoxLabel,
            Control pickLabel, Control gameLabel,
            Control openBoxLabel, List<Control> textBoxes, Control bankOfferLabel,
            Control answerYes, Control answerNo, Control oldMyBox, List<Control> allBoxes)
        {

            pictureBox.Visible = false;
            if (bankOfferLabel.Text == "Смяна на кутиите")
            {
                makeControlsEnabledTrue(allBoxes);
                oldMyBox.Visible = true;
                int boxNum = 0;
                string curr = "";
                if (pictureBox.Name.Length == 11)
                {
                    curr = pictureBox.Name[pictureBox.Name.Length - 1].ToString();
                    boxNum = Convert.ToInt32(curr);
                }
                else
                {
                    curr = pictureBox.Name.Substring(pictureBox.Name.Length - 2);
                    boxNum = Convert.ToInt32(curr);
                }

                int oldBoxKey = Program.yourBox.FirstOrDefault().Key;
                double oldBoxValue = Program.yourBox.FirstOrDefault().Value;
                Program.yourBox.Add(boxNum, Program.boxes[boxNum]);
                Program.boxes.Remove(boxNum);
                Program.boxes.Add(oldBoxKey, oldBoxValue);

                pickLabel.Visible = false;
                myBoxLabel.Text = $"Вашата кутия е: {boxNum}";
                myBoxLabel.Visible = true;

                int boxToOffer = calculateBoxToOffer();
                gameLabel.Text = $"Кутии до офертата на банката: {boxToOffer}";
                gameLabel.Visible = true;
                bankOfferLabel.Text = "";
            }
            else if (Program.yourBox.Count == 0)
            {
                int boxNum = 0;
                string curr = "";
                if (pictureBox.Name.Length == 11)
                {
                    curr = pictureBox.Name[pictureBox.Name.Length - 1].ToString();
                    boxNum = Convert.ToInt32(curr);
                }
                else
                {
                    curr = pictureBox.Name.Substring(pictureBox.Name.Length - 2);
                    boxNum = Convert.ToInt32(curr);
                }

                Program.yourBox.Add(boxNum, Program.boxes[boxNum]);
                Program.boxes.Remove(boxNum);
                pickLabel.Visible = false;
                myBoxLabel.Text = $"Вашата кутия е: {boxNum}";
                myBoxLabel.Visible = true;

                int boxToOffer = calculateBoxToOffer();
                gameLabel.Text = $"Кутии до офертата на банката: {boxToOffer}";
                gameLabel.Visible = true;
            }
            else
            {
                Program.count++;
                int boxToOffer = calculateBoxToOffer();
                boxOpen(pictureBox, boxToOffer, gameLabel, openBoxLabel, textBoxes, bankOfferLabel, answerYes, answerNo, allBoxes);

            }

        }

        private static void boxOpen(Control pictureBox, int boxToOffer, Control gameLabel,
            Control openBoxLabel, List<Control> textBoxes, Control bankOfferLabel,
            Control answerYes, Control answerNo, List<Control> allBoxes)
        {
            gameLabel.Text = $"Кутии до офертата на банката: {boxToOffer}";
            int boxNum = 0;
            string curr = "";
            if (pictureBox.Name.Length == 11)
            {
                curr = pictureBox.Name[pictureBox.Name.Length - 1].ToString();
                boxNum = Convert.ToInt32(curr);
            }
            else
            {
                curr = pictureBox.Name.Substring(pictureBox.Name.Length - 2);
                boxNum = Convert.ToInt32(curr);
            }

            openBoxLabel.Text = $"В кутия {boxNum} имаше {Program.boxes[boxNum]:f2} лв.";
            openBoxLabel.Visible = true;
            Control textBox = textBoxes.FirstOrDefault(x => Convert.ToDouble(x.Text) == Program.boxes[boxNum]);
            Program.prices.Remove(Convert.ToDouble(textBox.Text));
            textBox.BackColor = Color.Gray;
            Program.boxes.Remove(boxNum);

            if (Program.boxes.Count == 0)
            {
                bankOfferLabel.Text = $"Честито вие спечелихте {Program.yourBox.First().Value:f2} лв.";
                bankOfferLabel.Visible = true;
                openBoxLabel.Visible = false;
            }
            else if (boxToOffer == 0)
            {
                makeControlsEnabledFalse(allBoxes);
                Program.offersCount++;
                bankOffer(bankOfferLabel, answerYes, answerNo, gameLabel, openBoxLabel);
            }
        }

        private static void bankOffer(Control bankOfferLabel, Control answerYes, Control answerNo, Control gameLabel, Control openBoxLabel)
        {
            Random rnd = new Random();
            int num = rnd.Next(1, 3);
            double offer = calculateBankOffer();
            gameLabel.Visible = false;
            openBoxLabel.Visible = false;
            if (num == 1)
            {
                bankOfferLabel.Text = $"Офертата на банката е ${offer:f2} лв.";
            }
            else
            {
                bankOfferLabel.Text = "Смяна на кутиите";
            }

            bankOfferLabel.Visible = true;
            answerYes.Visible = true;
            answerNo.Visible = true;
        }
       
        private static int calculateBoxToOffer()
        {
            int boxToOffer = 0;


            if (Program.count <= 6 && Program.offersCount == 0)
            {
                boxToOffer = 6 - Program.count;
            }
            else if (Program.offersCount == 1 && Program.count >= 6 && Program.count <= 11)
            {
                boxToOffer = 11 - Program.count;
            }
            else if (Program.offersCount == 2 && Program.count >= 11 && Program.count <= 15)
            {
                boxToOffer = 15 - Program.count;
            }
            else if (Program.offersCount == 3 && Program.count >= 15 && Program.count <= 18)
            {
                boxToOffer = 18 - Program.count;
            }
            else if (Program.offersCount == 4 && Program.count >= 18 && Program.count <= 21)
            {
                boxToOffer = 21 - Program.count;
            }
            else if (Program.offersCount == 5 && Program.count >= 21 && Program.count <= 22)
            {
                boxToOffer = 22 - Program.count;
            }

            return boxToOffer;
        }
        
        private static double calculateBankOffer()
        {
            double minPrice = Program.prices.Min();
            double maxPrice = Program.prices.Max();
            double offer = (minPrice + maxPrice) / Program.prices.Count;

            return offer;
        }

    }
}
