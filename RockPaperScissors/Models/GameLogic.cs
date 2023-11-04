using RockPaperScissors.Models.Common.Enums;

namespace RockPaperScissors.Models
{
     public class GameLogic
    {
        private GameEnum playerChoice;
        public GameEnum PlayerChoice
        {
            get => playerChoice;
            set => playerChoice = value;
        }
        private GameEnum enemyChoice;
        Bot bot = new Bot();
        public GameEnum BotStep()
        {
            enemyChoice = bot.Chooser();
            return enemyChoice;
        }
        public WinCondition PlayerWin()
        {
           
            if(playerChoice == GameEnum.PAPER)
            {
                if(enemyChoice == GameEnum.PAPER)
                {
                    return WinCondition.DRAW;
                }
                else if (enemyChoice == GameEnum.ROCK)
                {
                    return WinCondition.WIN;
                }
                else if (enemyChoice == GameEnum.SCISSORS)
                {
                    return WinCondition.LOSE;
                }
            }
            else if (playerChoice == GameEnum.ROCK)
            {
                if (enemyChoice == GameEnum.PAPER)
                {
                    return WinCondition.LOSE;
                }
                else if (enemyChoice == GameEnum.ROCK)
                {
                    return WinCondition.DRAW;
                }
                else if (enemyChoice == GameEnum.SCISSORS)
                {
                    return WinCondition.WIN;
                }
            }
            else if (playerChoice == GameEnum.SCISSORS)
            {
                if (enemyChoice == GameEnum.PAPER)
                {
                    return WinCondition.WIN;
                }
                else if (enemyChoice == GameEnum.ROCK)
                {
                    return WinCondition.LOSE;
                }
                else if (enemyChoice == GameEnum.SCISSORS)
                {
                    return WinCondition.DRAW;
                }
            }
            return WinCondition.LOSE;
        }
    }
}
