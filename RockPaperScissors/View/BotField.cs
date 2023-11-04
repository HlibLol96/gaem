using RockPaperScissors.Models;
using RockPaperScissors.Models.Common.Enums;
using RockPaperScissors.Properties;
using System;
using System.Windows.Forms;
namespace RockPaperScissors.View
{
    public partial class BotField : Form, IBotField
    {
        public event Action RockClickEvent;
        public event Action PaperClickEvent;
        public event Action ScissorsClickEvent;
        public GameEnum PlayerChoice { get; set; }
        public GameEnum EnemyChoice { get; set; }
        private int playerCount = 0;
        private int enemyCount = 0;
            public BotField()
        {
            InitializeComponent();
        }
        public void ShowScore()
        {
            PlayerScore.Text = playerCount.ToString();
            EnemyScore.Text = enemyCount.ToString();
        }
        public void WinAdd(WinCondition condition)
        {
            switch (condition)
            {
                case WinCondition.WIN:
                   pictureBox3.Image = Resources.win;
                    playerCount++;
                    break;
                case WinCondition.DRAW:
                   pictureBox3.Image = Resources.draw;
                    break;
                case WinCondition.LOSE:
                   pictureBox3.Image = Resources.lose;
                    enemyCount++;
                    break;
            }
            ShowScore();
        }
      
        public void DrawBotStep(GameEnum step)
        {
            switch (step)
            {
                case GameEnum.PAPER:
                    BotChoiceImage.Image = Resources.Paper;
                    break;
                case GameEnum.ROCK:
                    BotChoiceImage.Image = Resources.roc;
                    break;
                case GameEnum.SCISSORS:
                    BotChoiceImage.Image = Resources.Scissors;
                    break;

            }
        }
       

        private void paper_Click(object sender, EventArgs e)
        {
            PlayerChoice = GameEnum.PAPER;
            PlayerChoicePicture.Image = Resources.Paper;
            PaperClickEvent?.Invoke();
        }
        private void rock_Click(object sender, EventArgs e)
        {
            PlayerChoice = GameEnum.ROCK;
            PlayerChoicePicture.Image = Resources.roc;
            RockClickEvent?.Invoke();
        }
        private void scissors_Click(object sender, EventArgs e)
        {
            PlayerChoice = GameEnum.SCISSORS;
            PlayerChoicePicture.Image = Resources.Scissors;
            ScissorsClickEvent?.Invoke();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void BotField_Load(object sender, EventArgs e)
        {

        }
    }
}
