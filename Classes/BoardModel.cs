using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Othello
{
    public class BoardModel
    {
        //attributes
        private int empty = 0;
        private int black = 1;       //player 1
        private int white = 2;      //player 2

        private int[,] board;
        private int numberOfGames = 0;

        private int blackCount = 0;
        private int whiteCount = 0;

        // constructor
        public BoardModel()
        {
            this.board = new int[8, 8];

            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    board[i, j] = empty;
                }
            }
        }

        // sets the internal board to how it should be at the start of the game
        public void startBoard()
        {
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    board[i, j] = empty;
                }
            }
            board[3, 3] = white;
            board[3, 4] = black;
            board[4, 3] = black;
            board[4, 4] = white;
        }
                        
        //places the current turn's player's piece into the passed row,column 
        public void placePiece(bool blackTurn, int row, int column)
        {
            if (blackTurn)
            {
                board[row, column] = this.black;
            }
            else
            {
                board[row, column] = this.white;
            }
        }

        // captures pieces at a single direction based on a coordinate and direction passed
        public void capture(bool blackTurn, int r, int c, int rc, int cc)
        {
            r += rc;
            c += cc;
            if (blackTurn)
            {
                while (board[r, c] == white)
                {
                    placePiece(blackTurn, r, c);
                    r += rc;
                    c += cc;
                }
            }
            else
            {
                while (board[r, c] == black)
                {
                    placePiece(blackTurn, r, c);
                    r += rc;
                    c += cc;
                }
            }
        }

        // captures pieces in all 8 directions from the passed coordinates
        // calls capture() method for each direction there are pieces to capture
        public void capturePieces(bool blackTurn, int r, int c)
        {
            if (aValidMove(blackTurn, r, c, 0, 1))
            {
                capture(blackTurn, r, c, 0, 1);
            }
            if (aValidMove(blackTurn, r, c, 1, 1))
            {
                capture(blackTurn, r, c, 1, 1);
            }
            if (aValidMove(blackTurn, r, c, 1, 0))
            {
                capture(blackTurn, r, c, 1, 0);
            }
            if (aValidMove(blackTurn, r, c, 1, -1))
            {
                capture(blackTurn, r, c, 1, -1);
            }
            if (aValidMove(blackTurn, r, c, 0, -1))
            {
                capture(blackTurn, r, c, 0, -1);
            }
            if (aValidMove(blackTurn, r, c, -1, -1))
            {
                capture(blackTurn, r, c, -1, -1);
            }
            if (aValidMove(blackTurn, r, c, -1, 0))
            {
                capture(blackTurn, r, c, -1, 0);
            }
            if (aValidMove(blackTurn, r, c, -1, 1))
            {
                capture(blackTurn, r, c, -1, 1);
            }
        }
        
        // second part of checking for valid move
        // recursively checks one space at a time in the direction according to the passed rc(rowChange) and cc(colChange) for current turn's player's piece, returns true if found
        // otherwise checks if there is another space in that direction(to check if there if next space in direction would be off the board)
        // returns false if not found, not a valid move
        public bool checkEndsWithOwn(bool blackTurn, int row, int col, int rc, int cc)
        {
            if (blackTurn)
            {
                if (board[row,col] == black)
                {
                    return true;
                }
                if (board[row, col] == empty)
                {
                    return false;
                }
                else if (row + rc < 0 || row + rc >7)
                {
                    return false;
                }
                if (col + cc < 0 || col + cc > 7)
                {
                    return false;
                }
            }
            else //white turn
            {
                if (board[row, col] == white)
                {
                    return true;
                }
                if (board[row, col] == empty)
                {
                    return false;
                }
                else if (row + rc < 0 || row + rc > 7)
                {
                    return false;
                }
                if (col + cc < 0 || col + cc > 7)
                {
                    return false;
                }
            }

            return checkEndsWithOwn(blackTurn, row + rc, col + cc, rc, cc);
        }
        
        // checks if valid move in terms of a single direction as described by rc(rowChange) and cc(colChange)
        // this method goes through a list of things that would make this a non-valid move(in a single direction)
        // non- valid move if :
        // -going in said direction leads off the board
        // -the first space in said direction is this current player's piece
        // -2 spaces in said direction is not on the board
        // if all above does not apply calls checkEndsWithOwn method for the last confirmation to see if valid move in passed space in terms of said direction
        public bool aValidMove(bool blackTurn, int row, int col, int rc, int cc)
        {
            if (blackTurn)
            {
                if (row + rc < 0 || row + rc > 7)
                {
                    return false;
                }
                if (col + cc < 0 || col + cc > 7)
                {
                    return false;
                }
                if (board[row + rc, col + cc] != white)
                {
                    return false;
                }
                if (col + cc + cc > 7 || col + cc + cc < 0)
                {
                    return false;
                }
                if (row + rc + rc < 0 || row + rc + rc > 7)
                {
                    return false;
                }
            }
            else //whiteTurn
            {
                if (row + rc < 0 || row + rc > 7)
                {
                    return false;
                }
                if (col + cc < 0 || col + cc > 7)
                {
                    return false;
                }
                if (board[row + rc, col + cc] != black)
                {
                    return false;
                }
                if (col + cc + cc > 7 || col + cc + cc < 0)
                {
                    return false;
                }
                if (row + rc + rc < 0 || row + rc + rc > 7)
                {
                    return false;
                }
            }
            return checkEndsWithOwn(blackTurn, row + rc + rc, col + cc + cc, rc, cc);
        }

        // looks through entire board to find valid moves for current player
        // checks if placing a piece at each location would capture any opponent pieces in all 8 directions
        // if at least one direction returns true, that would mean that opponent pieces would be captured, valid move
        public void findValidMoves(bool blackTurn)
        {
            for (int r = 0; r < 8; r++)
            {
                for (int c = 0; c < 8; c++)
                {
                    bool valid;

                    bool captureE = aValidMove(blackTurn, r, c, 0, 1);
                    bool captureSE = aValidMove(blackTurn, r, c, 1, 1);
                    bool captureS = aValidMove(blackTurn, r, c, 1, 0);
                    bool captureSW = aValidMove(blackTurn, r, c, 1, -1);
                    bool captureW = aValidMove(blackTurn, r, c, 0, -1);
                    bool captureNW = aValidMove(blackTurn, r, c, -1, -1);
                    bool captureN = aValidMove(blackTurn, r, c, -1, 0);
                    bool captureNE = aValidMove(blackTurn, r, c, -1, 1);
                    if (board[r, c] == empty && (captureE || captureSE || captureS || captureSW || captureW || captureNW || captureN || captureNE))
                    {
                        valid = true;
                    }
                    else
                    {
                        valid = false;
                    }
                    GlobalData.validMove.setValidityOf(r, c, valid);                
                }
            }
        }
             
        // counts the number of pieces on the board for both players
        public void checkPieces()
        {
            int blackPieces = 0;
            int whitePieces = 0;
            foreach (int piece in board)
            {
                if (piece == black)
                {
                    blackPieces++;
                }
                if (piece == white)
                {
                    whitePieces++;
                }
            }
            blackCount = blackPieces;
            whiteCount = whitePieces;
        }

        // looks for a winner
        public int checkWinner()
        {
            if (blackCount == whiteCount)
            {
                return 0;
            }
            if (blackCount > whiteCount)
            {
                return 1;
            }
            else
            {
                return 2;
            }
        }

        // returns the board
        public int[,] returnBoard()
        {
            return board;
        }

        // returns number of black pieces on the board
        public int returnBlackScore()
        {
            return blackCount;
        }

        // returns the number of white pieces on the board
        public int returnWhiteScore()
        {
            return whiteCount;
        }

        // increments the number of games played in this session
        public void addGameCount()
        {
            numberOfGames++;
        }

        // returns the number of games
        public int returnNumberOfGames()
        {
            return numberOfGames;
        }
    }//
}
