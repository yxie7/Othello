using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Ying Xie
//tug69722@temple.edu
//Component Based Software Design
//Game Project Othello
//Last Revised : 10/7/18
namespace Othello
{
    public partial class frmStart : Form
    {
        //constructor for form
        public frmStart()
        {
            InitializeComponent();
        }

        private void frmOthello_Load(object sender, EventArgs e)
        {
            pnlSecondPlayer.Visible = false;
            pnlPlay.Visible = false;
        }

        // makes a player into playerList with the name entered into the txtFirstPlayerName,
        // then reveals the panel containing the label, textbox, and button for second player name input and disables this ok button
        // prompted to reenter a name if left blank
        private void btnOK1_Click(object sender, EventArgs e)
        {
            if (txtFirstPlayerName.Text != "")
            {
                //playerList.Add(new PlayerModel(txtFirstPlayerName.Text));
                GlobalData.playerList.Add(new PlayerModel(txtFirstPlayerName.Text));
                pnlSecondPlayer.Visible = true;
                txtFirstPlayerName.Enabled = false;
                btnOK1.Enabled = false;
                txtSecondPlayerName.Focus();
            }
            else
            {
                MessageBox.Show("You must enter a name. . .");
            }
        }

        // makes a player into playerList with the name entered into the txtSecondPlayerName, disables this ok button,
        // then makes the panel containing the turn indicator, row buttons and marbles visible
        // prompted to reenter a name if left blank or same name as player 1
        private void btnOK2_Click(object sender, EventArgs e)
        {
            if (txtSecondPlayerName.Text != "")
            {
                if (txtSecondPlayerName.Text == txtFirstPlayerName.Text)
                {
                    MessageBox.Show("Names cannot be the same, enter a different name!");
                    txtSecondPlayerName.Text = "";
                }
                else
                {
                    //playerList.Add(new PlayerModel(txtSecondPlayerName.Text));
                    GlobalData.playerList.Add(new PlayerModel(txtSecondPlayerName.Text));
                    btnOK2.Enabled = false;
                    txtSecondPlayerName.Enabled = false;
                    pnlPlay.Visible = true;
                }
            }
            else
            {
                MessageBox.Show("You must enter a name. . .");
            }
        }

        // shows the next form
        private void btnPlay_Click(object sender, EventArgs e)
        {
            Form game = new frmOthello();
            game.Show();
            this.Hide();
        }                
    }
}
