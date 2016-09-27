namespace QuestionName
{
    partial class frmOneQuestionQuiz
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOneQuestionQuiz));
            this.lbl_Question = new System.Windows.Forms.Label();
            this.grbRadioButtons = new System.Windows.Forms.GroupBox();
            this.radioButton_exit = new System.Windows.Forms.RadioButton();
            this.RadioButton_false = new System.Windows.Forms.RadioButton();
            this.RadioButton_true = new System.Windows.Forms.RadioButton();
            this.grbRadioButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_Question
            // 
            this.lbl_Question.AutoSize = true;
            this.lbl_Question.BackColor = System.Drawing.SystemColors.ControlText;
            this.lbl_Question.Font = new System.Drawing.Font("Showcard Gothic", 101.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Question.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lbl_Question.Image = ((System.Drawing.Image)(resources.GetObject("lbl_Question.Image")));
            this.lbl_Question.Location = new System.Drawing.Point(187, 28);
            this.lbl_Question.Name = "lbl_Question";
            this.lbl_Question.Size = new System.Drawing.Size(1121, 167);
            this.lbl_Question.TabIndex = 0;
            this.lbl_Question.Text = "TRUE OR FALSE ?";
            this.lbl_Question.Click += new System.EventHandler(this.lbl_question_Click);
            // 
            // grbRadioButtons
            // 
            this.grbRadioButtons.Controls.Add(this.radioButton_exit);
            this.grbRadioButtons.Controls.Add(this.RadioButton_false);
            this.grbRadioButtons.Controls.Add(this.RadioButton_true);
            this.grbRadioButtons.Location = new System.Drawing.Point(155, 375);
            this.grbRadioButtons.Name = "grbRadioButtons";
            this.grbRadioButtons.Size = new System.Drawing.Size(546, 260);
            this.grbRadioButtons.TabIndex = 1;
            this.grbRadioButtons.TabStop = false;
            // 
            // radioButton_exit
            // 
            this.radioButton_exit.AutoSize = true;
            this.radioButton_exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.radioButton_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.25F);
            this.radioButton_exit.Location = new System.Drawing.Point(424, 177);
            this.radioButton_exit.Name = "radioButton_exit";
            this.radioButton_exit.Size = new System.Drawing.Size(92, 43);
            this.radioButton_exit.TabIndex = 2;
            this.radioButton_exit.TabStop = true;
            this.radioButton_exit.Text = "Exit";
            this.radioButton_exit.UseVisualStyleBackColor = false;
            this.radioButton_exit.CheckedChanged += new System.EventHandler(this.radioButton_exit_CheckedChanged);
            // 
            // RadioButton_false
            // 
            this.RadioButton_false.AutoSize = true;
            this.RadioButton_false.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.RadioButton_false.Font = new System.Drawing.Font("Microsoft Sans Serif", 40.25F);
            this.RadioButton_false.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.RadioButton_false.Location = new System.Drawing.Point(326, 16);
            this.RadioButton_false.Name = "RadioButton_false";
            this.RadioButton_false.Size = new System.Drawing.Size(178, 67);
            this.RadioButton_false.TabIndex = 1;
            this.RadioButton_false.TabStop = true;
            this.RadioButton_false.Text = "False";
            this.RadioButton_false.UseVisualStyleBackColor = false;
            this.RadioButton_false.CheckedChanged += new System.EventHandler(this.RadioButton_false_CheckedChanged);
            // 
            // RadioButton_true
            // 
            this.RadioButton_true.AutoSize = true;
            this.RadioButton_true.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.RadioButton_true.Font = new System.Drawing.Font("Microsoft Sans Serif", 40.25F);
            this.RadioButton_true.Location = new System.Drawing.Point(60, 16);
            this.RadioButton_true.Name = "RadioButton_true";
            this.RadioButton_true.Size = new System.Drawing.Size(156, 67);
            this.RadioButton_true.TabIndex = 0;
            this.RadioButton_true.TabStop = true;
            this.RadioButton_true.Text = "True";
            this.RadioButton_true.UseVisualStyleBackColor = false;
            this.RadioButton_true.CheckedChanged += new System.EventHandler(this.RadioButton_true_CheckedChanged);
            // 
            // frmOneQuestionQuiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1497, 730);
            this.Controls.Add(this.grbRadioButtons);
            this.Controls.Add(this.lbl_Question);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmOneQuestionQuiz";
            this.Text = "One Question Quiz";
            this.TransparencyKey = System.Drawing.Color.White;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grbRadioButtons.ResumeLayout(false);
            this.grbRadioButtons.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Question;
        private System.Windows.Forms.GroupBox grbRadioButtons;
        private System.Windows.Forms.RadioButton RadioButton_false;
        private System.Windows.Forms.RadioButton RadioButton_true;
        private System.Windows.Forms.RadioButton radioButton_exit;
    }
}

