
namespace Battle_Of_Ships
{
    partial class Game_Over
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Highscore = new System.Windows.Forms.Label();
            this.Score = new System.Windows.Forms.Label();
            this.Exit_Game = new System.Windows.Forms.Button();
            this.Return_To_Main_Menu = new System.Windows.Forms.Button();
            this.Restart_Game = new System.Windows.Forms.Button();
            this.dragControl1 = new DragControl();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(94)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(580, 36);
            this.panel1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(3, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 23);
            this.label2.TabIndex = 11;
            this.label2.Text = "Game Over";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(55, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 28);
            this.label3.TabIndex = 5;
            this.label3.Text = "Your Score Is :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(55, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 28);
            this.label4.TabIndex = 6;
            this.label4.Text = "Highscore :";
            // 
            // Highscore
            // 
            this.Highscore.AutoSize = true;
            this.Highscore.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Highscore.Location = new System.Drawing.Point(205, 128);
            this.Highscore.Name = "Highscore";
            this.Highscore.Size = new System.Drawing.Size(25, 28);
            this.Highscore.TabIndex = 7;
            this.Highscore.Text = "0";
            // 
            // Score
            // 
            this.Score.AutoSize = true;
            this.Score.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Score.Location = new System.Drawing.Point(240, 76);
            this.Score.Name = "Score";
            this.Score.Size = new System.Drawing.Size(25, 28);
            this.Score.TabIndex = 8;
            this.Score.Text = "0";
            // 
            // Exit_Game
            // 
            this.Exit_Game.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Exit_Game.BackColor = System.Drawing.Color.MidnightBlue;
            this.Exit_Game.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Exit_Game.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exit_Game.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit_Game.ForeColor = System.Drawing.SystemColors.Control;
            this.Exit_Game.Location = new System.Drawing.Point(402, 187);
            this.Exit_Game.Margin = new System.Windows.Forms.Padding(4);
            this.Exit_Game.Name = "Exit_Game";
            this.Exit_Game.Size = new System.Drawing.Size(165, 39);
            this.Exit_Game.TabIndex = 12;
            this.Exit_Game.Text = "Exit Game";
            this.Exit_Game.UseVisualStyleBackColor = false;
            this.Exit_Game.Click += new System.EventHandler(this.Exit_Game_Click);
            // 
            // Return_To_Main_Menu
            // 
            this.Return_To_Main_Menu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Return_To_Main_Menu.BackColor = System.Drawing.Color.MidnightBlue;
            this.Return_To_Main_Menu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Return_To_Main_Menu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Return_To_Main_Menu.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Return_To_Main_Menu.ForeColor = System.Drawing.SystemColors.Control;
            this.Return_To_Main_Menu.Location = new System.Drawing.Point(194, 187);
            this.Return_To_Main_Menu.Margin = new System.Windows.Forms.Padding(4);
            this.Return_To_Main_Menu.Name = "Return_To_Main_Menu";
            this.Return_To_Main_Menu.Size = new System.Drawing.Size(183, 39);
            this.Return_To_Main_Menu.TabIndex = 11;
            this.Return_To_Main_Menu.Text = "Back To Main";
            this.Return_To_Main_Menu.UseVisualStyleBackColor = false;
            this.Return_To_Main_Menu.Click += new System.EventHandler(this.Return_To_Main_Menu_Click);
            // 
            // Restart_Game
            // 
            this.Restart_Game.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Restart_Game.BackColor = System.Drawing.Color.MidnightBlue;
            this.Restart_Game.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Restart_Game.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Restart_Game.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Restart_Game.ForeColor = System.Drawing.SystemColors.Control;
            this.Restart_Game.Location = new System.Drawing.Point(4, 187);
            this.Restart_Game.Margin = new System.Windows.Forms.Padding(4);
            this.Restart_Game.Name = "Restart_Game";
            this.Restart_Game.Size = new System.Drawing.Size(165, 39);
            this.Restart_Game.TabIndex = 10;
            this.Restart_Game.Text = "Restart Game";
            this.Restart_Game.UseVisualStyleBackColor = false;
            this.Restart_Game.Click += new System.EventHandler(this.Restart_Game_Click);
            // 
            // dragControl1
            // 
            this.dragControl1.SelectControl = this.panel1;
            // 
            // Game_Over
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(580, 239);
            this.Controls.Add(this.Exit_Game);
            this.Controls.Add(this.Return_To_Main_Menu);
            this.Controls.Add(this.Restart_Game);
            this.Controls.Add(this.Score);
            this.Controls.Add(this.Highscore);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Game_Over";
            this.ShowInTaskbar = false;
            this.Text = "Game_Over";
            this.TopMost = true;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Highscore;
        private System.Windows.Forms.Label Score;
        private System.Windows.Forms.Button Exit_Game;
        private System.Windows.Forms.Button Return_To_Main_Menu;
        private System.Windows.Forms.Button Restart_Game;
        private DragControl dragControl1;
    }
}