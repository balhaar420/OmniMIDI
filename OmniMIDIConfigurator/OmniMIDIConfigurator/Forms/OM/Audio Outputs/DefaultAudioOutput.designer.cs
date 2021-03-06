﻿namespace OmniMIDIConfigurator{
    partial class DefaultOutput
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
            this.DevicesList = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DefOut = new System.Windows.Forms.Label();
            this.Quit = new System.Windows.Forms.Button();
            this.SwitchDefaultAudio = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // DevicesList
            // 
            this.DevicesList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DevicesList.FormattingEnabled = true;
            this.DevicesList.Location = new System.Drawing.Point(95, 11);
            this.DevicesList.Name = "DevicesList";
            this.DevicesList.Size = new System.Drawing.Size(287, 21);
            this.DevicesList.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Current output:";
            // 
            // DefOut
            // 
            this.DefOut.AutoSize = true;
            this.DefOut.Location = new System.Drawing.Point(12, 41);
            this.DefOut.Name = "DefOut";
            this.DefOut.Size = new System.Drawing.Size(149, 13);
            this.DefOut.TabIndex = 2;
            this.DefOut.Text = "Default Windows output: NaN";
            // 
            // Quit
            // 
            this.Quit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Quit.Location = new System.Drawing.Point(308, 64);
            this.Quit.Name = "Quit";
            this.Quit.Size = new System.Drawing.Size(75, 23);
            this.Quit.TabIndex = 3;
            this.Quit.Text = "OK";
            this.Quit.UseVisualStyleBackColor = true;
            this.Quit.Click += new System.EventHandler(this.Quit_Click);
            // 
            // SwitchDefaultAudio
            // 
            this.SwitchDefaultAudio.AutoSize = true;
            this.SwitchDefaultAudio.Location = new System.Drawing.Point(13, 68);
            this.SwitchDefaultAudio.Name = "SwitchDefaultAudio";
            this.SwitchDefaultAudio.Size = new System.Drawing.Size(221, 17);
            this.SwitchDefaultAudio.TabIndex = 4;
            this.SwitchDefaultAudio.Text = "Switch default audio device automatically";
            this.SwitchDefaultAudio.UseVisualStyleBackColor = true;
            this.SwitchDefaultAudio.CheckedChanged += new System.EventHandler(this.SwitchDefaultAudio_CheckedChanged);
            // 
            // DefaultOutput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(394, 98);
            this.Controls.Add(this.SwitchDefaultAudio);
            this.Controls.Add(this.Quit);
            this.Controls.Add(this.DefOut);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DevicesList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DefaultOutput";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Change default {0} output";
            this.Load += new System.EventHandler(this.DefaultOutput_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox DevicesList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label DefOut;
        private System.Windows.Forms.Button Quit;
        private System.Windows.Forms.CheckBox SwitchDefaultAudio;
    }
}