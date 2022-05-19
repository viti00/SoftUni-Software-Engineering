using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sudokuSolver
{
    public partial class sudokuForm : Form
    {
        List<TextBox> controls = new List<TextBox>();
        public sudokuForm()
        {
            InitializeComponent();

            controls = this.Controls.OfType<TextBox>().OrderBy(x=> x.Name).ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[,] board = createBoard();
            solveBoard(board);
            showCorrectFilledSudoku(board);
        }

        private int[,] createBoard()
        {
            int[,] board = new int[9, 9];
            int count = 0;

            for (int row = 0; row < 9; row++)
            {
                for (int col = 0; col < 9; col++)
                {

                    if (controls[count].Text == "")
                    {
                        board[row, col] = 0;
                    }
                    else
                    {
                        board[row, col] = Convert.ToInt32(controls[count].Text);
                    }
                    count++;
                }
            }

            return board;
        }

        private bool isNumbersInRow(int[,] board, int number, int row)
        {
            for (int i = 0; i < 9; i++)
            {
                if(board[row,i] == number)
                {
                    return true;
                }
            }
            return false;
        }

        private bool isNumberInColumn(int[,] board, int number, int column)
        {
            for (int i = 0; i < 9; i++)
            {
                if(board[i, column] == number)
                {
                    return true;
                }
            }
            return false;
        }

        private bool isNumberInBox(int[,] board, int number, int row, int column)
        {
            int currRow = row - row % 3;
            int currCol = column - column % 3;
            for (int i = currRow; i < currRow + 3; i++)
            {
                for (int j = currCol; j < currCol + 3; j++)
                {
                    if(board[i,j] == number)
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        private bool isNumberIsValidPlacement(int[,] board, int number, int row, int column)
        {
            return !isNumberInBox(board, number, row, column) &&
                !isNumbersInRow(board, number, row) && !isNumberInColumn(board, number, column);
        }

        private bool solveBoard(int[,] board)
        {
            for (int row = 0; row < 9; row++)
            {
                for (int column = 0; column < 9; column++)
                {
                    if(board[row,column] == 0)
                    {
                        for (int numberToTry = 1; numberToTry <= 9; numberToTry++)
                        {
                            if(isNumberIsValidPlacement(board, numberToTry, row, column))
                            {
                                board[row, column] = numberToTry;

                                if (solveBoard(board))
                                {
                                    return true;
                                }
                                else
                                {
                                    board[row, column] = 0;
                                }
                            }
                        }
                        return false;
                    }
                }
            }
            return true;
        }

        private void showCorrectFilledSudoku(int[,] board)
        {
            int count = 0;

            for (int row = 0; row < 9; row++)
            {
                for (int col = 0; col < 9; col++)
                {
                    controls[count].Text = board[row, col].ToString();
                    count++;
                }
            }
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < controls.Count; i++)
            {
                controls[i].Text = "";
            }
        }
    }
}
