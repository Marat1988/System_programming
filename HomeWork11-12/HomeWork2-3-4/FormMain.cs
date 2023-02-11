using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeWork2_3_4
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            Bus bus = new Bus("175", 30);
            Worker worker = new Worker(bus);
            worker.getTime += BusMovement_getTime;
            worker.infoBus += BusMovement_infoBus;
            worker.infoPassenger += BusMovement_infoPassenger;
            Thread threadBus = new Thread(worker.BusIsOnItsWay);
            Thread thteadPassangers = new Thread(worker.PaggengerGo);
            threadBus.Start();
            thteadPassangers.Start();
        }

        private void BusMovement_infoPassenger(string info)
        {
            Action action = () => { listBoxPassengers.Items.Add(info); };
            this.Invoke(action);
        }

        private void BusMovement_infoBus(string info)
        {
            Action action = () => { listBoxBus.Items.Add(info); };
            this.Invoke(action);
        }

        private void BusMovement_getTime(string infoTime)
        {
            Action action = () => { labelTime.Text = infoTime; };
            this.Invoke(action);
        }
    }
}
