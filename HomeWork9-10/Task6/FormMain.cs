using System;
using System.Windows.Forms;

namespace Task6
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            buttonStartGame.Click += ButtonStartGame_Click;
         }

        private void ButtonStartGame_Click(object sender, EventArgs e)
        {
            Casino casino = new Casino(new Random().Next(20,101));
            casino.LogInfo += Casino_LogInfo;
            casino.InfoCountPlayer += Casino_InfoCountPlayer;
            casino.EndGame += Casino_EndGame;
            labelInfo.Text = $"Число игроковcasino {casino.players.Count}";
            casino.players.ForEach(user => user.thread.Start(user));
        }

        private void Casino_EndGame()
        {
            throw new NotImplementedException();
        }

        private void Casino_InfoCountPlayer(string infoPlayerCount)
        {
            Action action = () => { labelInfo.Text = infoPlayerCount; };
            this.InvokeEx(action);
        }

        private void Casino_LogInfo(string info)
        {
            Action action = () => { listBoxPlayerLog.Items.Add(info); };
            this.InvokeEx(action);
        }
    }
}
