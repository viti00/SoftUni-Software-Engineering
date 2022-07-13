using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace DealOrNotDeal
{
    public partial class Form1 : Form
    {
        List<Control> allControlls;
        List<Control> allPictureBoxes;
        List<Control> allTextBoxes;
        int count = 0;
        Dictionary<int, double> boxesData = new Dictionary<int, double>();
        List<double> prices = new List<double>();
        Dictionary<int, double> boxes = new Dictionary<int, double>();
        int boxNumeric = 1;
        Dictionary<int, double> yourBox = new Dictionary<int, double>();
        int offersCount = 0;
        string message = "";
        string caption = "Оферта на банката";

        public Form1()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture("en-GB");
            InitializeComponent();

        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            allControlls = this.Controls.OfType<Control>().ToList();
            allPictureBoxes = allControlls.Where(x => x is PictureBox).ToList();
            allTextBoxes = this.Controls.OfType<Control>().Where(x => x is TextBox).ToList();

            AddClickEvent(allPictureBoxes);

            ShowOrHideElements(allControlls);

            MakeBoxesData(boxesData);
            MakeBoxes(boxes, boxNumeric, boxesData);
            MakePrices(prices);
        }

        private void AnswerYes()
        {
            if (message == "Смяна на кутиите")
            {
                pickLabel.Visible = true;
            }
            else
            {
                double offer = CalculateBankOffer();
                var finalMessage = $"Вие си тръгвате с {offer:f0} лв. Във вашата кутия има {yourBox.FirstOrDefault().Value:f2} лв.";
                MessageBox.Show(finalMessage);

                MakeControlsEnabledFalse(allControlls);

                newGame.Enabled = true;
            }

        }

        private void AnswerNo()
        {
            int boxToOffer = CalculateBoxToOffer();

            gameLabel.Text = $"Кутии до офертата на банката: {boxToOffer}";
            gameLabel.Visible = true;

            openBoxLabel.Visible = true;

            message = "";
        }

        private void newGame_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void MakeControlsEnabledFalse(List<Control> controls)
        {
            foreach (var item in controls)
            {
                item.Enabled = false;
            }
        }

        private void AddClickEvent(List<Control> allBoxes)
        {
            foreach (var item in allBoxes)
            {
                item.Click += OnClick;
            }
        }

        private void OnClick(object sender, EventArgs e)
        {
            PictureBox box = sender as PictureBox;

            int yourBoxKey = yourBox.FirstOrDefault().Key;

            Control pictureBox = allControlls.Where(x => x is PictureBox).FirstOrDefault(x => x.Name == $"pictureBox{yourBoxKey}");

            PlayGame(box, pictureBox);
        }

        private void MakePrices(List<double> prices)
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

        private void MakeBoxesData(Dictionary<int, double> boxesData)
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

        private void MakeBoxes(Dictionary<int, double> boxes, int boxNumeric, Dictionary<int, double> boxesData)
        {
            while (boxesData.Count != 0)
            {
                int num = Randomizer(1, 25);
                if (boxesData.ContainsKey(num))
                {
                    boxes.Add(boxNumeric, boxesData[num]);
                    boxNumeric++;
                    boxesData.Remove(num);
                }
            }
        }

        private void ShowOrHideElements(List<Control> all)
        {
            foreach (var item in all)
            {
                if (CheckControlls(item))
                {
                    item.Visible = true;
                }
                else
                {
                    item.Visible = false;
                }
            }
        }

        private void PlayGame(Control clickedBox, Control myOldBox)
        {
            clickedBox.Visible = false;

            if (message == "Смяна на кутиите")
            {
                myOldBox.Visible = true;

                int boxNum = GetBoxNum(clickedBox.Name);

                int oldBoxKey = yourBox.FirstOrDefault().Key;
                double oldBoxValue = yourBox.FirstOrDefault().Value;
                yourBox.Remove(oldBoxKey);
                yourBox.Add(boxNum, boxes[boxNum]);
                boxes.Remove(boxNum);
                boxes.Add(oldBoxKey, oldBoxValue);

                pickLabel.Visible = false;
                myBoxLabel.Text = $"Вашата кутия е: {boxNum}";
                myBoxLabel.Visible = true;

                int boxToOffer = CalculateBoxToOffer();
                gameLabel.Text = $"Кутии до офертата на банката: {boxToOffer}";
                gameLabel.Visible = true;
                message = "";
            }
            else if (yourBox.Count == 0)
            {
                int boxNum = GetBoxNum(clickedBox.Name);

                yourBox.Add(boxNum, boxes[boxNum]);
                boxes.Remove(boxNum);
                pickLabel.Visible = false;
                myBoxLabel.Text = $"Вашата кутия е: {boxNum}";
                myBoxLabel.Visible = true;

                int boxToOffer = CalculateBoxToOffer();
                gameLabel.Text = $"Кутии до офертата на банката: {boxToOffer}";
                gameLabel.Visible = true;
            }
            else
            {
                count++;
                int boxToOffer = CalculateBoxToOffer();
                BoxOpen(clickedBox, boxToOffer);

            }

        }

        private void BoxOpen(Control clickedBox, int boxToOffer)
        {
            gameLabel.Text = $"Кутии до офертата на банката: {boxToOffer}";
            int boxNum = GetBoxNum(clickedBox.Name);

            openBoxLabel.Text = $"В кутия {boxNum} имаше {boxes[boxNum]:f2} лв.";
            openBoxLabel.Visible = true;
            Control textBox = allTextBoxes.FirstOrDefault(x => Convert.ToDouble(x.Text) == boxes[boxNum]);

            prices.Remove(Convert.ToDouble(textBox.Text));

            textBox.BackColor = Color.Gray;

            boxes.Remove(boxNum);

            if (boxes.Count == 0)
            {
                MessageBox.Show($"Честито вие спечелихте {yourBox.First().Value:f2} лв.");
                openBoxLabel.Visible = false;
            }
            else if (boxToOffer == 0)
            {
                offersCount++;
                BankOffer();
            }
        }

        private void BankOffer()
        {
            int num = Randomizer(1, 3);
            double offer = CalculateBankOffer();

            gameLabel.Visible = false;


            if (num == 1)
            {
                message = $"Офертата на банката е ${offer:f0} лв.";
            }
            else
            {
                message = "Смяна на кутиите";
            }

            var result = MessageBox.Show(message, caption,
                                 MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                AnswerYes();
            }
            else
            {
                AnswerNo();
            }
        }

        private int Randomizer(int startNum, int endNum)
        {
            Random rnd = new Random();
            int num = rnd.Next(startNum, endNum);

            return num;
        }

        private int CalculateBoxToOffer()
        {
            int boxToOffer = 0;


            if (count <= 6 && offersCount == 0)
            {
                boxToOffer = 6 - count;
            }
            else if (offersCount == 1 && count >= 6 && count <= 11)
            {
                boxToOffer = 11 - count;
            }
            else if (offersCount == 2 && count >= 11 && count <= 15)
            {
                boxToOffer = 15 - count;
            }
            else if (offersCount == 3 && count >= 15 && count <= 18)
            {
                boxToOffer = 18 - count;
            }
            else if (offersCount == 4 && count >= 18 && count <= 21)
            {
                boxToOffer = 21 - count;
            }
            else if (offersCount == 5 && count >= 21 && count <= 22)
            {
                boxToOffer = 22 - count;
            }

            return boxToOffer;
        }

        private double CalculateBankOffer()
        {
            double minPrice = prices.Min();
            double maxPrice = prices.Max();
            double offer = (minPrice + maxPrice) / prices.Count;

            return offer;
        }

        private bool CheckControlls(Control controll)
        {
            if (controll.Name == "startBtn" || controll.Name == "myBoxLabel"
                || controll.Name == "gameLabel" || controll.Name == "openBoxLabel")
            {
                return false;
            }

            return true;
        }

        private int GetBoxNum(string boxName)
        {
            return Convert.ToInt32(boxName.Substring(10));
        }
    }
}
