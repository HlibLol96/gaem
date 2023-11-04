using RockPaperScissors.Models.Common.Enums;
using System;
using System.Windows.Forms;

namespace RockPaperScissors.View
{
    public partial class HumanField : Form, IHumanField
    {

        public event Action RockClickEvent;
        public event Action PaperClickEvent;
        public event Action ScissorsClickEvent;

        public event Action EnemyRockClickEvent;
        public event Action EnemyPaperClickEvent;
        public event Action EnemyScissorsClickEvent;
        public GameEnum PlayerChoice { get; set; }
        public GameEnum EnemyChoice { get; set; }
        private int playerCount = 0;
        private int enemyCounter = 0;

       
        public HumanField()
        {
            InitializeComponent();
        }
        private void paper_Click(object sender, EventArgs e)
        {
            PlayerChoice = GameEnum.PAPER;
            PaperClickEvent?.Invoke();
        }
        private void rock_Click(object sender, EventArgs e)
        {
            PlayerChoice = GameEnum.ROCK;
            RockClickEvent?.Invoke();
        }

        private void scissors_Click(object sender, EventArgs e)
        {
            PlayerChoice = GameEnum.SCISSORS;
            ScissorsClickEvent?.Invoke();
        }
        private void paperEnemy_Click(object sender, EventArgs e)
        {
            EnemyChoice = GameEnum.PAPER;
            EnemyPaperClickEvent?.Invoke();
        }
        private void rockEnemy_Click(object sender, EventArgs e)
        {
            EnemyChoice = GameEnum.ROCK;
            EnemyRockClickEvent?.Invoke();
        }

        private void scissorsEnemy_Click(object sender, EventArgs e)
        {
            EnemyChoice = GameEnum.SCISSORS;
            EnemyScissorsClickEvent?.Invoke();
        }
    }
}
