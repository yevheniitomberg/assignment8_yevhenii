namespace assignment8_yevhenii
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
            this.label1 = new System.Windows.Forms.Label();
            this.buttonCheck = new System.Windows.Forms.Button();
            this.inputName = new System.Windows.Forms.TextBox();
            this.selectBox = new System.Windows.Forms.ComboBox();
            this.labelStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.Location = new System.Drawing.Point(141, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter boy\'s/girl\'s name:";
            // 
            // buttonCheck
            // 
            this.buttonCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonCheck.Location = new System.Drawing.Point(179, 202);
            this.buttonCheck.Name = "buttonCheck";
            this.buttonCheck.Size = new System.Drawing.Size(180, 30);
            this.buttonCheck.TabIndex = 1;
            this.buttonCheck.Text = "Check popularity";
            this.buttonCheck.UseVisualStyleBackColor = true;
            this.buttonCheck.Click += new System.EventHandler(this.buttonCheck_Click);
            // 
            // inputName
            // 
            this.inputName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.inputName.Location = new System.Drawing.Point(146, 77);
            this.inputName.MaxLength = 32;
            this.inputName.Name = "inputName";
            this.inputName.Size = new System.Drawing.Size(245, 26);
            this.inputName.TabIndex = 2;
            // 
            // selectBox
            // 
            this.selectBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.selectBox.FormattingEnabled = true;
            this.selectBox.Location = new System.Drawing.Point(146, 119);
            this.selectBox.Name = "selectBox";
            this.selectBox.Size = new System.Drawing.Size(245, 28);
            this.selectBox.TabIndex = 3;
            // 
            // labelStatus
            // 
            this.labelStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelStatus.Location = new System.Drawing.Point(118, 161);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(300, 25);
            this.labelStatus.TabIndex = 4;
            this.labelStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 244);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.selectBox);
            this.Controls.Add(this.inputName);
            this.Controls.Add(this.buttonCheck);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Name Checker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonCheck;
        private System.Windows.Forms.TextBox inputName;
        private System.Windows.Forms.ComboBox selectBox;
        private System.Windows.Forms.Label labelStatus;
    }
}

