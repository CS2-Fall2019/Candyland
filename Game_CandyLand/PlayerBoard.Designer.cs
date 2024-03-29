﻿namespace Game_CandyLand
{
    partial class PlayerBoard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlayerBoard));
            this.GameBoard_picbox = new System.Windows.Forms.PictureBox();
            this.Draw_btn = new System.Windows.Forms.Button();
            this.Start_btn = new System.Windows.Forms.Button();
            this.outputlog_lbl = new System.Windows.Forms.Label();
            this.Exit_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GameBoard_picbox)).BeginInit();
            this.SuspendLayout();
            // 
            // GameBoard_picbox
            // 
            this.GameBoard_picbox.Image = ((System.Drawing.Image)(resources.GetObject("GameBoard_picbox.Image")));
            this.GameBoard_picbox.Location = new System.Drawing.Point(8, 9);
            this.GameBoard_picbox.Margin = new System.Windows.Forms.Padding(2);
            this.GameBoard_picbox.MaximumSize = new System.Drawing.Size(1211, 882);
            this.GameBoard_picbox.MinimumSize = new System.Drawing.Size(1211, 882);
            this.GameBoard_picbox.Name = "GameBoard_picbox";
            this.GameBoard_picbox.Size = new System.Drawing.Size(1211, 882);
            this.GameBoard_picbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.GameBoard_picbox.TabIndex = 0;
            this.GameBoard_picbox.TabStop = false;
            this.GameBoard_picbox.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Draw_btn
            // 
            this.Draw_btn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Draw_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Draw_btn.Font = new System.Drawing.Font("Showcard Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Draw_btn.ForeColor = System.Drawing.Color.HotPink;
            this.Draw_btn.Location = new System.Drawing.Point(150, 895);
            this.Draw_btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Draw_btn.Name = "Draw_btn";
            this.Draw_btn.Size = new System.Drawing.Size(105, 45);
            this.Draw_btn.TabIndex = 1;
            this.Draw_btn.Text = "Draw Card";
            this.Draw_btn.UseVisualStyleBackColor = false;
            // 
            // Start_btn
            // 
            this.Start_btn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Start_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Start_btn.Font = new System.Drawing.Font("Showcard Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Start_btn.ForeColor = System.Drawing.Color.HotPink;
            this.Start_btn.Location = new System.Drawing.Point(8, 908);
            this.Start_btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Start_btn.Name = "Start_btn";
            this.Start_btn.Size = new System.Drawing.Size(67, 31);
            this.Start_btn.TabIndex = 2;
            this.Start_btn.Text = "Start";
            this.Start_btn.UseVisualStyleBackColor = false;
            this.Start_btn.Click += new System.EventHandler(this.Start_btn_Click);
            // 
            // outputlog_lbl
            // 
            this.outputlog_lbl.AutoSize = true;
            this.outputlog_lbl.ForeColor = System.Drawing.Color.LimeGreen;
            this.outputlog_lbl.Location = new System.Drawing.Point(12, 893);
            this.outputlog_lbl.Name = "outputlog_lbl";
            this.outputlog_lbl.Size = new System.Drawing.Size(0, 13);
            this.outputlog_lbl.TabIndex = 3;
            // 
            // Exit_btn
            // 
            this.Exit_btn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Exit_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Exit_btn.Font = new System.Drawing.Font("Showcard Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit_btn.ForeColor = System.Drawing.Color.HotPink;
            this.Exit_btn.Location = new System.Drawing.Point(79, 908);
            this.Exit_btn.Margin = new System.Windows.Forms.Padding(2);
            this.Exit_btn.Name = "Exit_btn";
            this.Exit_btn.Size = new System.Drawing.Size(67, 31);
            this.Exit_btn.TabIndex = 4;
            this.Exit_btn.Text = "Exit";
            this.Exit_btn.UseVisualStyleBackColor = false;
            this.Exit_btn.Click += new System.EventHandler(this.Exit_btn_Click);
            // 
            // PlayerBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1204, 946);
            this.Controls.Add(this.Exit_btn);
            this.Controls.Add(this.outputlog_lbl);
            this.Controls.Add(this.Start_btn);
            this.Controls.Add(this.Draw_btn);
            this.Controls.Add(this.GameBoard_picbox);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(926, 795);
            this.Name = "PlayerBoard";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CandyLand";
            this.Load += new System.EventHandler(this.PlayerBoard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GameBoard_picbox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox GameBoard_picbox;
        private System.Windows.Forms.Button Draw_btn;
        private System.Windows.Forms.Button Start_btn;
        private System.Windows.Forms.Label outputlog_lbl;
        private System.Windows.Forms.Button Exit_btn;
    }
}