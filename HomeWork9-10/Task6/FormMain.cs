using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Task6
{
    public partial class FormMain : Form
    {
        Casino casino;
        public FormMain()
        {
            InitializeComponent();
            buttonStartGame.Click += ButtonStartGame_Click;
            this.FormClosing += FormMain_FormClosing;
         }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (casino?.leftPlayers > 0)
            {
                MessageBox.Show("Еще не все игроки сыграли", "INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                e.Cancel = true;
            }
        }

        private void ButtonStartGame_Click(object sender, EventArgs e)
        {
            listBoxPlayerLog.Items.Clear();
            buttonStartGame.Enabled = false;
            casino = new Casino(new Random().Next(20,101));
            casino.LogInfo += Casino_LogInfo;
            casino.InfoCountPlayer += Casino_InfoCountPlayer;
            casino.EndGame += Casino_EndGame;
            labelInfo.Text = $"Число игроков {casino.players.Count}";
            casino.players.ForEach(user => user.thread.Start(user));
        }

        private void Casino_EndGame(List<Player> obj)
        {
            Action action = () => { buttonStartGame.Enabled = true; };
            this.InvokeEx(action);
            FormStatistic formStatistic = new FormStatistic(obj);
            formStatistic.ShowDialog();
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
