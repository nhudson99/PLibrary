namespace PLibrary
{
    partial class ProcessBooks
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
            System.Windows.Forms.ComboBox SelectAccount;
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SelectAction = new System.Windows.Forms.ComboBox();
            this.Process = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.SelectBook = new System.Windows.Forms.TextBox();
            SelectAccount = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // SelectAccount
            // 
            SelectAccount.FormattingEnabled = true;
            SelectAccount.Location = new System.Drawing.Point(21, 31);
            SelectAccount.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            SelectAccount.Name = "SelectAccount";
            SelectAccount.Size = new System.Drawing.Size(206, 21);
            SelectAccount.TabIndex = 0;
            SelectAccount.SelectedIndexChanged += new System.EventHandler(this.SelectAccount_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select Account";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(241, 15);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Select Action";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(373, 15);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Book ID";
            // 
            // SelectAction
            // 
            this.SelectAction.FormattingEnabled = true;
            this.SelectAction.Items.AddRange(new object[] {
            "Check Out Book",
            "Check In Book",
            "Place Hold"});
            this.SelectAction.Location = new System.Drawing.Point(243, 31);
            this.SelectAction.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SelectAction.Name = "SelectAction";
            this.SelectAction.Size = new System.Drawing.Size(114, 21);
            this.SelectAction.TabIndex = 4;
            this.SelectAction.SelectedIndexChanged += new System.EventHandler(this.SelectAction_SelectedIndexChanged);
            // 
            // Process
            // 
            this.Process.Location = new System.Drawing.Point(419, 136);
            this.Process.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Process.Name = "Process";
            this.Process.Size = new System.Drawing.Size(68, 31);
            this.Process.TabIndex = 6;
            this.Process.Text = "Process";
            this.Process.UseVisualStyleBackColor = true;
            this.Process.Click += new System.EventHandler(this.Process_Click);
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(343, 136);
            this.Cancel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(68, 31);
            this.Cancel.TabIndex = 7;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // SelectBook
            // 
            this.SelectBook.Location = new System.Drawing.Point(375, 32);
            this.SelectBook.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SelectBook.Name = "SelectBook";
            this.SelectBook.Size = new System.Drawing.Size(114, 20);
            this.SelectBook.TabIndex = 8;
            // 
            // ProcessBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 191);
            this.Controls.Add(this.SelectBook);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Process);
            this.Controls.Add(this.SelectAction);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(SelectAccount);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ProcessBooks";
            this.Text = "ProcessBooks";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox SelectAction;
        private System.Windows.Forms.Button Process;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.TextBox SelectBook;
    }
}