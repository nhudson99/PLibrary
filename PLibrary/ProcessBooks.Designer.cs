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
            this.btn_CheckOut = new System.Windows.Forms.Button();
            this.btn_CheckIn = new System.Windows.Forms.Button();
            this.btn_PlaceHold = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_CheckOut
            // 
            this.btn_CheckOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CheckOut.Location = new System.Drawing.Point(37, 78);
            this.btn_CheckOut.Name = "btn_CheckOut";
            this.btn_CheckOut.Size = new System.Drawing.Size(135, 63);
            this.btn_CheckOut.TabIndex = 0;
            this.btn_CheckOut.Text = "Check Out";
            this.btn_CheckOut.UseVisualStyleBackColor = true;
            this.btn_CheckOut.Click += new System.EventHandler(this.Btn_CheckOut_Click);
            // 
            // btn_CheckIn
            // 
            this.btn_CheckIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CheckIn.Location = new System.Drawing.Point(209, 78);
            this.btn_CheckIn.Name = "btn_CheckIn";
            this.btn_CheckIn.Size = new System.Drawing.Size(135, 61);
            this.btn_CheckIn.TabIndex = 1;
            this.btn_CheckIn.Text = "Check In";
            this.btn_CheckIn.UseVisualStyleBackColor = true;
            this.btn_CheckIn.Click += new System.EventHandler(this.Btn_CheckIn_Click);
            // 
            // btn_PlaceHold
            // 
            this.btn_PlaceHold.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_PlaceHold.Location = new System.Drawing.Point(379, 78);
            this.btn_PlaceHold.Name = "btn_PlaceHold";
            this.btn_PlaceHold.Size = new System.Drawing.Size(135, 63);
            this.btn_PlaceHold.TabIndex = 2;
            this.btn_PlaceHold.Text = "Place Hold";
            this.btn_PlaceHold.UseVisualStyleBackColor = true;
            this.btn_PlaceHold.Click += new System.EventHandler(this.Btn_PlaceHold_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label1.Location = new System.Drawing.Point(187, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 26);
            this.label1.TabIndex = 3;
            this.label1.Text = "Select an Action";
            // 
            // ProcessBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 177);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_PlaceHold);
            this.Controls.Add(this.btn_CheckIn);
            this.Controls.Add(this.btn_CheckOut);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ProcessBooks";
            this.Text = "ProcessBooks";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_CheckOut;
        private System.Windows.Forms.Button btn_CheckIn;
        private System.Windows.Forms.Button btn_PlaceHold;
        private System.Windows.Forms.Label label1;
    }
}