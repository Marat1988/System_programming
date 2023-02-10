using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Task6
{
    public partial class FormStatistic : Form
    {
        public FormStatistic(List<Player> players)
        {
            InitializeComponent();
            var sql = (from game in players
                       select new
                       {
                           Имя_игрока = game.name,
                           Стартовый_Баланс = game.StartMoney,
                           Число_сыгранных_раундов = game.NumberRoundsPlayed,
                           Текущий_Баланс = game.Balance,
                           Прибыль = game.Balance - game.StartMoney
                       }).ToList();
            dataGridViewStatistic.DataSource = sql;
        }
    }
}
