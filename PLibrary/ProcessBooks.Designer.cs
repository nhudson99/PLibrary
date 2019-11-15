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
            SelectAccount.Location = new System.Drawing.Point(28, 38);
            SelectAccount.Name = "SelectAccount";
            SelectAccount.Size = new System.Drawing.Size(273, 24);
            SelectAccount.TabIndex = 0;
            SelectAccount.SelectedIndexChanged += new System.EventHandler(this.SelectAccount_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select Account";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(321, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Select Action";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(497, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 17);
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
            this.SelectAction.Location = new System.Drawing.Point(324, 38);
            this.SelectAction.Name = "SelectAction";
            this.SelectAction.Size = new System.Drawing.Size(151, 24);
            this.SelectAction.TabIndex = 4;
            this.SelectAction.SelectedIndexChanged += new System.EventHandler(this.SelectAction_SelectedIndexChanged);
            // 
            // Process
            // 
            this.Process.Location = new System.Drawing.Point(559, 168);
            this.Process.Name = "Process";
            this.Process.Size = new System.Drawing.Size(91, 38);
            this.Process.TabIndex = 6;
            this.Process.Text = "Process";
            this.Process.UseVisualStyleBackColor = true;
            this.Process.Click += new System.EventHandler(this.Process_Click);
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(457, 168);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(91, 38);
            this.Cancel.TabIndex = 7;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // SelectBook
            // 
            this.SelectBook.Location = new System.Drawing.Point(500, 40);
            this.SelectBook.Name = "SelectBook";
            this.SelectBook.Size = new System.Drawing.Size(150, 22);
            this.SelectBook.TabIndex = 8;
            // 
            // ProcessBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 235);
            this.Controls.Add(this.SelectBook);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Process);
            this.Controls.Add(this.SelectAction);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(SelectAccount);
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