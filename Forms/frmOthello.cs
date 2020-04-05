using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Othello
{
    public partial class frmOthello : Form
    {
        //attributes

        public BoardModel internalBoardRep = new BoardModel();
        private Button[,] button = new Button[8, 8];
        
        private bool blackTurn = true;
        private int numberOfPasses = 0;
        private int numberOfMoves = 0;

        //constructor for form
        public frmOthello()
        {
            InitializeComponent();
        }

        //upon form load, board is automatically created
        private void frmOthello_Load(object sender, EventArgs e)
        {
            createBoard();
        }

        //exits the entire program
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            MessageBox.Show($"{GlobalData.playerList[0].getPlayerName()} won {GlobalData.playerList[0].getCountOfWins()} times... \n" +
                $"{GlobalData.playerList[1].getPlayerName()} won {GlobalData.playerList[1].getCountOfWins()} times... \n" +
                $"A total number of {internalBoardRep.returnNumberOfGames()} games were played in this session.");
            Environment.Exit(0);
        }

        //method that creates the initial state of the board and starts the game with 
        public void createBoard()
        {
            Size size = new Size(50, 50);
            Point loc = new Point(0, 0);
            int padding = 5;
            int topMargin = 5;
            int extraLeftPadding = 5;

            // The board is treated like a maxRows x MaxCols array
            for (int row = 0; row < 8; row++)
            {
                loc.Y = topMargin + row * (size.Height + padding);
                for (int col = 0; col < 8; col++)
                {
                    button[row, col] = new System.Windows.Forms.Button();
                    button[row, col].Location = new Point(extraLeftPadding + col *
                                                    (size.Width + padding), loc.Y);
                    button[row, col].Size = size;
                    button[row, col].Text = "";
                    button[row, col].Enabled = true;
                    button[row, col].Visible = true;
                    button[row, col].BackColor = Color.ForestGreen;
                    button[row, col].ForeColor = Color.Red;
                    button[row, col].Name = "btn" + row + col;

                    // Associates the same event handler with each of the buttons generated
                    button[row, col].Click += new EventHandler(Button_Click);

                    // Add button to the form
                    pnlBoard.Controls.Add(button[row, col]);
                }
            }
            pnlBoard.Visible = true;

            reloadGame();

            MessageBox.Show("Each player takes turns to place a piece on the board to capture opponent pieces that are inbetween their own in a straight line.\n\n" +
                "Players can only place a piece at a spot that would capture opponent pieces(They will be marked with red 'x').\n\n" +
                "The winner is the one with the most pieces at the end of the game.",
                "Instructions");

        }

        // event handler for button click, places piece at coordinate of button and captures pieces
        private void Button_Click(object sender, EventArgs e)
        {
            numberOfMoves++;
            int row;
            int col;
            boardCoordinatesOfButton(sender, out row, out col);
            internalBoardRep.placePiece(blackTurn, row, col);
            internalBoardRep.capturePieces(blackTurn, row, col);
            updateScore();
            nextTurn(row, col);
        } // end button clickhandler

        // method called when button clicked, returns the coordinates of the passed button
        public void boardCoordinatesOfButton(object sender, out int row, out int col)
        {
            row = -1;
            col = -1;
            for (int r = 0; r < 8; r++)
            {
                for (int c = 0; c < 8; c++)
                {
                    if (button[r, c] == sender)
                    {
                        row = r;
                        col = c;
                    }
                }
            }
        }

        //disables buttons that would be a non valid move and enable those that are valid
        public void setButtons(bool[,] validMoves)
        {
            for (int r = 0; r < 8; r++)
            {
                for (int c = 0; c < 8; c++)
                {
                    if (validMoves[r, c])
                    {
                        button[r, c].Enabled = true;
                        button[r, c].Text = "X";
                    }
                    else
                    {
                        button[r, c].Enabled = false;
                        button[r, c].Text = "";
                    }
                }
            }
        }

        // current player indicator changed
        // look for valid moves for current player
        // if there is valid move, enables buttons for spaces that would be a valid move
        // if there is no valid move, current player's turn is passed and message to user saying so
        // if both players turn are passed back to back, the game is over and checks for winner
        // puts a number(indicates the number of moves made in this game) where the last move was made
        public void nextTurn(int row, int col)
        {
            if (blackTurn)
            {
                blackTurn = false;
                txtCurrentPlayer.Text = GlobalData.playerList[1].getPlayerName();
            }
            else
            {
                blackTurn = true;
                txtCurrentPlayer.Text = GlobalData.playerList[0].getPlayerName();
            }
            internalBoardRep.findValidMoves(blackTurn);
            bool existsValidMove;
            bool[,] validMoves = GlobalData.validMove.giveValidMoves(out existsValidMove);
            translateBoardToForm(internalBoardRep.returnBoard());
            if (existsValidMove)
            {
                numberOfPasses = 0;
                setButtons(validMoves);
            }
            if (numberOfPasses == 2)
            {
                switch (internalBoardRep.checkWinner())
                {
                    case 0:
                        MessageBox.Show("The game ended in a draw!");
                        break;
                    case 1:
                        GlobalData.playerList[0].addWins();
                        MessageBox.Show($"The game is over!\nThe Winner is {GlobalData.playerList[0].getPlayerName()}");
                        endOfGame();
                        break;
                    case 2:
                        GlobalData.playerList[1].addWins();
                        MessageBox.Show($"The game is over!\nThe Winner is {GlobalData.playerList[1].getPlayerName()}");
                        endOfGame();
                        break;
                }
            }
            else if (!existsValidMove)
            {
                int x;
                if (blackTurn)
                {
                    x = 0;
                }
                else
                {
                    x = 1;
                }
                MessageBox.Show($"{GlobalData.playerList[x].getPlayerName()} does not have a valid move, your turn was passed.");
                numberOfPasses++;
                nextTurn(row,col);
            }
            button[row, col].Text = numberOfMoves.ToString();
        }
        
        //looks at the internal state of the board and changes the colors of the buttons so they match accordingly
        public void translateBoardToForm(int[,] board)
        {
            for (int r = 0; r < 8; r++)
            {
                for (int c = 0; c < 8; c++)
                {
                    if (board[r, c] == 2)
                    {
                        //button[r, c].BackColor = System.Drawing.Color.GhostWhite;
                        button[r, c].Image = PieceImages.Images[1];
                    }
                    if (board[r, c] == 1)
                    {
                        //button[r, c].BackColor = System.Drawing.Color.DarkGray;
                        button[r, c].Image = PieceImages.Images[0];
                    }
                    if (board[r, c] == 0)
                    {
                        //button[r, c].BackColor = System.Drawing.Color.ForestGreen;
                        button[r, c].Image = PieceImages.Images[2];
                    }

                }
            }
        }
         
        // reloads the initial state of the game,
        public void reloadGame()
        {
            numberOfMoves = 0;
            blackTurn = true;
            txtCurrentPlayer.Text = GlobalData.playerList[0].getPlayerName();
            internalBoardRep.startBoard();
            translateBoardToForm(internalBoardRep.returnBoard());

            internalBoardRep.findValidMoves(blackTurn);
            bool existsValidMove;
            bool[,] validMoves = GlobalData.validMove.giveValidMoves(out existsValidMove);
            if (existsValidMove)
            {
                setButtons(validMoves);
            }
            updateScore();
            updateWins();
            btnForfeit.Enabled = true;
            btnReplay.Enabled = false;
        }

        // reloads the game to replay
        private void btnReplay_Click(object sender, EventArgs e)
        {
            reloadGame();
        }

        // updates the text in the textboxes showing the number of pieces each player has
        public void updateScore()
        {
            internalBoardRep.checkPieces();
            txtBlackScore.Text = internalBoardRep.returnBlackScore().ToString();
            txtWhiteScore.Text = internalBoardRep.returnWhiteScore().ToString();
        }

        // returns the number of win of a certain player
        public int getPlayerWinCount(int player)
        {
            return GlobalData.playerList[player].getCountOfWins();
        }

        // updates the number of wins shown in the textbox for both players and the number of games
        public void updateWins()
        {
            txtGameCount.Text = internalBoardRep.returnNumberOfGames().ToString();
            txtPlayer1Wins.Text = getPlayerWinCount(0).ToString();
            txtPlayer2Wins.Text = getPlayerWinCount(1).ToString();
        }

        // event handler for the forfeit button
        // current player loses and the next player gets a win, message box telling who won and who lost is shown
        // 
        private void btnForfeit_Click(object sender, EventArgs e)
        {
            if (blackTurn)
            {
                GlobalData.playerList[1].addWins();
                MessageBox.Show($"{GlobalData.playerList[0].getPlayerName()} forfeited the game!\n" +
                    $"{GlobalData.playerList[1].getPlayerName()} wins!");
            }
            else
            {
                GlobalData.playerList[0].addWins(); MessageBox.Show($"{GlobalData.playerList[1].getPlayerName()} forfeited the game!\n" +
                     $"{GlobalData.playerList[0].getPlayerName()} wins!");
            }
            endOfGame();
            btnReplay.Enabled = true;
        }

        // called when the game is over, disables all buttons
        // updates the win counts and number of games
        // disables forfeit button and enables replay button
        public void endOfGame()
        {
            internalBoardRep.addGameCount();
            foreach (Button btn in pnlBoard.Controls)
            {
                btn.Enabled = false;
            }
            updateWins();
            btnForfeit.Enabled = false;
            btnReplay.Enabled = true;
        }
    }//end of class
}