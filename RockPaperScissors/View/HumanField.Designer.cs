
namespace RockPaperScissors.View
{
    partial class HumanField
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HumanField));
            this.scissors = new System.Windows.Forms.Button();
            this.paper = new System.Windows.Forms.Button();
            this.rock = new System.Windows.Forms.Button();
            this.scissors2 = new System.Windows.Forms.Button();
            this.paper2 = new System.Windows.Forms.Button();
            this.rock2 = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.PlayerScore = new System.Windows.Forms.Label();
            this.EnemyScore = new System.Windows.Forms.Label();
            this.vs = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // scissors
            // 
            this.scissors.Image = ((System.Drawing.Image)(resources.GetObject("scissors.Image")));
            this.scissors.Location = new System.Drawing.Point(18, 431);
            this.scissors.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.scissors.Name = "scissors";
            this.scissors.Size = new System.Drawing.Size(256, 197);
            this.scissors.TabIndex = 5;
            this.scissors.Text = "Scissors";
            this.scissors.UseVisualStyleBackColor = true;
            this.scissors.Click += new System.EventHandler(this.scissors_Click);
            // 
            // paper
            // 
            this.paper.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("paper.BackgroundImage")));
            this.paper.Location = new System.Drawing.Point(18, 225);
            this.paper.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.paper.Name = "paper";
            this.paper.Size = new System.Drawing.Size(256, 197);
            this.paper.TabIndex = 4;
            this.paper.Text = "Paper";
            this.paper.UseVisualStyleBackColor = true;
            this.paper.Click += new System.EventHandler(this.paper_Click);
            // 
            // rock
            // 
            this.rock.Image = ((System.Drawing.Image)(resources.GetObject("rock.Image")));
            this.rock.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.rock.Location = new System.Drawing.Point(18, 18);
            this.rock.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rock.Name = "rock";
            this.rock.Size = new System.Drawing.Size(256, 197);
            this.rock.TabIndex = 3;
            this.rock.Text = "Rock";
            this.rock.UseVisualStyleBackColor = true;
            this.rock.Click += new System.EventHandler(this.rock_Click);
            // 
            // scissors2
            // 
            this.scissors2.Image = ((System.Drawing.Image)(resources.GetObject("scissors2.Image")));
            this.scissors2.Location = new System.Drawing.Point(931, 431);
            this.scissors2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.scissors2.Name = "scissors2";
            this.scissors2.Size = new System.Drawing.Size(256, 197);
            this.scissors2.TabIndex = 8;
            this.scissors2.Text = "Scissors";
            this.scissors2.UseVisualStyleBackColor = true;
            this.scissors2.Click += new System.EventHandler(this.scissorsEnemy_Click);
            // 
            // paper2
            // 
            this.paper2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("paper2.BackgroundImage")));
            this.paper2.Location = new System.Drawing.Point(931, 225);
            this.paper2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.paper2.Name = "paper2";
            this.paper2.Size = new System.Drawing.Size(256, 197);
            this.paper2.TabIndex = 7;
            this.paper2.Text = "Paper";
            this.paper2.UseVisualStyleBackColor = true;
            this.paper2.Click += new System.EventHandler(this.paperEnemy_Click);
            // 
            // rock2
            // 
            this.rock2.Image = ((System.Drawing.Image)(resources.GetObject("rock2.Image")));
            this.rock2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.rock2.Location = new System.Drawing.Point(931, 18);
            this.rock2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rock2.Name = "rock2";
            this.rock2.Size = new System.Drawing.Size(256, 197);
            this.rock2.TabIndex = 6;
            this.rock2.Text = "Rock";
            this.rock2.UseVisualStyleBackColor = true;
            this.rock2.Click += new System.EventHandler(this.rockEnemy_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(284, 257);
            this.pictureBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(182, 145);
            this.pictureBox.TabIndex = 9;
            this.pictureBox.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(735, 257);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(182, 145);
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(510, 225);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(182, 197);
            this.pictureBox3.TabIndex = 11;
            this.pictureBox3.TabStop = false;
            // 
            // PlayerScore
            // 
            this.PlayerScore.AutoSize = true;
            this.PlayerScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.PlayerScore.Location = new System.Drawing.Point(434, 18);
            this.PlayerScore.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PlayerScore.Name = "PlayerScore";
            this.PlayerScore.Size = new System.Drawing.Size(32, 35);
            this.PlayerScore.TabIndex = 12;
            this.PlayerScore.Text = "0";
            // 
            // EnemyScore
            // 
            this.EnemyScore.AutoSize = true;
            this.EnemyScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.EnemyScore.Location = new System.Drawing.Point(729, 18);
            this.EnemyScore.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.EnemyScore.Name = "EnemyScore";
            this.EnemyScore.Size = new System.Drawing.Size(32, 35);
            this.EnemyScore.TabIndex = 14;
            this.EnemyScore.Text = "0";
            // 
            // vs
            // 
            this.vs.AutoSize = true;
            this.vs.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.vs.Location = new System.Drawing.Point(585, 18);
            this.vs.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.vs.Name = "vs";
            this.vs.Size = new System.Drawing.Size(24, 35);
            this.vs.TabIndex = 15;
            this.vs.Text = ":";
            // 
            // HumanField
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.vs);
            this.Controls.Add(this.EnemyScore);
            this.Controls.Add(this.PlayerScore);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.scissors2);
            this.Controls.Add(this.paper2);
            this.Controls.Add(this.rock2);
            this.Controls.Add(this.scissors);
            this.Controls.Add(this.paper);
            this.Controls.Add(this.rock);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "HumanField";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button scissors;
        private System.Windows.Forms.Button paper;
        private System.Windows.Forms.Button rock;
        private System.Windows.Forms.Button scissors2;
        private System.Windows.Forms.Button paper2;
        private System.Windows.Forms.Button rock2;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label PlayerScore;
        private System.Windows.Forms.Label EnemyScore;
        private System.Windows.Forms.Label vs;
    }
}