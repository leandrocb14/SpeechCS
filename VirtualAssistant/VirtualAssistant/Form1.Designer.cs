namespace VirtualAssistant
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
            this.txtBoxNumber1 = new System.Windows.Forms.TextBox();
            this.txtBoxOperation = new System.Windows.Forms.TextBox();
            this.txtBoxNumber2 = new System.Windows.Forms.TextBox();
            this.labelEquals = new System.Windows.Forms.Label();
            this.txtBoxResult = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtBoxNumber1
            // 
            this.txtBoxNumber1.Enabled = false;
            this.txtBoxNumber1.Location = new System.Drawing.Point(290, 107);
            this.txtBoxNumber1.Name = "txtBoxNumber1";
            this.txtBoxNumber1.ReadOnly = true;
            this.txtBoxNumber1.Size = new System.Drawing.Size(39, 20);
            this.txtBoxNumber1.TabIndex = 0;
            // 
            // txtBoxOperation
            // 
            this.txtBoxOperation.Enabled = false;
            this.txtBoxOperation.Location = new System.Drawing.Point(335, 107);
            this.txtBoxOperation.Name = "txtBoxOperation";
            this.txtBoxOperation.ReadOnly = true;
            this.txtBoxOperation.Size = new System.Drawing.Size(39, 20);
            this.txtBoxOperation.TabIndex = 1;
            // 
            // txtBoxNumber2
            // 
            this.txtBoxNumber2.Enabled = false;
            this.txtBoxNumber2.Location = new System.Drawing.Point(380, 107);
            this.txtBoxNumber2.Name = "txtBoxNumber2";
            this.txtBoxNumber2.ReadOnly = true;
            this.txtBoxNumber2.Size = new System.Drawing.Size(39, 20);
            this.txtBoxNumber2.TabIndex = 2;
            // 
            // labelEquals
            // 
            this.labelEquals.AutoSize = true;
            this.labelEquals.Location = new System.Drawing.Point(426, 111);
            this.labelEquals.Name = "labelEquals";
            this.labelEquals.Size = new System.Drawing.Size(13, 13);
            this.labelEquals.TabIndex = 3;
            this.labelEquals.Text = "=";
            // 
            // txtBoxResult
            // 
            this.txtBoxResult.Enabled = false;
            this.txtBoxResult.Location = new System.Drawing.Point(444, 107);
            this.txtBoxResult.Name = "txtBoxResult";
            this.txtBoxResult.ReadOnly = true;
            this.txtBoxResult.Size = new System.Drawing.Size(39, 20);
            this.txtBoxResult.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtBoxResult);
            this.Controls.Add(this.labelEquals);
            this.Controls.Add(this.txtBoxNumber2);
            this.Controls.Add(this.txtBoxOperation);
            this.Controls.Add(this.txtBoxNumber1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxNumber1;
        private System.Windows.Forms.TextBox txtBoxOperation;
        private System.Windows.Forms.TextBox txtBoxNumber2;
        private System.Windows.Forms.Label labelEquals;
        private System.Windows.Forms.TextBox txtBoxResult;
    }
}

