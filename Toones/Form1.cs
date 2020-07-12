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
using AudioSwitcher;

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

		private bool isPuased = false;

		private string songDuration;

		private bool goDown;

		private string youtubeURL;

		private bool isOnYoutube = false;

		Uri url = new Uri("https://google.com");

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
			songDuration = axWindowsMediaPlayer1.currentMedia.durationString;
			label2.Text = selectedSong;
			songDuration = axWindowsMediaPlayer1.currentMedia.durationString;
			label1.Text = songDuration;
			webBrowser1.Url = url;
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
			webBrowser1.Url = url;
			label2.Text = "No Song";
		}

		private void trackBar1_Scroll(object sender, EventArgs e)
		{
			axWindowsMediaPlayer1.settings.volume = trackBar1.Value * 10;
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

		private void label1_Click_1(object sender, EventArgs e)
		{

		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{
			
		}

		private void button1_Click(object sender, EventArgs e)
		{
			
		}

		private void pictureBox4_Click(object sender, EventArgs e)
		{
			
		}

		private void checkBox1_CheckedChanged(object sender, EventArgs e)
		{
			
		}

		private void panel2_Paint(object sender, PaintEventArgs e)
		{

		}

		private void button1_Click_1(object sender, EventArgs e)
		{
			youtubeURL = textBox1.Text;
			if (textBox1.Text != "")
			{
				Uri url = new Uri(youtubeURL);
				webBrowser1.Url = url;
				textBox1.Text = "";
				axWindowsMediaPlayer1.Ctlcontrols.stop();
					label2.Text = "Unknown Song";
			}
		}

		private void textBox1_TextChanged_1(object sender, EventArgs e)
		{

		}

		private void label3_Click(object sender, EventArgs e)
		{

		}

		private void button2_Click(object sender, EventArgs e)
		{
			System.Diagnostics.Process process = new System.Diagnostics.Process();
			System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
			startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
			startInfo.FileName = "cmd.exe";
			string _path = Path.Combine(Environment.CurrentDirectory, @"Songs\");
			startInfo.Arguments = string.Format("/C start {0}", _path);
			process.StartInfo = startInfo;
			process.Start();
		}
	}
}
