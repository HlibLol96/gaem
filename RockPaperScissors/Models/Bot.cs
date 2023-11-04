using RockPaperScissors.Models.Common.Enums;
using System;

namespace RockPaperScissors.Models
{
    class Bot
    {
        public GameEnum Chooser() => (GameEnum)new Random().Next(0, 3);
    }
}
