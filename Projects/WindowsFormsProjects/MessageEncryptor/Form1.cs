using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MessageEncryptor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Encrypt_Click(object sender, EventArgs e)
        {
            string encryptedMessage = "";
            for (int i = 0; i < messageTextBox.Text.Length; i++)
            {
                int charToInt = (int)messageTextBox.Text[i];

                if(charToInt >= 32 && charToInt <= 34)
                {
                    charToInt += 3;
                }
                else
                {
                    if(i == 0)
                    {
                        charToInt += 4;
                    }
                    else if(i % 2 == 0)
                    {
                        charToInt -= 2;
                    }
                    else
                    {
                        charToInt += 5;
                    }
                }
                

                encryptedMessage += (char)charToInt;
            }

            EncryptedMessageTextBox.Text = encryptedMessage;
        }

        private void Copy_Click(object sender, EventArgs e)
        {
            if(EncryptedMessageTextBox.Text.Length > 0)
            {
                Clipboard.SetText(EncryptedMessageTextBox.Text);
            }
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            messageTextBox.Text = "";
            EncryptedMessageTextBox.Text = "";
        }
    }
}
