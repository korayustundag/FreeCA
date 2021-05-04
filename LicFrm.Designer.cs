
namespace FreeCA
{
    partial class LicFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LicFrm));
            this.btnAcc = new System.Windows.Forms.Button();
            this.btnDec = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.linkFreeCA = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // btnAcc
            // 
            this.btnAcc.Location = new System.Drawing.Point(480, 358);
            this.btnAcc.Name = "btnAcc";
            this.btnAcc.Size = new System.Drawing.Size(75, 23);
            this.btnAcc.TabIndex = 0;
            this.btnAcc.Text = "Accept";
            this.btnAcc.UseVisualStyleBackColor = true;
            this.btnAcc.Click += new System.EventHandler(this.btnAcc_Click);
            // 
            // btnDec
            // 
            this.btnDec.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnDec.Location = new System.Drawing.Point(399, 358);
            this.btnDec.Name = "btnDec";
            this.btnDec.Size = new System.Drawing.Size(75, 23);
            this.btnDec.TabIndex = 1;
            this.btnDec.Text = "Decline";
            this.btnDec.UseVisualStyleBackColor = true;
            this.btnDec.Click += new System.EventHandler(this.btnDec_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.richTextBox1.Location = new System.Drawing.Point(12, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(543, 340);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // linkFreeCA
            // 
            this.linkFreeCA.AutoSize = true;
            this.linkFreeCA.Location = new System.Drawing.Point(12, 363);
            this.linkFreeCA.Name = "linkFreeCA";
            this.linkFreeCA.Size = new System.Drawing.Size(210, 13);
            this.linkFreeCA.TabIndex = 3;
            this.linkFreeCA.TabStop = true;
            this.linkFreeCA.Text = "https://github.com/korayustundag/FreeCA";
            this.linkFreeCA.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkFreeCA_LinkClicked);
            // 
            // LicFrm
            // 
            this.AcceptButton = this.btnAcc;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnDec;
            this.ClientSize = new System.Drawing.Size(567, 393);
            this.Controls.Add(this.linkFreeCA);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.btnDec);
            this.Controls.Add(this.btnAcc);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LicFrm";
            this.Text = "LICENSE";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LicFrm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAcc;
        private System.Windows.Forms.Button btnDec;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.LinkLabel linkFreeCA;
    }
}