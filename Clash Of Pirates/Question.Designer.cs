
namespace Battle_Of_Ships
{
    partial class Question
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Question));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Close = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Question_Label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Answer_Text = new System.Windows.Forms.TextBox();
            this.X_Wrong_Answer = new System.Windows.Forms.PictureBox();
            this.Message_Wrong_Answer = new System.Windows.Forms.Label();
            this.Message_Correct_Answer = new System.Windows.Forms.Label();
            this.OK = new System.Windows.Forms.Button();
            this.Display_Correct = new System.Windows.Forms.Label();
            this.Correct_Answer_Label = new System.Windows.Forms.Label();
            this.Time = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Check = new System.Windows.Forms.PictureBox();
            this.Continue = new System.Windows.Forms.Button();
            this.dragControl1 = new DragControl();
            this.dragControl2 = new DragControl();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.X_Wrong_Answer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Check)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.Close);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(572, 46);
            this.panel1.TabIndex = 1;
            // 
            // Close
            // 
            this.Close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Close.Image = ((System.Drawing.Image)(resources.GetObject("Close.Image")));
            this.Close.Location = new System.Drawing.Point(528, 3);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(41, 35);
            this.Close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Close.TabIndex = 12;
            this.Close.TabStop = false;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(712, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(41, 35);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 28);
            this.label2.TabIndex = 10;
            this.label2.Text = "Question";
            // 
            // Question_Label
            // 
            this.Question_Label.AutoSize = true;
            this.Question_Label.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Question_Label.Location = new System.Drawing.Point(176, 134);
            this.Question_Label.MaximumSize = new System.Drawing.Size(550, 0);
            this.Question_Label.Name = "Question_Label";
            this.Question_Label.Size = new System.Drawing.Size(209, 29);
            this.Question_Label.TabIndex = 3;
            this.Question_Label.Text = "This is the Question";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 281);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "Answer :";
            // 
            // Answer_Text
            // 
            this.Answer_Text.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Answer_Text.Location = new System.Drawing.Point(135, 277);
            this.Answer_Text.Name = "Answer_Text";
            this.Answer_Text.Size = new System.Drawing.Size(100, 36);
            this.Answer_Text.TabIndex = 5;
            this.Answer_Text.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Answer_Text_KeyDown);
            // 
            // X_Wrong_Answer
            // 
            this.X_Wrong_Answer.Image = ((System.Drawing.Image)(resources.GetObject("X_Wrong_Answer.Image")));
            this.X_Wrong_Answer.Location = new System.Drawing.Point(255, 277);
            this.X_Wrong_Answer.Name = "X_Wrong_Answer";
            this.X_Wrong_Answer.Size = new System.Drawing.Size(34, 37);
            this.X_Wrong_Answer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.X_Wrong_Answer.TabIndex = 6;
            this.X_Wrong_Answer.TabStop = false;
            this.X_Wrong_Answer.Visible = false;
            // 
            // Message_Wrong_Answer
            // 
            this.Message_Wrong_Answer.AutoSize = true;
            this.Message_Wrong_Answer.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Message_Wrong_Answer.ForeColor = System.Drawing.Color.Red;
            this.Message_Wrong_Answer.Location = new System.Drawing.Point(295, 281);
            this.Message_Wrong_Answer.Name = "Message_Wrong_Answer";
            this.Message_Wrong_Answer.Size = new System.Drawing.Size(162, 29);
            this.Message_Wrong_Answer.TabIndex = 8;
            this.Message_Wrong_Answer.Text = "Wrong Answer";
            this.Message_Wrong_Answer.Visible = false;
            // 
            // Message_Correct_Answer
            // 
            this.Message_Correct_Answer.AutoSize = true;
            this.Message_Correct_Answer.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Message_Correct_Answer.ForeColor = System.Drawing.Color.Green;
            this.Message_Correct_Answer.Location = new System.Drawing.Point(295, 281);
            this.Message_Correct_Answer.Name = "Message_Correct_Answer";
            this.Message_Correct_Answer.Size = new System.Drawing.Size(169, 29);
            this.Message_Correct_Answer.TabIndex = 9;
            this.Message_Correct_Answer.Text = "Correct Answer";
            this.Message_Correct_Answer.Visible = false;
            // 
            // OK
            // 
            this.OK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.OK.BackColor = System.Drawing.Color.MidnightBlue;
            this.OK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OK.Font = new System.Drawing.Font("Century", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OK.ForeColor = System.Drawing.SystemColors.Control;
            this.OK.Location = new System.Drawing.Point(223, 419);
            this.OK.Margin = new System.Windows.Forms.Padding(4);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(100, 39);
            this.OK.TabIndex = 10;
            this.OK.Text = "OK";
            this.OK.UseVisualStyleBackColor = false;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // Display_Correct
            // 
            this.Display_Correct.AutoSize = true;
            this.Display_Correct.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Display_Correct.Location = new System.Drawing.Point(12, 360);
            this.Display_Correct.Name = "Display_Correct";
            this.Display_Correct.Size = new System.Drawing.Size(244, 29);
            this.Display_Correct.TabIndex = 11;
            this.Display_Correct.Text = "The Correct Answer Is: ";
            this.Display_Correct.Visible = false;
            // 
            // Correct_Answer_Label
            // 
            this.Correct_Answer_Label.AutoSize = true;
            this.Correct_Answer_Label.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Correct_Answer_Label.Location = new System.Drawing.Point(276, 360);
            this.Correct_Answer_Label.Name = "Correct_Answer_Label";
            this.Correct_Answer_Label.Size = new System.Drawing.Size(37, 29);
            this.Correct_Answer_Label.TabIndex = 12;
            this.Correct_Answer_Label.Text = "00";
            this.Correct_Answer_Label.Visible = false;
            // 
            // Time
            // 
            this.Time.AutoSize = true;
            this.Time.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Time.Location = new System.Drawing.Point(262, 68);
            this.Time.Name = "Time";
            this.Time.Size = new System.Drawing.Size(37, 29);
            this.Time.TabIndex = 13;
            this.Time.Text = "60";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(186, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 29);
            this.label4.TabIndex = 14;
            this.label4.Text = "Time:";
            // 
            // Check
            // 
            this.Check.Image = ((System.Drawing.Image)(resources.GetObject("Check.Image")));
            this.Check.Location = new System.Drawing.Point(255, 277);
            this.Check.Name = "Check";
            this.Check.Size = new System.Drawing.Size(34, 37);
            this.Check.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Check.TabIndex = 15;
            this.Check.TabStop = false;
            this.Check.Visible = false;
            // 
            // Continue
            // 
            this.Continue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Continue.BackColor = System.Drawing.Color.MidnightBlue;
            this.Continue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Continue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Continue.Font = new System.Drawing.Font("Century", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Continue.ForeColor = System.Drawing.SystemColors.Control;
            this.Continue.Location = new System.Drawing.Point(201, 419);
            this.Continue.Margin = new System.Windows.Forms.Padding(4);
            this.Continue.Name = "Continue";
            this.Continue.Size = new System.Drawing.Size(149, 39);
            this.Continue.TabIndex = 16;
            this.Continue.Text = "Continue";
            this.Continue.UseVisualStyleBackColor = false;
            this.Continue.Visible = false;
            this.Continue.Click += new System.EventHandler(this.Continue_Click);
            // 
            // dragControl1
            // 
            this.dragControl1.SelectControl = this.panel1;
            // 
            // dragControl2
            // 
            this.dragControl2.SelectControl = this;
            // 
            // Question
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(572, 471);
            this.Controls.Add(this.Check);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Time);
            this.Controls.Add(this.Correct_Answer_Label);
            this.Controls.Add(this.Display_Correct);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.Message_Correct_Answer);
            this.Controls.Add(this.Message_Wrong_Answer);
            this.Controls.Add(this.X_Wrong_Answer);
            this.Controls.Add(this.Answer_Text);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Question_Label);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Continue);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Question";
            this.ShowInTaskbar = false;
            this.Text = "Question";
            this.Load += new System.EventHandler(this.Question_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Question_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.X_Wrong_Answer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Check)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox Close;
        private System.Windows.Forms.Label Question_Label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Answer_Text;
        private System.Windows.Forms.PictureBox X_Wrong_Answer;
        private System.Windows.Forms.Label Message_Wrong_Answer;
        private System.Windows.Forms.Label Message_Correct_Answer;
        private System.Windows.Forms.Button OK;
        private System.Windows.Forms.Label Display_Correct;
        private System.Windows.Forms.Label Correct_Answer_Label;
        private System.Windows.Forms.Label Time;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox Check;
        private System.Windows.Forms.Button Continue;
        private DragControl dragControl1;
        private DragControl dragControl2;
    }
}