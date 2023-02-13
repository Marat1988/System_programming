using System;
using System.Collections.Generic;
using System.Threading;
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
            List<Bus> buses = new List<Bus>()
            {
                new Bus(175, 30),
                new Bus(176, 40),
                new Bus(177, 40),
                new Bus(188, 30),
                new Bus(190, 30)
            };
            Worker worker = new Worker(buses);
            worker.getTime += BusMovement_getTime;
            worker.infoBus += BusMovement_infoBus;
            worker.infoPassenger += BusMovement_infoPassenger;
            worker.infoPassengerCount += Worker_infoPassengerCount;
            Thread threadBus = new Thread(worker.BusIsOnItsWay);
            Thread thteadPassangers = new Thread(worker.PaggengerGo);
            threadBus.Start();
            thteadPassangers.Start();
        }

        private void Worker_infoPassengerCount(string info)
        {
            Action action = () => { labelCountPassenger.Text = info; };
            this.Invoke(action);
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
