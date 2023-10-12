﻿namespace ColorMixerApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            redBox = new PictureBox();
            greenBox = new PictureBox();
            blueBox = new PictureBox();
            numericRed = new NumericUpDown();
            numericGreen = new NumericUpDown();
            numericBlue = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)redBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)greenBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)blueBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericRed).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericGreen).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericBlue).BeginInit();
            SuspendLayout();
            // 
            // redBox
            // 
            redBox.BackColor = SystemColors.Control;
            redBox.Location = new Point(98, 96);
            redBox.Name = "redBox";
            redBox.Size = new Size(250, 250);
            redBox.TabIndex = 0;
            redBox.TabStop = false;
            // 
            // greenBox
            // 
            greenBox.BackColor = SystemColors.Control;
            greenBox.Location = new Point(399, 96);
            greenBox.Name = "greenBox";
            greenBox.Size = new Size(250, 250);
            greenBox.TabIndex = 1;
            greenBox.TabStop = false;
            // 
            // blueBox
            // 
            blueBox.BackColor = SystemColors.Control;
            blueBox.Location = new Point(704, 96);
            blueBox.Name = "blueBox";
            blueBox.Size = new Size(250, 250);
            blueBox.TabIndex = 2;
            blueBox.TabStop = false;
            // 
            // numericRed
            // 
            numericRed.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            numericRed.Location = new Point(98, 389);
            numericRed.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            numericRed.Name = "numericRed";
            numericRed.Size = new Size(250, 50);
            numericRed.TabIndex = 3;
            numericRed.ValueChanged += numericRed_ValueChanged;
            // 
            // numericGreen
            // 
            numericGreen.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            numericGreen.Location = new Point(399, 389);
            numericGreen.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            numericGreen.Name = "numericGreen";
            numericGreen.Size = new Size(250, 50);
            numericGreen.TabIndex = 4;
            numericGreen.ValueChanged += numericGreen_ValueChanged;
            // 
            // numericBlue
            // 
            numericBlue.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            numericBlue.Location = new Point(704, 389);
            numericBlue.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            numericBlue.Name = "numericBlue";
            numericBlue.Size = new Size(250, 50);
            numericBlue.TabIndex = 5;
            numericBlue.ValueChanged += numericBlue_ValueChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1151, 756);
            Controls.Add(numericBlue);
            Controls.Add(numericGreen);
            Controls.Add(numericRed);
            Controls.Add(blueBox);
            Controls.Add(greenBox);
            Controls.Add(redBox);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)redBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)greenBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)blueBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericRed).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericGreen).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericBlue).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox redBox;
        private PictureBox greenBox;
        private PictureBox blueBox;
        private NumericUpDown numericRed;
        private NumericUpDown numericGreen;
        private NumericUpDown numericBlue;
    }
}