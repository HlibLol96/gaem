using RockPaperScissors.Models;
using RockPaperScissors.View;
using System; 

namespace RockPaperScissors.Presenters
{
     public class BotFieldPresenter
    {
        private GameLogic _model = new GameLogic();
        private IBotField _view;
        public BotFieldPresenter(IBotField view)
        {
            _view = view;
            _view.PaperClickEvent += Click;
            _view.ScissorsClickEvent += Click;
            _view.RockClickEvent += Click;
        }

        private void Click()
        {
            _model.PlayerChoice = _view.PlayerChoice;
            _view.DrawBotStep(_model.BotStep());
            _view.WinAdd(_model.PlayerWin());
        }
    }
}
