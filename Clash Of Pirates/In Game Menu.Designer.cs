
namespace Battle_Of_Ships
{
    partial class In_Game_Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(In_Game_Menu));
            this.Restart_Game = new System.Windows.Forms.Button();
            this.Return_To_Main_Menu = new System.Windows.Forms.Button();
            this.Exit_Game = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dragControl1 = new DragControl();
            this.dragControl2 = new DragControl();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Restart_Game
            // 
            this.Restart_Game.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Restart_Game.BackColor = System.Drawing.Color.MidnightBlue;
            this.Restart_Game.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Restart_Game.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Restart_Game.Font = new System.Drawing.Font("Century", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Restart_Game.ForeColor = System.Drawing.SystemColors.Control;
            this.Restart_Game.Location = new System.Drawing.Point(248, 112);
            this.Restart_Game.Margin = new System.Windows.Forms.Padding(4);
            this.Restart_Game.Name = "Restart_Game";
            this.Restart_Game.Size = new System.Drawing.Size(309, 39);
            this.Restart_Game.TabIndex = 7;
            this.Restart_Game.Text = "Restart Game";
            this.Restart_Game.UseVisualStyleBackColor = false;
            this.Restart_Game.Click += new System.EventHandler(this.Restart_Game_Click);
            // 
            // Return_To_Main_Menu
            // 
            this.Return_To_Main_Menu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Return_To_Main_Menu.BackColor = System.Drawing.Color.MidnightBlue;
            this.Return_To_Main_Menu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Return_To_Main_Menu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Return_To_Main_Menu.Font = new System.Drawing.Font("Century", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Return_To_Main_Menu.ForeColor = System.Drawing.SystemColors.Control;
            this.Return_To_Main_Menu.Location = new System.Drawing.Point(248, 182);
            this.Return_To_Main_Menu.Margin = new System.Windows.Forms.Padding(4);
            this.Return_To_Main_Menu.Name = "Return_To_Main_Menu";
            this.Return_To_Main_Menu.Size = new System.Drawing.Size(309, 39);
            this.Return_To_Main_Menu.TabIndex = 8;
            this.Return_To_Main_Menu.Text = "Return To Main Menu";
            this.Return_To_Main_Menu.UseVisualStyleBackColor = false;
            this.Return_To_Main_Menu.Click += new System.EventHandler(this.Return_To_Main_Menu_Click);
            // 
            // Exit_Game
            // 
            this.Exit_Game.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Exit_Game.BackColor = System.Drawing.Color.MidnightBlue;
            this.Exit_Game.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Exit_Game.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exit_Game.Font = new System.Drawing.Font("Century", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit_Game.ForeColor = System.Drawing.SystemColors.Control;
            this.Exit_Game.Location = new System.Drawing.Point(248, 252);
            this.Exit_Game.Margin = new System.Windows.Forms.Padding(4);
            this.Exit_Game.Name = "Exit_Game";
            this.Exit_Game.Size = new System.Drawing.Size(309, 39);
            this.Exit_Game.TabIndex = 9;
            this.Exit_Game.Text = "Exit Game";
            this.Exit_Game.UseVisualStyleBackColor = false;
            this.Exit_Game.Click += new System.EventHandler(this.Exit_Game_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 52);
            this.panel1.TabIndex = 10;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(747, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(41, 35);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // dragControl1
            // 
            this.dragControl1.SelectControl = this.panel1;
            // 
            // dragControl2
            // 
            this.dragControl2.SelectControl = this;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 28);
            this.label2.TabIndex = 11;
            this.label2.Text = "In Game Menu";
            // 
            // In_Game_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Exit_Game);
            this.Controls.Add(this.Return_To_Main_Menu);
            this.Controls.Add(this.Restart_Game);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "In_Game_Menu";
            this.ShowInTaskbar = false;
            this.Text = "In_Game_Menu";
            this.TopMost = true;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.In_Game_Menu_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Restart_Game;
        private System.Windows.Forms.Button Return_To_Main_Menu;
        private System.Windows.Forms.Button Exit_Game;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DragControl dragControl1;
        private DragControl dragControl2;
        private System.Windows.Forms.Label label2;
    }
}