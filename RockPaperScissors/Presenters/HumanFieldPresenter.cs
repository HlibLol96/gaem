using RockPaperScissors.Models;
using RockPaperScissors.View;

namespace RockPaperScissors.Presenters
{

     public class HumanFieldPresenter
    {
        private GameLogic _model = new GameLogic();
        private IHumanField _view;
        public HumanFieldPresenter(IHumanField view)
        {
            _view = view;
            _view.PaperClickEvent+=
        }
  
    }
    
}
