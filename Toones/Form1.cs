using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Toones
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		public string thisDirectory = Path.Combine(Environment.CurrentDirectory);
		private string selectedSong;

		private string keyWord = "";

		private bool isPuased = false;

		private void Form1_Load(object sender, EventArgs e)
		{
			songList.Items.Clear();
			DirectoryInfo dinfo = new DirectoryInfo(Path.Combine(Environment.CurrentDirectory, @"Songs\"));
			FileInfo[] smFiles = dinfo.GetFiles("*.mp3");
			foreach (FileInfo fi in smFiles)
			{
				songList.Items.Add(Path.GetFileNameWithoutExtension(fi.Name));
			}
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{
			axWindowsMediaPlayer1.Ctlcontrols.stop();
			string filePath = Path.Combine(Environment.CurrentDirectory, @"Songs\", selectedSong + ".mp3");
			axWindowsMediaPlayer1.URL = filePath;
			axWindowsMediaPlayer1.Ctlcontrols.play();
			label2.Text = selectedSong;
		}

		private void songList_SelectedIndexChanged(object sender, EventArgs e)
		{
			selectedSong = songList.SelectedItem.ToString();
		}

		private void label2_Click(object sender, EventArgs e)
		{

		}

		private void pictureBox2_Click_1(object sender, EventArgs e)
		{
			axWindowsMediaPlayer1.Ctlcontrols.stop();
			label2.Text = "No Song";
		}

		private void trackBar1_Scroll(object sender, EventArgs e)
		{
			axWindowsMediaPlayer1.settings.volume = trackBar1.Value;
		}

		private void pictureBox3_Click(object sender, EventArgs e)
		{
			if (!isPuased)
			{
				axWindowsMediaPlayer1.Ctlcontrols.pause();
				isPuased = true;
			}
			else if (isPuased)
			{
				axWindowsMediaPlayer1.Ctlcontrols.play();
				isPuased = false;
			}
		}
	}
}
