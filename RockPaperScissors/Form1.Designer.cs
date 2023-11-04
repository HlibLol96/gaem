namespace RockPaperScissors
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
            this.bot = new System.Windows.Forms.Button();
            this.human = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bot
            // 
            this.bot.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.bot.Location = new System.Drawing.Point(112, 52);
            this.bot.Name = "bot";
            this.bot.Size = new System.Drawing.Size(235, 90);
            this.bot.TabIndex = 0;
            this.bot.Text = "1 VS 1";
            this.bot.UseVisualStyleBackColor = true;
            this.bot.Click += new System.EventHandler(this.BotStart);
            // 
            // human
            // 
            this.human.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.human.Location = new System.Drawing.Point(112, 222);
            this.human.Name = "human";
            this.human.Size = new System.Drawing.Size(235, 90);
            this.human.TabIndex = 1;
            this.human.Text = "2 VS 2";
            this.human.UseVisualStyleBackColor = true;
            this.human.Click += new System.EventHandler(this.HumanStart);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 450);
            this.Controls.Add(this.human);
            this.Controls.Add(this.bot);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bot;
        private System.Windows.Forms.Button human;
    }
}