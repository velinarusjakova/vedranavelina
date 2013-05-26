namespace Memory
{
    partial class Form2
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
            this.lblTimeLeft = new System.Windows.Forms.Label();
            this.button12 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.играToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.новаИграToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.крајToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTimeLeft
            // 
            this.lblTimeLeft.AutoSize = true;
            this.lblTimeLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTimeLeft.Location = new System.Drawing.Point(515, 0);
            this.lblTimeLeft.Name = "lblTimeLeft";
            this.lblTimeLeft.Size = new System.Drawing.Size(71, 25);
            this.lblTimeLeft.TabIndex = 35;
            this.lblTimeLeft.Text = "02:00";
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(470, 300);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(116, 110);
            this.button12.TabIndex = 30;
            this.button12.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(325, 300);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(116, 110);
            this.button11.TabIndex = 29;
            this.button11.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(175, 300);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(116, 110);
            this.button10.TabIndex = 28;
            this.button10.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(20, 300);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(116, 110);
            this.button9.TabIndex = 27;
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(470, 172);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(116, 110);
            this.button8.TabIndex = 26;
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(325, 172);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(116, 110);
            this.button7.TabIndex = 25;
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button6.Location = new System.Drawing.Point(175, 172);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(116, 110);
            this.button6.TabIndex = 24;
            this.button6.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button5
            // 
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button5.Location = new System.Drawing.Point(20, 172);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(116, 110);
            this.button5.TabIndex = 23;
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button4.Location = new System.Drawing.Point(470, 40);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(116, 110);
            this.button4.TabIndex = 22;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // играToolStripMenuItem
            // 
            this.играToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.новаИграToolStripMenuItem,
            this.крајToolStripMenuItem});
            this.играToolStripMenuItem.Name = "играToolStripMenuItem";
            this.играToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.играToolStripMenuItem.Text = "Игра";
            // 
            // новаИграToolStripMenuItem
            // 
            this.новаИграToolStripMenuItem.Name = "новаИграToolStripMenuItem";
            this.новаИграToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.новаИграToolStripMenuItem.Text = "Нова игра";
            this.новаИграToolStripMenuItem.Click += new System.EventHandler(this.новаИграToolStripMenuItem_Click);
            // 
            // крајToolStripMenuItem
            // 
            this.крајToolStripMenuItem.Name = "крајToolStripMenuItem";
            this.крајToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.крајToolStripMenuItem.Text = "Крај";
            this.крајToolStripMenuItem.Click += new System.EventHandler(this.крајToolStripMenuItem_Click);
            // 
            // button3
            // 
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button3.Location = new System.Drawing.Point(325, 40);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(116, 110);
            this.button3.TabIndex = 21;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button2.Location = new System.Drawing.Point(175, 40);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(116, 110);
            this.button2.TabIndex = 20;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Location = new System.Drawing.Point(20, 40);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 110);
            this.button1.TabIndex = 19;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.играToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(606, 24);
            this.menuStrip1.TabIndex = 18;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Memory.Properties.Resources.pozadina;
            this.ClientSize = new System.Drawing.Size(606, 421);
            this.Controls.Add(this.lblTimeLeft);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form2";
            this.Text = "Form2";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTimeLeft;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ToolStripMenuItem играToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem новаИграToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem крајToolStripMenuItem;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MenuStrip menuStrip1;


    }
}