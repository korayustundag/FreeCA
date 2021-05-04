
namespace FreeCA
{
    partial class MainFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFrm));
            this.menu1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportCAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtCN = new System.Windows.Forms.TextBox();
            this.txtO = new System.Windows.Forms.TextBox();
            this.txtOU = new System.Windows.Forms.TextBox();
            this.txtS = new System.Windows.Forms.TextBox();
            this.txtL = new System.Windows.Forms.TextBox();
            this.txtC = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.saveBox1 = new System.Windows.Forms.GroupBox();
            this.txtKeyLoc = new System.Windows.Forms.TextBox();
            this.txtCertLoc = new System.Windows.Forms.TextBox();
            this.btnPkeySelect = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnCertSelect = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.menu1.SuspendLayout();
            this.saveBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu1
            // 
            this.menu1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menu1.Location = new System.Drawing.Point(0, 0);
            this.menu1.Name = "menu1";
            this.menu1.Size = new System.Drawing.Size(425, 24);
            this.menu1.TabIndex = 0;
            this.menu1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportCAToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exportCAToolStripMenuItem
            // 
            this.exportCAToolStripMenuItem.Name = "exportCAToolStripMenuItem";
            this.exportCAToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exportCAToolStripMenuItem.Text = "Export CA";
            this.exportCAToolStripMenuItem.Click += new System.EventHandler(this.exportCAToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // txtCN
            // 
            this.txtCN.Location = new System.Drawing.Point(117, 41);
            this.txtCN.MaxLength = 50;
            this.txtCN.Name = "txtCN";
            this.txtCN.Size = new System.Drawing.Size(296, 20);
            this.txtCN.TabIndex = 1;
            // 
            // txtO
            // 
            this.txtO.Location = new System.Drawing.Point(117, 67);
            this.txtO.MaxLength = 50;
            this.txtO.Name = "txtO";
            this.txtO.Size = new System.Drawing.Size(296, 20);
            this.txtO.TabIndex = 2;
            // 
            // txtOU
            // 
            this.txtOU.Location = new System.Drawing.Point(117, 93);
            this.txtOU.MaxLength = 50;
            this.txtOU.Name = "txtOU";
            this.txtOU.Size = new System.Drawing.Size(296, 20);
            this.txtOU.TabIndex = 3;
            // 
            // txtS
            // 
            this.txtS.Location = new System.Drawing.Point(117, 119);
            this.txtS.MaxLength = 50;
            this.txtS.Name = "txtS";
            this.txtS.Size = new System.Drawing.Size(296, 20);
            this.txtS.TabIndex = 4;
            // 
            // txtL
            // 
            this.txtL.Location = new System.Drawing.Point(117, 145);
            this.txtL.MaxLength = 50;
            this.txtL.Name = "txtL";
            this.txtL.Size = new System.Drawing.Size(296, 20);
            this.txtL.TabIndex = 5;
            // 
            // txtC
            // 
            this.txtC.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtC.Location = new System.Drawing.Point(117, 171);
            this.txtC.MaxLength = 2;
            this.txtC.Name = "txtC";
            this.txtC.Size = new System.Drawing.Size(296, 20);
            this.txtC.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Common Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Organization:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Organizational Unit:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(76, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "State:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(65, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Locality:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(65, 174);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Country:";
            // 
            // saveBox1
            // 
            this.saveBox1.Controls.Add(this.txtKeyLoc);
            this.saveBox1.Controls.Add(this.txtCertLoc);
            this.saveBox1.Controls.Add(this.btnPkeySelect);
            this.saveBox1.Controls.Add(this.label8);
            this.saveBox1.Controls.Add(this.label7);
            this.saveBox1.Controls.Add(this.btnCertSelect);
            this.saveBox1.Controls.Add(this.btnCreate);
            this.saveBox1.Location = new System.Drawing.Point(12, 197);
            this.saveBox1.Name = "saveBox1";
            this.saveBox1.Size = new System.Drawing.Size(401, 169);
            this.saveBox1.TabIndex = 8;
            this.saveBox1.TabStop = false;
            this.saveBox1.Text = "Save";
            // 
            // txtKeyLoc
            // 
            this.txtKeyLoc.Location = new System.Drawing.Point(6, 94);
            this.txtKeyLoc.Name = "txtKeyLoc";
            this.txtKeyLoc.ReadOnly = true;
            this.txtKeyLoc.Size = new System.Drawing.Size(308, 20);
            this.txtKeyLoc.TabIndex = 9;
            // 
            // txtCertLoc
            // 
            this.txtCertLoc.Location = new System.Drawing.Point(6, 42);
            this.txtCertLoc.Name = "txtCertLoc";
            this.txtCertLoc.ReadOnly = true;
            this.txtCertLoc.Size = new System.Drawing.Size(308, 20);
            this.txtCertLoc.TabIndex = 8;
            // 
            // btnPkeySelect
            // 
            this.btnPkeySelect.Location = new System.Drawing.Point(320, 92);
            this.btnPkeySelect.Name = "btnPkeySelect";
            this.btnPkeySelect.Size = new System.Drawing.Size(75, 23);
            this.btnPkeySelect.TabIndex = 1;
            this.btnPkeySelect.Text = "...";
            this.btnPkeySelect.UseVisualStyleBackColor = true;
            this.btnPkeySelect.Click += new System.EventHandler(this.btnPkeySelect_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 78);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Private Key:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Cert:";
            // 
            // btnCertSelect
            // 
            this.btnCertSelect.Location = new System.Drawing.Point(320, 40);
            this.btnCertSelect.Name = "btnCertSelect";
            this.btnCertSelect.Size = new System.Drawing.Size(75, 23);
            this.btnCertSelect.TabIndex = 1;
            this.btnCertSelect.Text = "...";
            this.btnCertSelect.UseVisualStyleBackColor = true;
            this.btnCertSelect.Click += new System.EventHandler(this.btnCertSelect_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(320, 140);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(75, 23);
            this.btnCreate.TabIndex = 0;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // MainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 378);
            this.Controls.Add(this.saveBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtC);
            this.Controls.Add(this.txtL);
            this.Controls.Add(this.txtS);
            this.Controls.Add(this.txtOU);
            this.Controls.Add(this.txtO);
            this.Controls.Add(this.txtCN);
            this.Controls.Add(this.menu1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menu1;
            this.MaximizeBox = false;
            this.Name = "MainFrm";
            this.Text = "Free Certificate Authority";
            this.menu1.ResumeLayout(false);
            this.menu1.PerformLayout();
            this.saveBox1.ResumeLayout(false);
            this.saveBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportCAToolStripMenuItem;
        private System.Windows.Forms.TextBox txtCN;
        private System.Windows.Forms.TextBox txtO;
        private System.Windows.Forms.TextBox txtOU;
        private System.Windows.Forms.TextBox txtS;
        private System.Windows.Forms.TextBox txtL;
        private System.Windows.Forms.TextBox txtC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox saveBox1;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Button btnPkeySelect;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnCertSelect;
        private System.Windows.Forms.TextBox txtCertLoc;
        private System.Windows.Forms.TextBox txtKeyLoc;
    }
}

