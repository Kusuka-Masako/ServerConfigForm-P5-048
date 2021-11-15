
namespace ServerConfigForm_P5_048
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
            this.btnon = new System.Windows.Forms.Button();
            this.btnoff = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelket = new System.Windows.Forms.Label();
            this.labelOnOrOff = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnon
            // 
            this.btnon.Location = new System.Drawing.Point(263, 243);
            this.btnon.Name = "btnon";
            this.btnon.Size = new System.Drawing.Size(128, 43);
            this.btnon.TabIndex = 0;
            this.btnon.Text = "ON";
            this.btnon.UseVisualStyleBackColor = true;
            this.btnon.Click += new System.EventHandler(this.btnon_Click);
            // 
            // btnoff
            // 
            this.btnoff.Location = new System.Drawing.Point(450, 243);
            this.btnoff.Name = "btnoff";
            this.btnoff.Size = new System.Drawing.Size(128, 43);
            this.btnoff.TabIndex = 0;
            this.btnoff.Text = "OFF";
            this.btnoff.UseVisualStyleBackColor = true;
            this.btnoff.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(391, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Server";
            // 
            // labelket
            // 
            this.labelket.AutoSize = true;
            this.labelket.Location = new System.Drawing.Point(376, 129);
            this.labelket.Name = "labelket";
            this.labelket.Size = new System.Drawing.Size(0, 17);
            this.labelket.TabIndex = 1;
            // 
            // labelOnOrOff
            // 
            this.labelOnOrOff.AutoSize = true;
            this.labelOnOrOff.Location = new System.Drawing.Point(376, 182);
            this.labelOnOrOff.Name = "labelOnOrOff";
            this.labelOnOrOff.Size = new System.Drawing.Size(0, 17);
            this.labelOnOrOff.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelOnOrOff);
            this.Controls.Add(this.labelket);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnoff);
            this.Controls.Add(this.btnon);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnon;
        private System.Windows.Forms.Button btnoff;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelket;
        private System.Windows.Forms.Label labelOnOrOff;
    }
}

