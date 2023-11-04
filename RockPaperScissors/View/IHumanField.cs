using RockPaperScissors.Models.Common.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors.View
{
    public interface IHumanField
    {
        event Action RockClickEvent;
        event Action PaperClickEvent;
        event Action ScissorsClickEvent;

        event Action EnemyRockClickEvent;
        event Action EnemyPaperClickEvent;
        event Action EnemyScissorsClickEvent;
        GameEnum PlayerChoice { get; set; }
        GameEnum EnemyChoice { get; set; }
        
    }
}
