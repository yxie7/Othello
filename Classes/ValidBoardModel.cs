using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Othello
{
    // This class object is stores a bool that tells whether or not a coordinate is a valid move for current player
    public class ValidBoardModel
    {
        // attributes
        private bool[,] validMoves;

        // constructor
        public ValidBoardModel()
        {
            validMoves = new bool[8, 8];
        }

        // sets the validity of passed coordinates to either true or false
        public void setValidityOf(int row, int col, bool valid)
        {
            if (valid)
            {
                validMoves[row, col] = true;
            }
            else
            {

                validMoves[row, col] = false;
            }
        }

        // returns validMoves, and outs existsValidMove as true only if there is at least one valid move
        public bool[,] giveValidMoves(out bool existsValidMove)
        {
            existsValidMove = false;
            for (int r = 0; r < 8; r++)
            {
                for (int c = 0; c < 8; c++)
                {
                    if (validMoves[r, c] == true)
                    {
                        existsValidMove = true;
                    }
                }
            }
            return validMoves;
        }
    }
}
