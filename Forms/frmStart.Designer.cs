namespace Othello
{
    partial class frmStart
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
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblEnterNames = new System.Windows.Forms.Label();
            this.pnlPlay = new System.Windows.Forms.Panel();
            this.lblReady = new System.Windows.Forms.Label();
            this.btnPlay = new System.Windows.Forms.Button();
            this.pnlSecondPlayer = new System.Windows.Forms.Panel();
            this.lblSecondPlayerName = new System.Windows.Forms.Label();
            this.txtSecondPlayerName = new System.Windows.Forms.TextBox();
            this.btnOK2 = new System.Windows.Forms.Button();
            this.pnlFirstPlayer = new System.Windows.Forms.Panel();
            this.lblFirstPlayerName = new System.Windows.Forms.Label();
            this.txtFirstPlayerName = new System.Windows.Forms.TextBox();
            this.btnOK1 = new System.Windows.Forms.Button();
            this.pnlPlay.SuspendLayout();
            this.pnlSecondPlayer.SuspendLayout();
            this.pnlFirstPlayer.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Location = new System.Drawing.Point(16, 11);
            this.lblWelcome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(131, 17);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Welcome to Othello";
            // 
            // lblEnterNames
            // 
            this.lblEnterNames.AutoSize = true;
            this.lblEnterNames.Location = new System.Drawing.Point(16, 43);
            this.lblEnterNames.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEnterNames.Name = "lblEnterNames";
            this.lblEnterNames.Size = new System.Drawing.Size(186, 17);
            this.lblEnterNames.TabIndex = 1;
            this.lblEnterNames.Text = "Players, enter your names...";
            // 
            // pnlPlay
            // 
            this.pnlPlay.Controls.Add(this.lblReady);
            this.pnlPlay.Controls.Add(this.btnPlay);
            this.pnlPlay.Location = new System.Drawing.Point(16, 162);
            this.pnlPlay.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlPlay.Name = "pnlPlay";
            this.pnlPlay.Size = new System.Drawing.Size(497, 37);
            this.pnlPlay.TabIndex = 14;
            // 
            // lblReady
            // 
            this.lblReady.AutoSize = true;
            this.lblReady.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReady.Location = new System.Drawing.Point(4, 10);
            this.lblReady.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblReady.Name = "lblReady";
            this.lblReady.Size = new System.Drawing.Size(314, 18);
            this.lblReady.TabIndex = 8;
            this.lblReady.Text = "When ready to play, click this button --->";
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.Color.Lime;
            this.btnPlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlay.Location = new System.Drawing.Point(361, 4);
            this.btnPlay.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(124, 28);
            this.btnPlay.TabIndex = 9;
            this.btnPlay.Text = "Let\'s Play!";
            this.btnPlay.UseVisualStyleBackColor = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // pnlSecondPlayer
            // 
            this.pnlSecondPlayer.Controls.Add(this.lblSecondPlayerName);
            this.pnlSecondPlayer.Controls.Add(this.txtSecondPlayerName);
            this.pnlSecondPlayer.Controls.Add(this.btnOK2);
            this.pnlSecondPlayer.Location = new System.Drawing.Point(20, 112);
            this.pnlSecondPlayer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlSecondPlayer.Name = "pnlSecondPlayer";
            this.pnlSecondPlayer.Size = new System.Drawing.Size(427, 37);
            this.pnlSecondPlayer.TabIndex = 14;
            // 
            // lblSecondPlayerName
            // 
            this.lblSecondPlayerName.AutoSize = true;
            this.lblSecondPlayerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSecondPlayerName.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblSecondPlayerName.Location = new System.Drawing.Point(3, 9);
            this.lblSecondPlayerName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSecondPlayerName.Name = "lblSecondPlayerName";
            this.lblSecondPlayerName.Size = new System.Drawing.Size(152, 18);
            this.lblSecondPlayerName.TabIndex = 4;
            this.lblSecondPlayerName.Text = "Second Player Name:";
            // 
            // txtSecondPlayerName
            // 
            this.txtSecondPlayerName.Location = new System.Drawing.Point(184, 5);
            this.txtSecondPlayerName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSecondPlayerName.Name = "txtSecondPlayerName";
            this.txtSecondPlayerName.Size = new System.Drawing.Size(132, 22);
            this.txtSecondPlayerName.TabIndex = 5;
            // 
            // btnOK2
            // 
            this.btnOK2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnOK2.Location = new System.Drawing.Point(352, 5);
            this.btnOK2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnOK2.Name = "btnOK2";
            this.btnOK2.Size = new System.Drawing.Size(68, 28);
            this.btnOK2.TabIndex = 7;
            this.btnOK2.Text = "OK";
            this.btnOK2.UseVisualStyleBackColor = false;
            this.btnOK2.Click += new System.EventHandler(this.btnOK2_Click);
            // 
            // pnlFirstPlayer
            // 
            this.pnlFirstPlayer.Controls.Add(this.lblFirstPlayerName);
            this.pnlFirstPlayer.Controls.Add(this.txtFirstPlayerName);
            this.pnlFirstPlayer.Controls.Add(this.btnOK1);
            this.pnlFirstPlayer.Location = new System.Drawing.Point(20, 74);
            this.pnlFirstPlayer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlFirstPlayer.Name = "pnlFirstPlayer";
            this.pnlFirstPlayer.Size = new System.Drawing.Size(427, 38);
            this.pnlFirstPlayer.TabIndex = 13;
            // 
            // lblFirstPlayerName
            // 
            this.lblFirstPlayerName.AutoSize = true;
            this.lblFirstPlayerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstPlayerName.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblFirstPlayerName.Location = new System.Drawing.Point(4, 7);
            this.lblFirstPlayerName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFirstPlayerName.Name = "lblFirstPlayerName";
            this.lblFirstPlayerName.Size = new System.Drawing.Size(130, 18);
            this.lblFirstPlayerName.TabIndex = 2;
            this.lblFirstPlayerName.Text = "First Player Name:";
            // 
            // txtFirstPlayerName
            // 
            this.txtFirstPlayerName.Location = new System.Drawing.Point(184, 6);
            this.txtFirstPlayerName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtFirstPlayerName.Name = "txtFirstPlayerName";
            this.txtFirstPlayerName.Size = new System.Drawing.Size(132, 22);
            this.txtFirstPlayerName.TabIndex = 3;
            // 
            // btnOK1
            // 
            this.btnOK1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnOK1.Location = new System.Drawing.Point(352, 6);
            this.btnOK1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnOK1.Name = "btnOK1";
            this.btnOK1.Size = new System.Drawing.Size(68, 28);
            this.btnOK1.TabIndex = 6;
            this.btnOK1.Text = "OK";
            this.btnOK1.UseVisualStyleBackColor = false;
            this.btnOK1.Click += new System.EventHandler(this.btnOK1_Click);
            // 
            // frmStart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 222);
            this.Controls.Add(this.pnlSecondPlayer);
            this.Controls.Add(this.pnlPlay);
            this.Controls.Add(this.pnlFirstPlayer);
            this.Controls.Add(this.lblEnterNames);
            this.Controls.Add(this.lblWelcome);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmStart";
            this.Text = "Othello - The Game Nobody Seems to Know Of";
            this.Load += new System.EventHandler(this.frmOthello_Load);
            this.pnlPlay.ResumeLayout(false);
            this.pnlPlay.PerformLayout();
            this.pnlSecondPlayer.ResumeLayout(false);
            this.pnlSecondPlayer.PerformLayout();
            this.pnlFirstPlayer.ResumeLayout(false);
            this.pnlFirstPlayer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblEnterNames;
        private System.Windows.Forms.Panel pnlPlay;
        private System.Windows.Forms.Label lblReady;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Panel pnlSecondPlayer;
        private System.Windows.Forms.Label lblSecondPlayerName;
        private System.Windows.Forms.TextBox txtSecondPlayerName;
        private System.Windows.Forms.Button btnOK2;
        private System.Windows.Forms.Panel pnlFirstPlayer;
        private System.Windows.Forms.Label lblFirstPlayerName;
        private System.Windows.Forms.TextBox txtFirstPlayerName;
        private System.Windows.Forms.Button btnOK1;
    }
}

