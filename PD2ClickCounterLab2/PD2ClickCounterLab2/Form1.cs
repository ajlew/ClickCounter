using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PD2ClickCounterLab2
{
	public partial class Form1 : Form
	{
		// input
		int counter = 0;
		double timer = 0.0;
		double cadence = 0; // seconds lapsed  per stroke
		int StrokesMade=26;// average strokes Made per lap
		double strokeMins = 0;// actual stroke rate
		double StrokeLength = 0;// actual stroke distance each stroke
		int PoolLength = 25;// pool length

		public Form1()
		{
			InitializeComponent();
		}

		private void btnTap_Click(object sender, EventArgs e)
		{

			//process
			tmTimer.Enabled = true;
			//timer++;
			counter++;
			//output
			lblCounter.Text = counter.ToString();
		}

		private void btnReset_Click(object sender, EventArgs e)
		{ // reset variables to 0
			counter = 0;
			timer = 0.0;
			cadence = 0.0;
			strokeMins = 0;
			txbPoolLength.Text = PoolLength.ToString();
			lblCounter.Text = counter.ToString();
			lblClock.Text = timer.ToString();
			lblCadence.Text = cadence.ToString();
			lblstrokeMins.Text= strokeMins.ToString();
			lbxLapCount.Items.Clear();
			lbxStrokeLength.Items.Clear();

		}

		private void btnStopTimer_Click(object sender, EventArgs e)
		{
			tmTimer.Enabled=false;
		}

		private void tmTimer_Tick(object sender, EventArgs e)
		{
            StrokesMade = 29;

            txbStrokesMade.Text = StrokesMade.ToString();

            timer++;
			lblClock.Text = timer.ToString() + "Seconds";
			cadence = timer/counter;
			strokeMins = 60 / cadence;
			StrokeLength = PoolLength / StrokesMade;

			if (StrokesMade == 0)
			{

				StrokesMade = 26;
			}
			else
			{
				StrokesMade =0;

			}
			
			lblCounter.Text = counter.ToString() + "Strokes Made";
			lblCadence.Text = cadence.ToString();
			lblstrokeMins.Text = strokeMins.ToString();
			lbxLapCount.Items.Add(StrokeLength);
			lbxStrokeLength.Items.Add(StrokeLength);
		}

		private void lblCadence_Click(object sender, EventArgs e)
		{
			/// nothing happens here
		}

        private void txbStrokesMade_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
