﻿namespace Twitchmote
{
    partial class FormCommands
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
            this.components = new System.ComponentModel.Container();
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelCommands = new System.Windows.Forms.Label();
            this.labelGame = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.labelTimer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Pokemon Pixel Font", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(12, 9);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(82, 18);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Twitchmote";
            // 
            // labelCommands
            // 
            this.labelCommands.AutoSize = true;
            this.labelCommands.Font = new System.Drawing.Font("Pokemon Pixel Font", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCommands.Location = new System.Drawing.Point(12, 45);
            this.labelCommands.Name = "labelCommands";
            this.labelCommands.Size = new System.Drawing.Size(72, 18);
            this.labelCommands.TabIndex = 1;
            this.labelCommands.Text = "commands";
            // 
            // labelGame
            // 
            this.labelGame.AutoSize = true;
            this.labelGame.Font = new System.Drawing.Font("Pokemon Pixel Font", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGame.Location = new System.Drawing.Point(100, 9);
            this.labelGame.Name = "labelGame";
            this.labelGame.Size = new System.Drawing.Size(45, 18);
            this.labelGame.TabIndex = 2;
            this.labelGame.Text = "label1";
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // labelTimer
            // 
            this.labelTimer.AutoSize = true;
            this.labelTimer.Font = new System.Drawing.Font("Pokemon Pixel Font", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTimer.Location = new System.Drawing.Point(12, 27);
            this.labelTimer.Name = "labelTimer";
            this.labelTimer.Size = new System.Drawing.Size(62, 18);
            this.labelTimer.TabIndex = 3;
            this.labelTimer.Text = "0d 0h 0m";
            // 
            // FormCommands
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.labelTimer);
            this.Controls.Add(this.labelGame);
            this.Controls.Add(this.labelCommands);
            this.Controls.Add(this.labelTitle);
            this.ForeColor = System.Drawing.Color.Snow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormCommands";
            this.ShowIcon = false;
            this.Text = "Twitchremote Commands";
            this.Load += new System.EventHandler(this.FormCommands_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelCommands;
        private System.Windows.Forms.Label labelGame;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label labelTimer;
    }
}