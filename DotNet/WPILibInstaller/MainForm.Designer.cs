﻿namespace WPILibInstaller
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.performInstallButton = new System.Windows.Forms.Button();
            this.vscodeCheck = new System.Windows.Forms.CheckBox();
            this.javaCheck = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.vscodeButton = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.gradleCheck = new System.Windows.Forms.CheckBox();
            this.cppCheck = new System.Windows.Forms.CheckBox();
            this.toolsCheck = new System.Windows.Forms.CheckBox();
            this.wpilibCheck = new System.Windows.Forms.CheckBox();
            this.vsCodeWpiExtCheck = new System.Windows.Forms.CheckBox();
            this.vscodeText = new System.Windows.Forms.Label();
            this.vsCodeFileLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            //
            // performInstallButton
            //
            this.performInstallButton.Location = new System.Drawing.Point(22, 567);
            this.performInstallButton.Margin = new System.Windows.Forms.Padding(6);
            this.performInstallButton.Name = "performInstallButton";
            this.performInstallButton.Size = new System.Drawing.Size(667, 44);
            this.performInstallButton.TabIndex = 6;
            this.performInstallButton.Text = "Execute Install";
            this.performInstallButton.UseVisualStyleBackColor = true;
            this.performInstallButton.Visible = false;
            this.performInstallButton.Click += new System.EventHandler(this.performInstallButton_Click);
            //
            // vscodeCheck
            //
            this.vscodeCheck.AutoSize = true;
            this.vscodeCheck.Location = new System.Drawing.Point(21, 162);
            this.vscodeCheck.Margin = new System.Windows.Forms.Padding(6);
            this.vscodeCheck.Name = "vscodeCheck";
            this.vscodeCheck.Size = new System.Drawing.Size(227, 29);
            this.vscodeCheck.TabIndex = 7;
            this.vscodeCheck.Text = "Visual Studio Code";
            this.vscodeCheck.UseVisualStyleBackColor = true;
            this.vscodeCheck.CheckedChanged += new System.EventHandler(this.vscodeCheck_CheckedChanged);
            //
            // javaCheck
            //
            this.javaCheck.AutoSize = true;
            this.javaCheck.Checked = true;
            this.javaCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.javaCheck.Location = new System.Drawing.Point(21, 281);
            this.javaCheck.Margin = new System.Windows.Forms.Padding(6);
            this.javaCheck.Name = "javaCheck";
            this.javaCheck.Size = new System.Drawing.Size(182, 29);
            this.javaCheck.TabIndex = 8;
            this.javaCheck.Text = "Java JDK/JRE";
            this.javaCheck.UseVisualStyleBackColor = true;
            //
            // label1
            //
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(581, 125);
            this.label1.TabIndex = 9;
            this.label1.Text = resources.GetString("label1.Text");
            //
            // vscodeButton
            //
            this.vscodeButton.Enabled = false;
            this.vscodeButton.Location = new System.Drawing.Point(283, 162);
            this.vscodeButton.Margin = new System.Windows.Forms.Padding(6);
            this.vscodeButton.Name = "vscodeButton";
            this.vscodeButton.Size = new System.Drawing.Size(406, 77);
            this.vscodeButton.TabIndex = 10;
            this.vscodeButton.Text = "Select/Download VS Code";
            this.vscodeButton.UseVisualStyleBackColor = true;
            this.vscodeButton.Click += new System.EventHandler(this.vscodeButton_Click);
            //
            // progressBar1
            //
            this.progressBar1.Location = new System.Drawing.Point(26, 612);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(6);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(663, 44);
            this.progressBar1.TabIndex = 11;
            //
            // gradleCheck
            //
            this.gradleCheck.AutoSize = true;
            this.gradleCheck.Checked = true;
            this.gradleCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.gradleCheck.Location = new System.Drawing.Point(22, 240);
            this.gradleCheck.Margin = new System.Windows.Forms.Padding(6);
            this.gradleCheck.Name = "gradleCheck";
            this.gradleCheck.Size = new System.Drawing.Size(108, 29);
            this.gradleCheck.TabIndex = 12;
            this.gradleCheck.Text = "Gradle";
            this.gradleCheck.UseVisualStyleBackColor = true;
            //
            // cppCheck
            //
            this.cppCheck.AutoSize = true;
            this.cppCheck.Checked = true;
            this.cppCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cppCheck.Location = new System.Drawing.Point(21, 199);
            this.cppCheck.Margin = new System.Windows.Forms.Padding(6);
            this.cppCheck.Name = "cppCheck";
            this.cppCheck.Size = new System.Drawing.Size(174, 29);
            this.cppCheck.TabIndex = 13;
            this.cppCheck.Text = "C++ Compiler";
            this.cppCheck.UseVisualStyleBackColor = true;
            //
            // toolsCheck
            //
            this.toolsCheck.AutoSize = true;
            this.toolsCheck.Checked = true;
            this.toolsCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolsCheck.Location = new System.Drawing.Point(23, 450);
            this.toolsCheck.Margin = new System.Windows.Forms.Padding(6);
            this.toolsCheck.Name = "toolsCheck";
            this.toolsCheck.Size = new System.Drawing.Size(215, 29);
            this.toolsCheck.TabIndex = 14;
            this.toolsCheck.Text = "Tools and Utilities";
            this.toolsCheck.UseVisualStyleBackColor = true;
            //
            // wpilibCheck
            //
            this.wpilibCheck.AutoSize = true;
            this.wpilibCheck.Checked = true;
            this.wpilibCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.wpilibCheck.Location = new System.Drawing.Point(23, 491);
            this.wpilibCheck.Margin = new System.Windows.Forms.Padding(6);
            this.wpilibCheck.Name = "wpilibCheck";
            this.wpilibCheck.Size = new System.Drawing.Size(256, 29);
            this.wpilibCheck.TabIndex = 16;
            this.wpilibCheck.Text = "WPILib Dependencies";
            this.wpilibCheck.UseVisualStyleBackColor = true;
            //
            // vsCodeWpiExtCheck
            //
            this.vsCodeWpiExtCheck.AutoSize = true;
            this.vsCodeWpiExtCheck.Checked = true;
            this.vsCodeWpiExtCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.vsCodeWpiExtCheck.Location = new System.Drawing.Point(23, 529);
            this.vsCodeWpiExtCheck.Name = "vsCodeWpiExtCheck";
            this.vsCodeWpiExtCheck.Size = new System.Drawing.Size(339, 29);
            this.vsCodeWpiExtCheck.TabIndex = 18;
            this.vsCodeWpiExtCheck.Text = "Visual Studio Code Extensions";
            this.vsCodeWpiExtCheck.UseVisualStyleBackColor = true;
            //
            // vscodeText
            //
            this.vscodeText.AutoSize = true;
            this.vscodeText.Location = new System.Drawing.Point(278, 262);
            this.vscodeText.Name = "vscodeText";
            this.vscodeText.Size = new System.Drawing.Size(278, 125);
            this.vscodeText.TabIndex = 19;
            this.vscodeText.Text = "Click button above to open\r\ndownloaded VS Code file.\r\nYou can copy the zip file t" +
    "o \r\nanother system if you need.\r\nIt is called:";
            //
            // vsCodeFileLabel
            //
            this.vsCodeFileLabel.AutoSize = true;
            this.vsCodeFileLabel.Location = new System.Drawing.Point(278, 387);
            this.vsCodeFileLabel.Name = "vsCodeFileLabel";
            this.vsCodeFileLabel.Size = new System.Drawing.Size(230, 25);
            this.vsCodeFileLabel.TabIndex = 20;
            this.vsCodeFileLabel.Text = "OfflineVsCodeFiles.zip";
            //
            // MainForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 679);
            this.Controls.Add(this.vsCodeFileLabel);
            this.Controls.Add(this.vscodeText);
            this.Controls.Add(this.vsCodeWpiExtCheck);
            this.Controls.Add(this.wpilibCheck);
            this.Controls.Add(this.toolsCheck);
            this.Controls.Add(this.cppCheck);
            this.Controls.Add(this.gradleCheck);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.vscodeButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.javaCheck);
            this.Controls.Add(this.vscodeCheck);
            this.Controls.Add(this.performInstallButton);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "MainForm";
            this.Text = "WPILib Installer";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button performInstallButton;
        private System.Windows.Forms.CheckBox vscodeCheck;
        private System.Windows.Forms.CheckBox javaCheck;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button vscodeButton;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.CheckBox gradleCheck;
        private System.Windows.Forms.CheckBox cppCheck;
        private System.Windows.Forms.CheckBox toolsCheck;
        private System.Windows.Forms.CheckBox wpilibCheck;
        private System.Windows.Forms.CheckBox vsCodeWpiExtCheck;
        private System.Windows.Forms.Label vscodeText;
        private System.Windows.Forms.Label vsCodeFileLabel;
    }
}

