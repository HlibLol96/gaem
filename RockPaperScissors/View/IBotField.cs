using RockPaperScissors.Models.Common.Enums;
using System;

namespace RockPaperScissors.View
{
    public interface IBotField
    {
        event Action RockClickEvent;
        event Action PaperClickEvent;
        event Action ScissorsClickEvent;
        GameEnum PlayerChoice { get; set; }
        GameEnum EnemyChoice { get; set; }
        void DrawBotStep(GameEnum step);
        void WinAdd(WinCondition condition);
    }
}
