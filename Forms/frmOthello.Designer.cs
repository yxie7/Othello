namespace Othello
{
    partial class frmOthello
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOthello));
            this.pnlBoard = new System.Windows.Forms.Panel();
            this.lblBlack = new System.Windows.Forms.Label();
            this.lblWhite = new System.Windows.Forms.Label();
            this.txtBlackScore = new System.Windows.Forms.TextBox();
            this.txtWhiteScore = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtPlayer1Wins = new System.Windows.Forms.TextBox();
            this.txtGameCount = new System.Windows.Forms.TextBox();
            this.txtPlayer2Wins = new System.Windows.Forms.TextBox();
            this.lblPlayer1Wins = new System.Windows.Forms.Label();
            this.lblPlayer2Wins = new System.Windows.Forms.Label();
            this.lblGameCount = new System.Windows.Forms.Label();
            this.btnReplay = new System.Windows.Forms.Button();
            this.PieceImages = new System.Windows.Forms.ImageList(this.components);
            this.btnForfeit = new System.Windows.Forms.Button();
            this.lblCurrentPlayer = new System.Windows.Forms.Label();
            this.txtCurrentPlayer = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // pnlBoard
            // 
            this.pnlBoard.BackColor = System.Drawing.Color.SaddleBrown;
            this.pnlBoard.Location = new System.Drawing.Point(13, 61);
            this.pnlBoard.Name = "pnlBoard";
            this.pnlBoard.Size = new System.Drawing.Size(445, 445);
            this.pnlBoard.TabIndex = 16;
            // 
            // lblBlack
            // 
            this.lblBlack.AutoSize = true;
            this.lblBlack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBlack.Location = new System.Drawing.Point(8, 512);
            this.lblBlack.Name = "lblBlack";
            this.lblBlack.Size = new System.Drawing.Size(53, 20);
            this.lblBlack.TabIndex = 17;
            this.lblBlack.Text = "Black";
            // 
            // lblWhite
            // 
            this.lblWhite.AutoSize = true;
            this.lblWhite.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWhite.Location = new System.Drawing.Point(402, 512);
            this.lblWhite.Name = "lblWhite";
            this.lblWhite.Size = new System.Drawing.Size(55, 20);
            this.lblWhite.TabIndex = 18;
            this.lblWhite.Text = "White";
            // 
            // txtBlackScore
            // 
            this.txtBlackScore.Location = new System.Drawing.Point(67, 512);
            this.txtBlackScore.Name = "txtBlackScore";
            this.txtBlackScore.ReadOnly = true;
            this.txtBlackScore.Size = new System.Drawing.Size(100, 20);
            this.txtBlackScore.TabIndex = 19;
            // 
            // txtWhiteScore
            // 
            this.txtWhiteScore.Location = new System.Drawing.Point(296, 512);
            this.txtWhiteScore.Name = "txtWhiteScore";
            this.txtWhiteScore.ReadOnly = true;
            this.txtWhiteScore.Size = new System.Drawing.Size(100, 20);
            this.txtWhiteScore.TabIndex = 20;
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(383, 573);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 21;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtPlayer1Wins
            // 
            this.txtPlayer1Wins.Location = new System.Drawing.Point(13, 29);
            this.txtPlayer1Wins.Name = "txtPlayer1Wins";
            this.txtPlayer1Wins.ReadOnly = true;
            this.txtPlayer1Wins.Size = new System.Drawing.Size(100, 20);
            this.txtPlayer1Wins.TabIndex = 22;
            // 
            // txtGameCount
            // 
            this.txtGameCount.Location = new System.Drawing.Point(357, 29);
            this.txtGameCount.Name = "txtGameCount";
            this.txtGameCount.ReadOnly = true;
            this.txtGameCount.Size = new System.Drawing.Size(100, 20);
            this.txtGameCount.TabIndex = 23;
            // 
            // txtPlayer2Wins
            // 
            this.txtPlayer2Wins.Location = new System.Drawing.Point(185, 28);
            this.txtPlayer2Wins.Name = "txtPlayer2Wins";
            this.txtPlayer2Wins.ReadOnly = true;
            this.txtPlayer2Wins.Size = new System.Drawing.Size(100, 20);
            this.txtPlayer2Wins.TabIndex = 24;
            // 
            // lblPlayer1Wins
            // 
            this.lblPlayer1Wins.AutoSize = true;
            this.lblPlayer1Wins.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer1Wins.Location = new System.Drawing.Point(10, 9);
            this.lblPlayer1Wins.Name = "lblPlayer1Wins";
            this.lblPlayer1Wins.Size = new System.Drawing.Size(146, 16);
            this.lblPlayer1Wins.TabIndex = 25;
            this.lblPlayer1Wins.Text = "Player 1 Win Counts";
            // 
            // lblPlayer2Wins
            // 
            this.lblPlayer2Wins.AutoSize = true;
            this.lblPlayer2Wins.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer2Wins.Location = new System.Drawing.Point(182, 9);
            this.lblPlayer2Wins.Name = "lblPlayer2Wins";
            this.lblPlayer2Wins.Size = new System.Drawing.Size(146, 16);
            this.lblPlayer2Wins.TabIndex = 26;
            this.lblPlayer2Wins.Text = "Player 2 Win Counts";
            // 
            // lblGameCount
            // 
            this.lblGameCount.AutoSize = true;
            this.lblGameCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGameCount.Location = new System.Drawing.Point(354, 9);
            this.lblGameCount.Name = "lblGameCount";
            this.lblGameCount.Size = new System.Drawing.Size(92, 16);
            this.lblGameCount.TabIndex = 27;
            this.lblGameCount.Text = "Game Count";
            // 
            // btnReplay
            // 
            this.btnReplay.Location = new System.Drawing.Point(13, 573);
            this.btnReplay.Name = "btnReplay";
            this.btnReplay.Size = new System.Drawing.Size(75, 23);
            this.btnReplay.TabIndex = 28;
            this.btnReplay.Text = "Replay";
            this.btnReplay.UseVisualStyleBackColor = true;
            this.btnReplay.Click += new System.EventHandler(this.btnReplay_Click);
            // 
            // PieceImages
            // 
            this.PieceImages.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("PieceImages.ImageStream")));
            this.PieceImages.TransparentColor = System.Drawing.Color.Transparent;
            this.PieceImages.Images.SetKeyName(0, "black.png");
            this.PieceImages.Images.SetKeyName(1, "white.png");
            this.PieceImages.Images.SetKeyName(2, "empty.png");
            // 
            // btnForfeit
            // 
            this.btnForfeit.Location = new System.Drawing.Point(228, 544);
            this.btnForfeit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnForfeit.Name = "btnForfeit";
            this.btnForfeit.Size = new System.Drawing.Size(56, 19);
            this.btnForfeit.TabIndex = 29;
            this.btnForfeit.Text = "Forfeit";
            this.btnForfeit.UseVisualStyleBackColor = true;
            this.btnForfeit.Click += new System.EventHandler(this.btnForfeit_Click);
            // 
            // lblCurrentPlayer
            // 
            this.lblCurrentPlayer.AutoSize = true;
            this.lblCurrentPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentPlayer.Location = new System.Drawing.Point(10, 544);
            this.lblCurrentPlayer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCurrentPlayer.Name = "lblCurrentPlayer";
            this.lblCurrentPlayer.Size = new System.Drawing.Size(103, 17);
            this.lblCurrentPlayer.TabIndex = 30;
            this.lblCurrentPlayer.Text = "Current Player:";
            // 
            // txtCurrentPlayer
            // 
            this.txtCurrentPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCurrentPlayer.Location = new System.Drawing.Point(114, 539);
            this.txtCurrentPlayer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCurrentPlayer.Name = "txtCurrentPlayer";
            this.txtCurrentPlayer.ReadOnly = true;
            this.txtCurrentPlayer.Size = new System.Drawing.Size(83, 26);
            this.txtCurrentPlayer.TabIndex = 31;
            // 
            // frmOthello
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(470, 605);
            this.Controls.Add(this.txtCurrentPlayer);
            this.Controls.Add(this.lblCurrentPlayer);
            this.Controls.Add(this.btnForfeit);
            this.Controls.Add(this.btnReplay);
            this.Controls.Add(this.lblGameCount);
            this.Controls.Add(this.lblPlayer2Wins);
            this.Controls.Add(this.lblPlayer1Wins);
            this.Controls.Add(this.txtGameCount);
            this.Controls.Add(this.txtPlayer2Wins);
            this.Controls.Add(this.txtPlayer1Wins);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.txtWhiteScore);
            this.Controls.Add(this.lblWhite);
            this.Controls.Add(this.txtBlackScore);
            this.Controls.Add(this.lblBlack);
            this.Controls.Add(this.pnlBoard);
            this.Name = "frmOthello";
            this.Text = "Othello - The Game Nobody Seems to Know Of";
            this.Load += new System.EventHandler(this.frmOthello_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlBoard;
        private System.Windows.Forms.Label lblBlack;
        private System.Windows.Forms.Label lblWhite;
        private System.Windows.Forms.TextBox txtBlackScore;
        private System.Windows.Forms.TextBox txtWhiteScore;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtPlayer1Wins;
        private System.Windows.Forms.TextBox txtGameCount;
        private System.Windows.Forms.TextBox txtPlayer2Wins;
        private System.Windows.Forms.Label lblPlayer1Wins;
        private System.Windows.Forms.Label lblPlayer2Wins;
        private System.Windows.Forms.Label lblGameCount;
        private System.Windows.Forms.Button btnReplay;
        private System.Windows.Forms.ImageList PieceImages;
        private System.Windows.Forms.Button btnForfeit;
        private System.Windows.Forms.Label lblCurrentPlayer;
        private System.Windows.Forms.TextBox txtCurrentPlayer;
    }
}