namespace WindowsFormUI
{
    partial class FormMain
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
            this.fbdSource = new System.Windows.Forms.FolderBrowserDialog();
            this.tbxSourceDirectory = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.btnGenerateNP = new System.Windows.Forms.Button();
            this.tbxPackageName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblHint = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnGenerateHeadNP = new System.Windows.Forms.Button();
            this.btnGenerateSinNP = new System.Windows.Forms.Button();
            this.ofdGRP = new System.Windows.Forms.OpenFileDialog();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBrowseGRP = new System.Windows.Forms.Button();
            this.tbxGRPPath = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnBrowseAllDef = new System.Windows.Forms.Button();
            this.tbxAllDefPath = new System.Windows.Forms.TextBox();
            this.btnGenerateWorldNP = new System.Windows.Forms.Button();
            this.btnGenerateBattleNP = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnBrowseWarfGRP = new System.Windows.Forms.Button();
            this.tbxWarfGRPPath = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnBrowseRanger = new System.Windows.Forms.Button();
            this.tbxRangerGRPPath = new System.Windows.Forms.TextBox();
            this.btnGenerateRangerNP = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbxSourceDirectory
            // 
            this.tbxSourceDirectory.Location = new System.Drawing.Point(130, 15);
            this.tbxSourceDirectory.Name = "tbxSourceDirectory";
            this.tbxSourceDirectory.ReadOnly = true;
            this.tbxSourceDirectory.Size = new System.Drawing.Size(161, 20);
            this.tbxSourceDirectory.TabIndex = 0;
            // 
            // btnBrowse
            // 
            this.btnBrowse.AutoSize = true;
            this.btnBrowse.Location = new System.Drawing.Point(311, 13);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(52, 23);
            this.btnBrowse.TabIndex = 1;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // btnGenerateNP
            // 
            this.btnGenerateNP.AutoSize = true;
            this.btnGenerateNP.Location = new System.Drawing.Point(26, 315);
            this.btnGenerateNP.Name = "btnGenerateNP";
            this.btnGenerateNP.Size = new System.Drawing.Size(79, 23);
            this.btnGenerateNP.TabIndex = 2;
            this.btnGenerateNP.Text = "Generate NP";
            this.btnGenerateNP.UseVisualStyleBackColor = true;
            this.btnGenerateNP.Click += new System.EventHandler(this.btnGenerateNP_Click);
            // 
            // tbxPackageName
            // 
            this.tbxPackageName.Location = new System.Drawing.Point(192, 279);
            this.tbxPackageName.MaxLength = 10;
            this.tbxPackageName.Name = "tbxPackageName";
            this.tbxPackageName.Size = new System.Drawing.Size(100, 20);
            this.tbxPackageName.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 282);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Package name : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Source directory : ";
            // 
            // lblHint
            // 
            this.lblHint.AutoSize = true;
            this.lblHint.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblHint.Location = new System.Drawing.Point(0, 0);
            this.lblHint.Name = "lblHint";
            this.lblHint.Size = new System.Drawing.Size(26, 13);
            this.lblHint.TabIndex = 6;
            this.lblHint.Text = "Hint";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblHint);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 459);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(384, 74);
            this.panel1.TabIndex = 7;
            // 
            // btnGenerateHeadNP
            // 
            this.btnGenerateHeadNP.AutoSize = true;
            this.btnGenerateHeadNP.Location = new System.Drawing.Point(131, 315);
            this.btnGenerateHeadNP.Name = "btnGenerateHeadNP";
            this.btnGenerateHeadNP.Size = new System.Drawing.Size(108, 23);
            this.btnGenerateHeadNP.TabIndex = 8;
            this.btnGenerateHeadNP.Text = "Generate Head NP";
            this.btnGenerateHeadNP.UseVisualStyleBackColor = true;
            this.btnGenerateHeadNP.Click += new System.EventHandler(this.btnGenerateHeadNP_Click);
            // 
            // btnGenerateSinNP
            // 
            this.btnGenerateSinNP.AutoSize = true;
            this.btnGenerateSinNP.Location = new System.Drawing.Point(267, 315);
            this.btnGenerateSinNP.Name = "btnGenerateSinNP";
            this.btnGenerateSinNP.Size = new System.Drawing.Size(97, 23);
            this.btnGenerateSinNP.TabIndex = 9;
            this.btnGenerateSinNP.Text = "Generate Sin NP";
            this.btnGenerateSinNP.UseVisualStyleBackColor = true;
            this.btnGenerateSinNP.Click += new System.EventHandler(this.btnGenerateSinNP_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "sin grp directory : ";
            // 
            // btnBrowseGRP
            // 
            this.btnBrowseGRP.AutoSize = true;
            this.btnBrowseGRP.Location = new System.Drawing.Point(311, 46);
            this.btnBrowseGRP.Name = "btnBrowseGRP";
            this.btnBrowseGRP.Size = new System.Drawing.Size(52, 23);
            this.btnBrowseGRP.TabIndex = 11;
            this.btnBrowseGRP.Text = "Browse";
            this.btnBrowseGRP.UseVisualStyleBackColor = true;
            this.btnBrowseGRP.Click += new System.EventHandler(this.btnBrowseGRP_Click);
            // 
            // tbxGRPPath
            // 
            this.tbxGRPPath.Location = new System.Drawing.Point(130, 48);
            this.tbxGRPPath.Name = "tbxGRPPath";
            this.tbxGRPPath.ReadOnly = true;
            this.tbxGRPPath.Size = new System.Drawing.Size(161, 20);
            this.tbxGRPPath.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "def grp directory : ";
            // 
            // btnBrowseAllDef
            // 
            this.btnBrowseAllDef.AutoSize = true;
            this.btnBrowseAllDef.Location = new System.Drawing.Point(311, 82);
            this.btnBrowseAllDef.Name = "btnBrowseAllDef";
            this.btnBrowseAllDef.Size = new System.Drawing.Size(52, 23);
            this.btnBrowseAllDef.TabIndex = 14;
            this.btnBrowseAllDef.Text = "Browse";
            this.btnBrowseAllDef.UseVisualStyleBackColor = true;
            this.btnBrowseAllDef.Click += new System.EventHandler(this.btnBrowseAllDef_Click);
            // 
            // tbxAllDefPath
            // 
            this.tbxAllDefPath.Location = new System.Drawing.Point(130, 84);
            this.tbxAllDefPath.Name = "tbxAllDefPath";
            this.tbxAllDefPath.ReadOnly = true;
            this.tbxAllDefPath.Size = new System.Drawing.Size(161, 20);
            this.tbxAllDefPath.TabIndex = 13;
            // 
            // btnGenerateWorldNP
            // 
            this.btnGenerateWorldNP.AutoSize = true;
            this.btnGenerateWorldNP.Location = new System.Drawing.Point(28, 361);
            this.btnGenerateWorldNP.Name = "btnGenerateWorldNP";
            this.btnGenerateWorldNP.Size = new System.Drawing.Size(110, 23);
            this.btnGenerateWorldNP.TabIndex = 16;
            this.btnGenerateWorldNP.Text = "Generate Wrold NP";
            this.btnGenerateWorldNP.UseVisualStyleBackColor = true;
            this.btnGenerateWorldNP.Click += new System.EventHandler(this.btnGenerateWorldNP_Click);
            // 
            // btnGenerateBattleNP
            // 
            this.btnGenerateBattleNP.AutoSize = true;
            this.btnGenerateBattleNP.Location = new System.Drawing.Point(192, 361);
            this.btnGenerateBattleNP.Name = "btnGenerateBattleNP";
            this.btnGenerateBattleNP.Size = new System.Drawing.Size(109, 23);
            this.btnGenerateBattleNP.TabIndex = 17;
            this.btnGenerateBattleNP.Text = "Generate Battle NP";
            this.btnGenerateBattleNP.UseVisualStyleBackColor = true;
            this.btnGenerateBattleNP.Click += new System.EventHandler(this.btnGenerateBattleNP_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "warf grp directory : ";
            // 
            // btnBrowseWarfGRP
            // 
            this.btnBrowseWarfGRP.AutoSize = true;
            this.btnBrowseWarfGRP.Location = new System.Drawing.Point(312, 119);
            this.btnBrowseWarfGRP.Name = "btnBrowseWarfGRP";
            this.btnBrowseWarfGRP.Size = new System.Drawing.Size(52, 23);
            this.btnBrowseWarfGRP.TabIndex = 19;
            this.btnBrowseWarfGRP.Text = "Browse";
            this.btnBrowseWarfGRP.UseVisualStyleBackColor = true;
            this.btnBrowseWarfGRP.Click += new System.EventHandler(this.btnBrowseWarfGRP_Click);
            // 
            // tbxWarfGRPPath
            // 
            this.tbxWarfGRPPath.Location = new System.Drawing.Point(131, 121);
            this.tbxWarfGRPPath.Name = "tbxWarfGRPPath";
            this.tbxWarfGRPPath.ReadOnly = true;
            this.tbxWarfGRPPath.Size = new System.Drawing.Size(161, 20);
            this.tbxWarfGRPPath.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 165);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "ranger grp directory : ";
            // 
            // btnBrowseRanger
            // 
            this.btnBrowseRanger.AutoSize = true;
            this.btnBrowseRanger.Location = new System.Drawing.Point(312, 160);
            this.btnBrowseRanger.Name = "btnBrowseRanger";
            this.btnBrowseRanger.Size = new System.Drawing.Size(52, 23);
            this.btnBrowseRanger.TabIndex = 22;
            this.btnBrowseRanger.Text = "Browse";
            this.btnBrowseRanger.UseVisualStyleBackColor = true;
            this.btnBrowseRanger.Click += new System.EventHandler(this.btnBrowseRanger_Click);
            // 
            // tbxRangerGRPPath
            // 
            this.tbxRangerGRPPath.Location = new System.Drawing.Point(131, 162);
            this.tbxRangerGRPPath.Name = "tbxRangerGRPPath";
            this.tbxRangerGRPPath.ReadOnly = true;
            this.tbxRangerGRPPath.Size = new System.Drawing.Size(161, 20);
            this.tbxRangerGRPPath.TabIndex = 21;
            // 
            // btnGenerateRangerNP
            // 
            this.btnGenerateRangerNP.AutoSize = true;
            this.btnGenerateRangerNP.Location = new System.Drawing.Point(29, 407);
            this.btnGenerateRangerNP.Name = "btnGenerateRangerNP";
            this.btnGenerateRangerNP.Size = new System.Drawing.Size(117, 23);
            this.btnGenerateRangerNP.TabIndex = 24;
            this.btnGenerateRangerNP.Text = "Generate Ranger NP";
            this.btnGenerateRangerNP.UseVisualStyleBackColor = true;
            this.btnGenerateRangerNP.Click += new System.EventHandler(this.btnGenerateRangerNP_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 533);
            this.Controls.Add(this.btnGenerateRangerNP);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnBrowseRanger);
            this.Controls.Add(this.tbxRangerGRPPath);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnBrowseWarfGRP);
            this.Controls.Add(this.tbxWarfGRPPath);
            this.Controls.Add(this.btnGenerateBattleNP);
            this.Controls.Add(this.btnGenerateWorldNP);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnBrowseAllDef);
            this.Controls.Add(this.tbxAllDefPath);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnBrowseGRP);
            this.Controls.Add(this.tbxGRPPath);
            this.Controls.Add(this.btnGenerateSinNP);
            this.Controls.Add(this.btnGenerateHeadNP);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxPackageName);
            this.Controls.Add(this.btnGenerateNP);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.tbxSourceDirectory);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMain";
            this.Text = "Ning Operator";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog fbdSource;
        private System.Windows.Forms.TextBox tbxSourceDirectory;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Button btnGenerateNP;
        private System.Windows.Forms.TextBox tbxPackageName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblHint;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnGenerateHeadNP;
        private System.Windows.Forms.Button btnGenerateSinNP;
        private System.Windows.Forms.OpenFileDialog ofdGRP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnBrowseGRP;
        private System.Windows.Forms.TextBox tbxGRPPath;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnBrowseAllDef;
        private System.Windows.Forms.TextBox tbxAllDefPath;
        private System.Windows.Forms.Button btnGenerateWorldNP;
        private System.Windows.Forms.Button btnGenerateBattleNP;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnBrowseWarfGRP;
        private System.Windows.Forms.TextBox tbxWarfGRPPath;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnBrowseRanger;
        private System.Windows.Forms.TextBox tbxRangerGRPPath;
        private System.Windows.Forms.Button btnGenerateRangerNP;
    }
}

