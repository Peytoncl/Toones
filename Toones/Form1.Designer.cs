namespace Toones
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.TopPanel = new System.Windows.Forms.Panel();
			this.printDialog1 = new System.Windows.Forms.PrintDialog();
			this.label1 = new System.Windows.Forms.Label();
			this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
			this.TopPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
			this.SuspendLayout();
			// 
			// TopPanel
			// 
			this.TopPanel.BackColor = System.Drawing.SystemColors.ControlLight;
			this.TopPanel.Controls.Add(this.label1);
			this.TopPanel.Location = new System.Drawing.Point(0, 0);
			this.TopPanel.Name = "TopPanel";
			this.TopPanel.Size = new System.Drawing.Size(800, 33);
			this.TopPanel.TabIndex = 1;
			// 
			// printDialog1
			// 
			this.printDialog1.UseEXDialog = true;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(89, 17);
			this.label1.TabIndex = 0;
			this.label1.Text = "Now Playing:";
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// axWindowsMediaPlayer1
			// 
			this.axWindowsMediaPlayer1.Enabled = true;
			this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(234, 191);
			this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
			this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
			this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(0, 0);
			this.axWindowsMediaPlayer1.TabIndex = 2;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.axWindowsMediaPlayer1);
			this.Controls.Add(this.TopPanel);
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Toones";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.TopPanel.ResumeLayout(false);
			this.TopPanel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Panel TopPanel;
		private System.Windows.Forms.PrintDialog printDialog1;
		private System.Windows.Forms.Label label1;
		private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
	}
}

