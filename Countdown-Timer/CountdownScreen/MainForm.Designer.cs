namespace CountdownScreen
{
    partial class MainForm
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
            this.cmdShow = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dtCount = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.cboScreen = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmdShow
            // 
            this.cmdShow.Location = new System.Drawing.Point(56, 111);
            this.cmdShow.Name = "cmdShow";
            this.cmdShow.Size = new System.Drawing.Size(91, 32);
            this.cmdShow.TabIndex = 0;
            this.cmdShow.Text = "Mulai";
            this.cmdShow.UseVisualStyleBackColor = true;
            this.cmdShow.Click += new System.EventHandler(this.cmdShow_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Timer:";
            // 
            // dtCount
            // 
            this.dtCount.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtCount.Location = new System.Drawing.Point(80, 26);
            this.dtCount.Name = "dtCount";
            this.dtCount.ShowUpDown = true;
            this.dtCount.Size = new System.Drawing.Size(82, 20);
            this.dtCount.TabIndex = 4;
            this.dtCount.Value = new System.DateTime(2018, 5, 24, 0, 0, 0, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Screen:";
            // 
            // cboScreen
            // 
            this.cboScreen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboScreen.FormattingEnabled = true;
            this.cboScreen.Location = new System.Drawing.Point(80, 52);
            this.cboScreen.Name = "cboScreen";
            this.cboScreen.Size = new System.Drawing.Size(204, 21);
            this.cboScreen.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(153, 111);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 32);
            this.button1.TabIndex = 7;
            this.button1.Text = "Berhenti";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 165);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cboScreen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtCount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmdShow);
            this.Name = "MainForm";
            this.Text = "CountdownScreen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdShow;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtCount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboScreen;
        private System.Windows.Forms.Button button1;
    }
}

