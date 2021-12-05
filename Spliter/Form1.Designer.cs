namespace Spliter
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
            this.txtStart = new System.Windows.Forms.TextBox();
            this.btnConvert = new System.Windows.Forms.Button();
            this.lblStart = new System.Windows.Forms.Label();
            this.txtEnd = new System.Windows.Forms.TextBox();
            this.txtSource = new System.Windows.Forms.TextBox();
            this.txtFormat = new System.Windows.Forms.TextBox();
            this.lblEnd = new System.Windows.Forms.Label();
            this.lblSource = new System.Windows.Forms.Label();
            this.lblFormat = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtStart
            // 
            this.txtStart.Location = new System.Drawing.Point(53, 15);
            this.txtStart.Name = "txtStart";
            this.txtStart.Size = new System.Drawing.Size(577, 20);
            this.txtStart.TabIndex = 0;
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(11, 412);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(618, 37);
            this.btnConvert.TabIndex = 4;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // lblStart
            // 
            this.lblStart.AutoSize = true;
            this.lblStart.Location = new System.Drawing.Point(12, 18);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(29, 13);
            this.lblStart.TabIndex = 2;
            this.lblStart.Text = "Start";
            // 
            // txtEnd
            // 
            this.txtEnd.Location = new System.Drawing.Point(53, 56);
            this.txtEnd.Name = "txtEnd";
            this.txtEnd.Size = new System.Drawing.Size(577, 20);
            this.txtEnd.TabIndex = 1;
            // 
            // txtSource
            // 
            this.txtSource.Location = new System.Drawing.Point(53, 97);
            this.txtSource.Multiline = true;
            this.txtSource.Name = "txtSource";
            this.txtSource.Size = new System.Drawing.Size(577, 220);
            this.txtSource.TabIndex = 2;
            // 
            // txtFormat
            // 
            this.txtFormat.Location = new System.Drawing.Point(53, 338);
            this.txtFormat.Multiline = true;
            this.txtFormat.Name = "txtFormat";
            this.txtFormat.Size = new System.Drawing.Size(577, 54);
            this.txtFormat.TabIndex = 3;
            this.txtFormat.Text = "#1#\\n";
            // 
            // lblEnd
            // 
            this.lblEnd.AutoSize = true;
            this.lblEnd.Location = new System.Drawing.Point(12, 59);
            this.lblEnd.Name = "lblEnd";
            this.lblEnd.Size = new System.Drawing.Size(26, 13);
            this.lblEnd.TabIndex = 6;
            this.lblEnd.Text = "End";
            // 
            // lblSource
            // 
            this.lblSource.AutoSize = true;
            this.lblSource.Location = new System.Drawing.Point(12, 100);
            this.lblSource.Name = "lblSource";
            this.lblSource.Size = new System.Drawing.Size(41, 13);
            this.lblSource.TabIndex = 7;
            this.lblSource.Text = "Source";
            // 
            // lblFormat
            // 
            this.lblFormat.AutoSize = true;
            this.lblFormat.Location = new System.Drawing.Point(8, 341);
            this.lblFormat.Name = "lblFormat";
            this.lblFormat.Size = new System.Drawing.Size(39, 13);
            this.lblFormat.TabIndex = 8;
            this.lblFormat.Text = "Format";
            // 
            // Form1
            // 
            this.AcceptButton = this.btnConvert;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 461);
            this.Controls.Add(this.lblFormat);
            this.Controls.Add(this.lblSource);
            this.Controls.Add(this.lblEnd);
            this.Controls.Add(this.txtFormat);
            this.Controls.Add(this.txtSource);
            this.Controls.Add(this.txtEnd);
            this.Controls.Add(this.lblStart);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.txtStart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Spliter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtStart;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.Label lblStart;
        private System.Windows.Forms.TextBox txtEnd;
        private System.Windows.Forms.TextBox txtSource;
        private System.Windows.Forms.TextBox txtFormat;
        private System.Windows.Forms.Label lblEnd;
        private System.Windows.Forms.Label lblSource;
        private System.Windows.Forms.Label lblFormat;
    }
}

