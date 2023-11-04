
namespace RockPaperScissors.View
{
    partial class BotField
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BotField));
            this.rock = new System.Windows.Forms.Button();
            this.paper = new System.Windows.Forms.Button();
            this.scissors = new System.Windows.Forms.Button();
            this.vs = new System.Windows.Forms.Label();
            this.EnemyScore = new System.Windows.Forms.Label();
            this.PlayerScore = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.BotChoiceImage = new System.Windows.Forms.PictureBox();
            this.PlayerChoicePicture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BotChoiceImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerChoicePicture)).BeginInit();
            this.SuspendLayout();
            // 
            // rock
            // 
            this.rock.Image = global::RockPaperScissors.Properties.Resources.roc;
            this.rock.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.rock.ImageKey = "(none)";
            this.rock.Location = new System.Drawing.Point(13, 18);
            this.rock.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rock.Name = "rock";
            this.rock.Size = new System.Drawing.Size(256, 197);
            this.rock.TabIndex = 0;
            this.rock.Text = "Rock";
            this.rock.UseVisualStyleBackColor = true;
            this.rock.Click += new System.EventHandler(this.rock_Click);
            // 
            // paper
            // 
            this.paper.Image = global::RockPaperScissors.Properties.Resources.Paper;
            this.paper.Location = new System.Drawing.Point(18, 229);
            this.paper.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.paper.Name = "paper";
            this.paper.Size = new System.Drawing.Size(256, 197);
            this.paper.TabIndex = 1;
            this.paper.Text = "Paper";
            this.paper.UseVisualStyleBackColor = true;
            this.paper.Click += new System.EventHandler(this.paper_Click);
            // 
            // scissors
            // 
            this.scissors.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("scissors.BackgroundImage")));
            this.scissors.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.scissors.Location = new System.Drawing.Point(18, 435);
            this.scissors.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.scissors.Name = "scissors";
            this.scissors.Size = new System.Drawing.Size(256, 197);
            this.scissors.TabIndex = 2;
            this.scissors.Text = "Scissors";
            this.scissors.UseVisualStyleBackColor = true;
            this.scissors.Click += new System.EventHandler(this.scissors_Click);
            // 
            // vs
            // 
            this.vs.AutoSize = true;
            this.vs.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.vs.Location = new System.Drawing.Point(729, 18);
            this.vs.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.vs.Name = "vs";
            this.vs.Size = new System.Drawing.Size(24, 35);
            this.vs.TabIndex = 21;
            this.vs.Text = ":";
            // 
            // EnemyScore
            // 
            this.EnemyScore.AutoSize = true;
            this.EnemyScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.EnemyScore.Location = new System.Drawing.Point(878, 23);
            this.EnemyScore.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.EnemyScore.Name = "EnemyScore";
            this.EnemyScore.Size = new System.Drawing.Size(32, 35);
            this.EnemyScore.TabIndex = 20;
            this.EnemyScore.Text = "0";
            // 
            // PlayerScore
            // 
            this.PlayerScore.AutoSize = true;
            this.PlayerScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.PlayerScore.Location = new System.Drawing.Point(510, 23);
            this.PlayerScore.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PlayerScore.Name = "PlayerScore";
            this.PlayerScore.Size = new System.Drawing.Size(32, 35);
            this.PlayerScore.TabIndex = 19;
            this.PlayerScore.Text = "0";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(660, 229);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(182, 197);
            this.pictureBox3.TabIndex = 18;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // BotChoiceImage
            // 
            this.BotChoiceImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BotChoiceImage.Location = new System.Drawing.Point(884, 262);
            this.BotChoiceImage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BotChoiceImage.Name = "BotChoiceImage";
            this.BotChoiceImage.Size = new System.Drawing.Size(182, 145);
            this.BotChoiceImage.TabIndex = 17;
            this.BotChoiceImage.TabStop = false;
            // 
            // PlayerChoicePicture
            // 
            this.PlayerChoicePicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PlayerChoicePicture.Location = new System.Drawing.Point(434, 262);
            this.PlayerChoicePicture.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PlayerChoicePicture.Name = "PlayerChoicePicture";
            this.PlayerChoicePicture.Size = new System.Drawing.Size(182, 145);
            this.PlayerChoicePicture.TabIndex = 16;
            this.PlayerChoicePicture.TabStop = false;
            // 
            // BotField
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.vs);
            this.Controls.Add(this.EnemyScore);
            this.Controls.Add(this.PlayerScore);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.BotChoiceImage);
            this.Controls.Add(this.PlayerChoicePicture);
            this.Controls.Add(this.scissors);
            this.Controls.Add(this.paper);
            this.Controls.Add(this.rock);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "BotField";
            this.Text = "BotField";
            this.Load += new System.EventHandler(this.BotField_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BotChoiceImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerChoicePicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button rock;
        private System.Windows.Forms.Button paper;
        private System.Windows.Forms.Button scissors;
        private System.Windows.Forms.Label vs;
        private System.Windows.Forms.Label EnemyScore;
        private System.Windows.Forms.Label PlayerScore;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox BotChoiceImage;
        private System.Windows.Forms.PictureBox PlayerChoicePicture;
    }
}