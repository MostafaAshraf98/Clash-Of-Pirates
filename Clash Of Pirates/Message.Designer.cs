namespace Battle_Of_Ships
{
    partial class Message
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Message));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.OK = new System.Windows.Forms.Button();
            this.Msg = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.NO = new System.Windows.Forms.Button();
            this.EXIT = new System.Windows.Forms.Button();
            this.RESTART = new System.Windows.Forms.Button();
            this.dragControl1 = new DragControl();
            this.dragControl2 = new DragControl();
            this.RETURN = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(94)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(561, 36);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(526, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 29);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // OK
            // 
            this.OK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(94)))));
            this.OK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OK.Enabled = false;
            this.OK.FlatAppearance.BorderSize = 0;
            this.OK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OK.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OK.ForeColor = System.Drawing.Color.White;
            this.OK.Location = new System.Drawing.Point(214, 143);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(108, 36);
            this.OK.TabIndex = 0;
            this.OK.Text = "OK";
            this.OK.UseVisualStyleBackColor = false;
            this.OK.Visible = false;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // Msg
            // 
            this.Msg.AutoSize = true;
            this.Msg.Location = new System.Drawing.Point(49, 66);
            this.Msg.Name = "Msg";
            this.Msg.Size = new System.Drawing.Size(0, 17);
            this.Msg.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(173, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "This is the message";
            // 
            // NO
            // 
            this.NO.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(94)))));
            this.NO.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NO.Enabled = false;
            this.NO.FlatAppearance.BorderSize = 0;
            this.NO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NO.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NO.ForeColor = System.Drawing.Color.White;
            this.NO.Location = new System.Drawing.Point(296, 143);
            this.NO.Name = "NO";
            this.NO.Size = new System.Drawing.Size(108, 36);
            this.NO.TabIndex = 4;
            this.NO.Text = "NO";
            this.NO.UseVisualStyleBackColor = false;
            this.NO.Visible = false;
            this.NO.Click += new System.EventHandler(this.NO_Click);
            // 
            // EXIT
            // 
            this.EXIT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(94)))));
            this.EXIT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EXIT.Enabled = false;
            this.EXIT.FlatAppearance.BorderSize = 0;
            this.EXIT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EXIT.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EXIT.ForeColor = System.Drawing.Color.White;
            this.EXIT.Location = new System.Drawing.Point(144, 143);
            this.EXIT.Name = "EXIT";
            this.EXIT.Size = new System.Drawing.Size(108, 36);
            this.EXIT.TabIndex = 5;
            this.EXIT.Text = "EXIT";
            this.EXIT.UseVisualStyleBackColor = false;
            this.EXIT.Visible = false;
            this.EXIT.Click += new System.EventHandler(this.EXIT_Click);
            // 
            // RESTART
            // 
            this.RESTART.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(94)))));
            this.RESTART.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RESTART.Enabled = false;
            this.RESTART.FlatAppearance.BorderSize = 0;
            this.RESTART.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RESTART.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RESTART.ForeColor = System.Drawing.Color.White;
            this.RESTART.Location = new System.Drawing.Point(144, 143);
            this.RESTART.Name = "RESTART";
            this.RESTART.Size = new System.Drawing.Size(108, 36);
            this.RESTART.TabIndex = 6;
            this.RESTART.Text = "RESTART";
            this.RESTART.UseVisualStyleBackColor = false;
            this.RESTART.Visible = false;
            this.RESTART.Click += new System.EventHandler(this.RESTART_Click);
            // 
            // dragControl1
            // 
            this.dragControl1.SelectControl = this;
            // 
            // dragControl2
            // 
            this.dragControl2.SelectControl = this.panel1;
            // 
            // RETURN
            // 
            this.RETURN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(94)))));
            this.RETURN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RETURN.Enabled = false;
            this.RETURN.FlatAppearance.BorderSize = 0;
            this.RETURN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RETURN.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RETURN.ForeColor = System.Drawing.Color.White;
            this.RETURN.Location = new System.Drawing.Point(144, 143);
            this.RETURN.Name = "RETURN";
            this.RETURN.Size = new System.Drawing.Size(108, 36);
            this.RETURN.TabIndex = 7;
            this.RETURN.Text = "RETURN";
            this.RETURN.UseVisualStyleBackColor = false;
            this.RETURN.Visible = false;
            this.RETURN.Click += new System.EventHandler(this.RETURN_Click_1);
            // 
            // Message
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(561, 239);
            this.Controls.Add(this.RETURN);
            this.Controls.Add(this.NO);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Msg);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.RESTART);
            this.Controls.Add(this.EXIT);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "Message";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Message";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Message_KeyDown);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button OK;
        private System.Windows.Forms.Label Msg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button NO;
        private System.Windows.Forms.Button EXIT;
        private System.Windows.Forms.Button RESTART;
        private DragControl dragControl1;
        private DragControl dragControl2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button RETURN;
    }
}