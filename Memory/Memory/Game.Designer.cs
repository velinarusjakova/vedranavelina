namespace Memory
{
    partial class Game
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
            this.medium = new System.Windows.Forms.Button();
            this.easy = new System.Windows.Forms.Button();
            this.hard = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // medium
            // 
            this.medium.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.medium.Location = new System.Drawing.Point(76, 102);
            this.medium.Name = "medium";
            this.medium.Size = new System.Drawing.Size(137, 50);
            this.medium.TabIndex = 0;
            this.medium.Text = "ПОСТДИПЛОМСКИ";
            this.medium.UseVisualStyleBackColor = true;
            this.medium.Click += new System.EventHandler(this.medium_Click);
            // 
            // easy
            // 
            this.easy.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.easy.ForeColor = System.Drawing.Color.Black;
            this.easy.Location = new System.Drawing.Point(76, 27);
            this.easy.Name = "easy";
            this.easy.Size = new System.Drawing.Size(137, 50);
            this.easy.TabIndex = 1;
            this.easy.Text = "ДОДИПЛОМСКИ";
            this.easy.UseVisualStyleBackColor = true;
            this.easy.Click += new System.EventHandler(this.button2_Click);
            // 
            // hard
            // 
            this.hard.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.hard.Location = new System.Drawing.Point(76, 179);
            this.hard.Name = "hard";
            this.hard.Size = new System.Drawing.Size(137, 50);
            this.hard.TabIndex = 2;
            this.hard.Text = "ДОКТОРСКИ";
            this.hard.UseVisualStyleBackColor = true;
            this.hard.Click += new System.EventHandler(this.hard_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(76, 256);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 50);
            this.button1.TabIndex = 3;
            this.button1.Text = "lvl  Asian";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(278, 344);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.hard);
            this.Controls.Add(this.easy);
            this.Controls.Add(this.medium);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Game";
            this.Text = "Game";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button medium;
        private System.Windows.Forms.Button easy;
        private System.Windows.Forms.Button hard;
        private System.Windows.Forms.Button button1;
    }
}