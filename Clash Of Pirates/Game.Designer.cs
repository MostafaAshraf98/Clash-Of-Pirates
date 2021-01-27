
namespace Battle_Of_Ships
{
    partial class Game
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game));
            this.Player_Label = new System.Windows.Forms.Label();
            this.Score_Label = new System.Windows.Forms.Label();
            this.Score = new System.Windows.Forms.Label();
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            this.Ammunition_Label = new System.Windows.Forms.Label();
            this.Ammunition = new System.Windows.Forms.Label();
            this.Health_Label = new System.Windows.Forms.Label();
            this.HealthBar = new System.Windows.Forms.ProgressBar();
            this.ESC_Label = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.Ship = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Ship)).BeginInit();
            this.SuspendLayout();
            // 
            // Player_Label
            // 
            this.Player_Label.AutoSize = true;
            this.Player_Label.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Player_Label.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Player_Label.ForeColor = System.Drawing.Color.White;
            this.Player_Label.Location = new System.Drawing.Point(12, 21);
            this.Player_Label.Name = "Player_Label";
            this.Player_Label.Size = new System.Drawing.Size(76, 29);
            this.Player_Label.TabIndex = 0;
            this.Player_Label.Text = "Player";
            // 
            // Score_Label
            // 
            this.Score_Label.AutoSize = true;
            this.Score_Label.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Score_Label.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Score_Label.ForeColor = System.Drawing.Color.White;
            this.Score_Label.Location = new System.Drawing.Point(142, 21);
            this.Score_Label.Name = "Score_Label";
            this.Score_Label.Size = new System.Drawing.Size(80, 29);
            this.Score_Label.TabIndex = 1;
            this.Score_Label.Text = "Score: ";
            // 
            // Score
            // 
            this.Score.AutoSize = true;
            this.Score.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Score.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Score.ForeColor = System.Drawing.Color.White;
            this.Score.Location = new System.Drawing.Point(228, 21);
            this.Score.Name = "Score";
            this.Score.Size = new System.Drawing.Size(25, 29);
            this.Score.TabIndex = 4;
            this.Score.Text = "0";
            // 
            // GameTimer
            // 
            this.GameTimer.Enabled = true;
            this.GameTimer.Interval = 20;
            this.GameTimer.Tick += new System.EventHandler(this.MainTimerEvent);
            // 
            // Ammunition_Label
            // 
            this.Ammunition_Label.AutoSize = true;
            this.Ammunition_Label.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Ammunition_Label.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ammunition_Label.ForeColor = System.Drawing.Color.White;
            this.Ammunition_Label.Location = new System.Drawing.Point(303, 21);
            this.Ammunition_Label.Name = "Ammunition_Label";
            this.Ammunition_Label.Size = new System.Drawing.Size(140, 29);
            this.Ammunition_Label.TabIndex = 8;
            this.Ammunition_Label.Text = "Ammunition";
            // 
            // Ammunition
            // 
            this.Ammunition.AutoSize = true;
            this.Ammunition.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Ammunition.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ammunition.ForeColor = System.Drawing.Color.White;
            this.Ammunition.Location = new System.Drawing.Point(449, 21);
            this.Ammunition.Name = "Ammunition";
            this.Ammunition.Size = new System.Drawing.Size(25, 29);
            this.Ammunition.TabIndex = 9;
            this.Ammunition.Text = "0";
            // 
            // Health_Label
            // 
            this.Health_Label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Health_Label.AutoSize = true;
            this.Health_Label.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Health_Label.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Health_Label.ForeColor = System.Drawing.Color.White;
            this.Health_Label.Location = new System.Drawing.Point(824, 21);
            this.Health_Label.Name = "Health_Label";
            this.Health_Label.Size = new System.Drawing.Size(79, 29);
            this.Health_Label.TabIndex = 10;
            this.Health_Label.Text = "Health";
            // 
            // HealthBar
            // 
            this.HealthBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.HealthBar.Location = new System.Drawing.Point(927, 21);
            this.HealthBar.Name = "HealthBar";
            this.HealthBar.Size = new System.Drawing.Size(192, 29);
            this.HealthBar.TabIndex = 11;
            this.HealthBar.Value = 100;
            // 
            // ESC_Label
            // 
            this.ESC_Label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ESC_Label.AutoSize = true;
            this.ESC_Label.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ESC_Label.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ESC_Label.ForeColor = System.Drawing.Color.White;
            this.ESC_Label.Location = new System.Drawing.Point(860, 526);
            this.ESC_Label.Name = "ESC_Label";
            this.ESC_Label.Size = new System.Drawing.Size(259, 29);
            this.ESC_Label.TabIndex = 14;
            this.ESC_Label.Text = "Press ESC To Open Menu";
            // 
            // Ship
            // 
            this.Ship.BackColor = System.Drawing.Color.Transparent;
            this.Ship.Image = ((System.Drawing.Image)(resources.GetObject("Ship.Image")));
            this.Ship.Location = new System.Drawing.Point(494, 227);
            this.Ship.Name = "Ship";
            this.Ship.Size = new System.Drawing.Size(140, 140);
            this.Ship.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Ship.TabIndex = 15;
            this.Ship.TabStop = false;
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1162, 564);
            this.Controls.Add(this.Ship);
            this.Controls.Add(this.ESC_Label);
            this.Controls.Add(this.HealthBar);
            this.Controls.Add(this.Health_Label);
            this.Controls.Add(this.Ammunition);
            this.Controls.Add(this.Ammunition_Label);
            this.Controls.Add(this.Score);
            this.Controls.Add(this.Score_Label);
            this.Controls.Add(this.Player_Label);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "Game";
            this.Text = "Clash Of Pirates";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Game_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Game_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.Ship)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Player_Label;
        private System.Windows.Forms.Label Score_Label;
        private System.Windows.Forms.Label Score;
        private System.Windows.Forms.Timer GameTimer;
        private System.Windows.Forms.Label Ammunition_Label;
        private System.Windows.Forms.Label Ammunition;
        private System.Windows.Forms.Label Health_Label;
        private System.Windows.Forms.ProgressBar HealthBar;
        private System.Windows.Forms.Label ESC_Label;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.PictureBox Ship;
    }
}