namespace Accounting
{
    partial class Form1
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
            this.AccountDis = new System.Windows.Forms.Label();
            this.userList = new System.Windows.Forms.ListBox();
            this.selAct = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AccountDis
            // 
            this.AccountDis.AutoSize = true;
            this.AccountDis.BackColor = System.Drawing.SystemColors.ControlText;
            this.AccountDis.ForeColor = System.Drawing.Color.LawnGreen;
            this.AccountDis.Location = new System.Drawing.Point(46, 157);
            this.AccountDis.MinimumSize = new System.Drawing.Size(600, 400);
            this.AccountDis.Name = "AccountDis";
            this.AccountDis.Size = new System.Drawing.Size(600, 400);
            this.AccountDis.TabIndex = 0;
            this.AccountDis.Text = "Account";
            // 
            // userList
            // 
            this.userList.FormattingEnabled = true;
            this.userList.ItemHeight = 25;
            this.userList.Items.AddRange(new object[] {
            "Neil Little",
            "Tom Clancy",
            "Tina Tequilla",
            "Taco DePaco"});
            this.userList.Location = new System.Drawing.Point(961, 75);
            this.userList.Name = "userList";
            this.userList.Size = new System.Drawing.Size(238, 304);
            this.userList.TabIndex = 1;
            this.userList.SelectedIndexChanged += new System.EventHandler(this.userList_SelectedIndexChanged);
            // 
            // selAct
            // 
            this.selAct.Location = new System.Drawing.Point(42, 25);
            this.selAct.Name = "selAct";
            this.selAct.Size = new System.Drawing.Size(180, 68);
            this.selAct.TabIndex = 2;
            this.selAct.Text = "Ok";
            this.selAct.UseVisualStyleBackColor = true;
            this.selAct.Click += new System.EventHandler(this.selAct_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1415, 797);
            this.Controls.Add(this.selAct);
            this.Controls.Add(this.userList);
            this.Controls.Add(this.AccountDis);
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox userList;
        private System.Windows.Forms.Button selAct;
        public System.Windows.Forms.Label AccountDis;
    }
}

