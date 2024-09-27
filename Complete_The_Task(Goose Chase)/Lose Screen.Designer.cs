namespace Complete_The_Task_Goose_Chase_
{
    partial class Lose_Screen
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnAgain = new System.Windows.Forms.Button();
            this.picX = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picX)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 26.25F);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(621, 615);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 44);
            this.label1.TabIndex = 66;
            this.label1.Text = "YOU LOSE!";
            // 
            // btnAgain
            // 
            this.btnAgain.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAgain.BackColor = System.Drawing.Color.Black;
            this.btnAgain.Font = new System.Drawing.Font("Showcard Gothic", 26.25F);
            this.btnAgain.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAgain.Location = new System.Drawing.Point(587, 725);
            this.btnAgain.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAgain.Name = "btnAgain";
            this.btnAgain.Size = new System.Drawing.Size(331, 148);
            this.btnAgain.TabIndex = 67;
            this.btnAgain.Text = "Try Again?";
            this.btnAgain.UseVisualStyleBackColor = false;
            this.btnAgain.Click += new System.EventHandler(this.btnAgain_Click);
            // 
            // picX
            // 
            this.picX.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picX.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.picX.Image = global::Complete_The_Task_Goose_Chase_.Properties.Resources.red_x_clipart_xl;
            this.picX.Location = new System.Drawing.Point(244, 30);
            this.picX.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picX.Name = "picX";
            this.picX.Size = new System.Drawing.Size(1017, 565);
            this.picX.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picX.TabIndex = 65;
            this.picX.TabStop = false;
            // 
            // Lose_Screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1505, 1002);
            this.Controls.Add(this.btnAgain);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picX);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Lose_Screen";
            this.Text = "Lose_Screen";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Lose_Screen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picX)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picX;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAgain;
    }
}