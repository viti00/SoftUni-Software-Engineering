using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MessageUncryptor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Uncrypt_Click(object sender, EventArgs e)
        {
            string uncryptedMessage = "";
            for (int i = 0; i < cryptedMessageTextbox.Text.Length; i++)
            {
                int charToInt = (int)cryptedMessageTextbox.Text[i];

                if (charToInt >= 35 && charToInt <= 37)
                {
                    charToInt -= 3;
                }

                else
                {
                    if (i == 0)
                    {
                        charToInt -= 4;
                    }
                    else if (i % 2 == 0)
                    {
                        charToInt += 2;
                    }
                    else
                    {
                        charToInt -= 5;
                    }
                }

                

                uncryptedMessage += (char)charToInt;
            }

            UncryptedMessageTextBox.Text = uncryptedMessage;
        }

        private void Copy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(UncryptedMessageTextBox.Text);
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            cryptedMessageTextbox.Text = "";
            UncryptedMessageTextBox.Text = "";
        }
    }
}
