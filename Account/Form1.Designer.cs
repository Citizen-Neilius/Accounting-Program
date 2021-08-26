namespace Account
{
    public partial class FormAcct
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
            this.labelAct = new System.Windows.Forms.Label();
            this.listBoxAcct = new System.Windows.Forms.ListBox();
            this.buttonOK = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.radioDeposit = new System.Windows.Forms.RadioButton();
            this.radioWithdrawal = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RadioRe = new System.Windows.Forms.RadioButton();
            this.radioLo = new System.Windows.Forms.RadioButton();
            this.radioSv = new System.Windows.Forms.RadioButton();
            this.radioCk = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelAct
            // 
            this.labelAct.AutoSize = true;
            this.labelAct.BackColor = System.Drawing.SystemColors.Highlight;
            this.labelAct.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.labelAct.Location = new System.Drawing.Point(211, 140);
            this.labelAct.MinimumSize = new System.Drawing.Size(400, 350);
            this.labelAct.Name = "labelAct";
            this.labelAct.Size = new System.Drawing.Size(400, 350);
            this.labelAct.TabIndex = 0;
            this.labelAct.Text = "Select a member and press OK ";
            this.labelAct.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // listBoxAcct
            // 
            this.listBoxAcct.BackColor = System.Drawing.SystemColors.Highlight;
            this.listBoxAcct.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.listBoxAcct.FormattingEnabled = true;
            this.listBoxAcct.ItemHeight = 25;
            this.listBoxAcct.Items.AddRange(new object[] {
            "Neil Little",
            "Tom Clancy",
            "Tina Tequilla",
            "Taco DePaco"});
            this.listBoxAcct.Location = new System.Drawing.Point(656, 367);
            this.listBoxAcct.Name = "listBoxAcct";
            this.listBoxAcct.Size = new System.Drawing.Size(195, 129);
            this.listBoxAcct.TabIndex = 1;
            this.listBoxAcct.SelectedIndexChanged += new System.EventHandler(this.listBoxAcct_SelectedIndexChanged);
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(857, 367);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(165, 45);
            this.buttonOK.TabIndex = 2;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(228, 586);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(204, 31);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // radioDeposit
            // 
            this.radioDeposit.AutoSize = true;
            this.radioDeposit.Checked = true;
            this.radioDeposit.Location = new System.Drawing.Point(47, 582);
            this.radioDeposit.Name = "radioDeposit";
            this.radioDeposit.Size = new System.Drawing.Size(116, 29);
            this.radioDeposit.TabIndex = 4;
            this.radioDeposit.TabStop = true;
            this.radioDeposit.Text = "Deposit";
            this.radioDeposit.UseVisualStyleBackColor = true;
            this.radioDeposit.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioWithdrawal
            // 
            this.radioWithdrawal.AutoSize = true;
            this.radioWithdrawal.Location = new System.Drawing.Point(47, 634);
            this.radioWithdrawal.Name = "radioWithdrawal";
            this.radioWithdrawal.Size = new System.Drawing.Size(149, 29);
            this.radioWithdrawal.TabIndex = 5;
            this.radioWithdrawal.TabStop = true;
            this.radioWithdrawal.Text = "Withdrawal";
            this.radioWithdrawal.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(228, 634);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(165, 52);
            this.button1.TabIndex = 6;
            this.button1.Text = "Deposit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RadioRe);
            this.groupBox1.Controls.Add(this.radioLo);
            this.groupBox1.Controls.Add(this.radioSv);
            this.groupBox1.Controls.Add(this.radioCk);
            this.groupBox1.Location = new System.Drawing.Point(468, 586);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(211, 240);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Which account?";
            // 
            // RadioRe
            // 
            this.RadioRe.AutoSize = true;
            this.RadioRe.Location = new System.Drawing.Point(5, 195);
            this.RadioRe.Name = "RadioRe";
            this.RadioRe.Size = new System.Drawing.Size(147, 29);
            this.RadioRe.TabIndex = 3;
            this.RadioRe.TabStop = true;
            this.RadioRe.Text = "Retirement";
            this.RadioRe.UseVisualStyleBackColor = true;
            // 
            // radioLo
            // 
            this.radioLo.AutoSize = true;
            this.radioLo.Location = new System.Drawing.Point(6, 146);
            this.radioLo.Name = "radioLo";
            this.radioLo.Size = new System.Drawing.Size(91, 29);
            this.radioLo.TabIndex = 2;
            this.radioLo.TabStop = true;
            this.radioLo.Text = "Loan";
            this.radioLo.UseVisualStyleBackColor = true;
            this.radioLo.CheckedChanged += new System.EventHandler(this.radioLo_CheckedChanged);
            // 
            // radioSv
            // 
            this.radioSv.AutoSize = true;
            this.radioSv.Location = new System.Drawing.Point(5, 96);
            this.radioSv.Name = "radioSv";
            this.radioSv.Size = new System.Drawing.Size(120, 29);
            this.radioSv.TabIndex = 1;
            this.radioSv.TabStop = true;
            this.radioSv.Text = "Savings";
            this.radioSv.UseVisualStyleBackColor = true;
            // 
            // radioCk
            // 
            this.radioCk.AutoSize = true;
            this.radioCk.Checked = true;
            this.radioCk.Location = new System.Drawing.Point(6, 48);
            this.radioCk.Name = "radioCk";
            this.radioCk.Size = new System.Drawing.Size(133, 29);
            this.radioCk.TabIndex = 0;
            this.radioCk.TabStop = true;
            this.radioCk.Text = "Checking";
            this.radioCk.UseVisualStyleBackColor = true;
            this.radioCk.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged_1);
            this.radioCk.Click += new System.EventHandler(this.radioCk_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(651, 296);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Select account, press ok";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(625, 499);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "label2";
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(702, 669);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 31);
            this.label3.TabIndex = 10;
            this.label3.Text = "  ";
            this.label3.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.ForeColor = System.Drawing.Color.LimeGreen;
            this.label4.Location = new System.Drawing.Point(651, 140);
            this.label4.MinimumSize = new System.Drawing.Size(200, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(200, 100);
            this.label4.TabIndex = 11;
            this.label4.Text = "Loan Info";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // FormAcct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1061, 942);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.radioWithdrawal);
            this.Controls.Add(this.radioDeposit);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.listBoxAcct);
            this.Controls.Add(this.labelAct);
            this.Name = "FormAcct";
            this.Text = "Account SDEV 260";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox listBoxAcct;
        public System.Windows.Forms.Label labelAct;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.RadioButton radioDeposit;
        private System.Windows.Forms.RadioButton radioWithdrawal;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton RadioRe;
        private System.Windows.Forms.RadioButton radioLo;
        private System.Windows.Forms.RadioButton radioSv;
        private System.Windows.Forms.RadioButton radioCk;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

