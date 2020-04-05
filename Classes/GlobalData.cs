using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Othello
{
    public class GlobalData
    {
        // Application classes
        public static ValidBoardModel validMove = new ValidBoardModel();
        public static List<PlayerModel> playerList = new List<PlayerModel>(2);
                
    } // end Global Data Class

} // end namespace
