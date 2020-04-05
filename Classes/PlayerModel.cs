using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Othello
{
    public class PlayerModel
    {
        // attributes
        private string playerName;
        private int countOfWins;

        // constructor for PlayerModel
        // playerName is set to whatever string is passed and wins to default of 0
        public PlayerModel(string playerName)
        {
            this.playerName = playerName;
            countOfWins = 0;
        }

        // returns the player's name
        public string getPlayerName()
        {
            return playerName;
        }

        // returns the player's win count
        public int getCountOfWins()
        {
            return countOfWins;
        }

        // adds a win to the player
        public void addWins()
        {
            countOfWins++;
        }
    }
}
