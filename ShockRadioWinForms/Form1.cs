using NAudio.Wave;
using System;
using System.Windows.Forms;

namespace ShockRadioWinForms
{
	public partial class ShockRadio : Form
	{
		public WaveOutEvent wo;
		public ShockRadio()
		{
			InitializeComponent();
		}
		private void PlayButton_Click(object sender, EventArgs e)
		{
			var url = "http://streaming02.zfast.co.uk:8000/stream";
			var mf = new MediaFoundationReader(url);
			wo = new WaveOutEvent();
			wo.Init(mf);
			wo.Play();
			StopButton.Enabled = true;
			VolumeBar.Enabled = true;
			PlayButton.Enabled = false;
		}
		private void StopButton_Click(object sender, EventArgs e)
		{
			wo.Stop();
			StopButton.Enabled = false;
			VolumeBar.Enabled = false;
			PlayButton.Enabled = true;

		}
		private void VolumeBar_ValueChanged(object sender, EventArgs e)
		{
			float newVolume = VolumeBar.Value;
			if (newVolume != 0)
			{
				newVolume /= 10;
			}
			wo.Volume = newVolume;
		}
	}
}