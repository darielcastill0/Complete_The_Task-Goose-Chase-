namespace Complete_The_Task_Goose_Chase_
{
    partial class Win_Screen
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
            this.lblWin = new System.Windows.Forms.Label();
            this.btnAgain = new System.Windows.Forms.Button();
            this.picRefresh = new System.Windows.Forms.PictureBox();
            this.picCat = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picRefresh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCat)).BeginInit();
            this.SuspendLayout();
            // 
            // lblWin
            // 
            this.lblWin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblWin.AutoSize = true;
            this.lblWin.Font = new System.Drawing.Font("OCR A Extended", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWin.Location = new System.Drawing.Point(163, 31);
            this.lblWin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblWin.Name = "lblWin";
            this.lblWin.Size = new System.Drawing.Size(862, 100);
            this.lblWin.TabIndex = 66;
            this.lblWin.Text = "You Won! Thanks for playing!\r\n(Created by Dariel Castillo)";
            // 
            // btnAgain
            // 
            this.btnAgain.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAgain.Font = new System.Drawing.Font("OCR A Extended", 20.25F, System.Drawing.FontStyle.Bold);
            this.btnAgain.Location = new System.Drawing.Point(544, 673);
            this.btnAgain.Name = "btnAgain";
            this.btnAgain.Size = new System.Drawing.Size(136, 96);
            this.btnAgain.TabIndex = 67;
            this.btnAgain.Text = "Play Again?\r\n";
            this.btnAgain.UseVisualStyleBackColor = true;
            this.btnAgain.Click += new System.EventHandler(this.Again_Click);
            // 
            // picRefresh
            // 
            this.picRefresh.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picRefresh.BackColor = System.Drawing.Color.White;
            this.picRefresh.Image = global::Complete_The_Task_Goose_Chase_.Properties.Resources.free_refresh_icon_3104_thumb;
            this.picRefresh.Location = new System.Drawing.Point(56, 196);
            this.picRefresh.Name = "picRefresh";
            this.picRefresh.Size = new System.Drawing.Size(93, 87);
            this.picRefresh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picRefresh.TabIndex = 68;
            this.picRefresh.TabStop = false;
            this.picRefresh.Click += new System.EventHandler(this.picRefresh_Click);
            this.picRefresh.MouseEnter += new System.EventHandler(this.picRefresh_MouseEnter);
            this.picRefresh.MouseLeave += new System.EventHandler(this.picRefresh_MouseLeave);
            // 
            // picCat
            // 
            this.picCat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picCat.Image = global::Complete_The_Task_Goose_Chase_.Properties.Resources.IMG_7992;
            this.picCat.Location = new System.Drawing.Point(214, 146);
            this.picCat.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.picCat.Name = "picCat";
            this.picCat.Size = new System.Drawing.Size(761, 522);
            this.picCat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCat.TabIndex = 65;
            this.picCat.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("OCR A Extended", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 13);
            this.label1.TabIndex = 69;
            this.label1.Text = "(Click to replay sound)";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("OCR A Extended", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(720, 700);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(413, 37);
            this.label2.TabIndex = 70;
            this.label2.Text = "Answer: Algorithms";
            // 
            // Win_Screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(1188, 817);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.picRefresh);
            this.Controls.Add(this.btnAgain);
            this.Controls.Add(this.lblWin);
            this.Controls.Add(this.picCat);
            this.Controls.Add(this.label1);
            this.Name = "Win_Screen";
            this.Text = "Win_Screen";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Win_Screen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picRefresh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWin;
        private System.Windows.Forms.PictureBox picCat;
        private System.Windows.Forms.Button btnAgain;
        private System.Windows.Forms.PictureBox picRefresh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}