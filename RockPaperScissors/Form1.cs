using RockPaperScissors.Presenters;
using RockPaperScissors.View;
using System;
using System.Windows.Forms;

namespace RockPaperScissors
{
  public partial class Form1 : Form, IForm1 
  {
    public Form1()
    {
      InitializeComponent();
    }

        private void HumanStart(object sender, EventArgs e)
        {
            HumanField human = new HumanField();
            HumanFieldPresenter humanFieldPresenter = new HumanFieldPresenter(human);
            human.ShowDialog();
        }

        private void BotStart(object sender, EventArgs e)
        {
            BotField bot = new BotField();
            BotFieldPresenter botFieldPresenter = new BotFieldPresenter(bot);
            bot.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
