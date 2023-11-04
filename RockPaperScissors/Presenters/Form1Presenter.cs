using RockPaperScissors.Models;
using RockPaperScissors.View;
namespace RockPaperScissors.Presenters
{
    class Form1Presenter
    {
        private GameLogic _model = new GameLogic();
        private IForm1 _view;
       

        public Form1Presenter(IForm1 view)
        {
            _view = view;
        }
    }
}
