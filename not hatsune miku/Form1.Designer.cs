namespace not_hatsune_miku
{
    partial class Form1
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
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.tickLabel = new System.Windows.Forms.Label();
            this.lifeLabel = new System.Windows.Forms.Label();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.skillLabel = new System.Windows.Forms.Label();
            this.comboLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 10;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
            // 
            // tickLabel
            // 
            this.tickLabel.AutoSize = true;
            this.tickLabel.BackColor = System.Drawing.Color.Transparent;
            this.tickLabel.ForeColor = System.Drawing.Color.Black;
            this.tickLabel.Location = new System.Drawing.Point(13, 13);
            this.tickLabel.Name = "tickLabel";
            this.tickLabel.Size = new System.Drawing.Size(0, 16);
            this.tickLabel.TabIndex = 0;
            // 
            // lifeLabel
            // 
            this.lifeLabel.AutoSize = true;
            this.lifeLabel.BackColor = System.Drawing.Color.Transparent;
            this.lifeLabel.Location = new System.Drawing.Point(444, 13);
            this.lifeLabel.Name = "lifeLabel";
            this.lifeLabel.Size = new System.Drawing.Size(44, 16);
            this.lifeLabel.TabIndex = 1;
            this.lifeLabel.Text = "label1";
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.BackColor = System.Drawing.Color.Transparent;
            this.scoreLabel.Location = new System.Drawing.Point(225, 13);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(44, 16);
            this.scoreLabel.TabIndex = 2;
            this.scoreLabel.Text = "label1";
            // 
            // skillLabel
            // 
            this.skillLabel.BackColor = System.Drawing.Color.Transparent;
            this.skillLabel.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.skillLabel.Location = new System.Drawing.Point(180, 293);
            this.skillLabel.Name = "skillLabel";
            this.skillLabel.Size = new System.Drawing.Size(136, 85);
            this.skillLabel.TabIndex = 3;
            this.skillLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboLabel
            // 
            this.comboLabel.AutoSize = true;
            this.comboLabel.BackColor = System.Drawing.Color.Transparent;
            this.comboLabel.Location = new System.Drawing.Point(239, 362);
            this.comboLabel.Name = "comboLabel";
            this.comboLabel.Size = new System.Drawing.Size(44, 16);
            this.comboLabel.TabIndex = 4;
            this.comboLabel.Text = "label1";
            this.comboLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 800);
            this.Controls.Add(this.comboLabel);
            this.Controls.Add(this.skillLabel);
            this.Controls.Add(this.scoreLabel);
            this.Controls.Add(this.lifeLabel);
            this.Controls.Add(this.tickLabel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Label tickLabel;
        private System.Windows.Forms.Label lifeLabel;
        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.Label skillLabel;
        private System.Windows.Forms.Label comboLabel;
    }
}

