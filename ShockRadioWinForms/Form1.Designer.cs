
namespace ShockRadioWinForms
{
	partial class ShockRadio
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShockRadio));
			this.PlayButton = new System.Windows.Forms.Button();
			this.StopButton = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.VolumeBar = new System.Windows.Forms.TrackBar();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.VolumeBar)).BeginInit();
			this.SuspendLayout();
			// 
			// PlayButton
			// 
			this.PlayButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.PlayButton.Location = new System.Drawing.Point(12, 292);
			this.PlayButton.Name = "PlayButton";
			this.PlayButton.Size = new System.Drawing.Size(185, 75);
			this.PlayButton.TabIndex = 0;
			this.PlayButton.Text = "Play";
			this.PlayButton.UseVisualStyleBackColor = true;
			this.PlayButton.Click += new System.EventHandler(this.PlayButton_Click);
			// 
			// StopButton
			// 
			this.StopButton.Enabled = false;
			this.StopButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
			this.StopButton.Location = new System.Drawing.Point(278, 292);
			this.StopButton.Name = "StopButton";
			this.StopButton.Size = new System.Drawing.Size(185, 75);
			this.StopButton.TabIndex = 1;
			this.StopButton.Text = "Stop";
			this.StopButton.UseVisualStyleBackColor = true;
			this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox1.Image = global::ShockRadioWinForms.Properties.Resources.logo1;
			this.pictureBox1.Location = new System.Drawing.Point(12, 12);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(452, 273);
			this.pictureBox1.TabIndex = 2;
			this.pictureBox1.TabStop = false;
			// 
			// VolumeBar
			// 
			this.VolumeBar.Enabled = false;
			this.VolumeBar.Location = new System.Drawing.Point(12, 374);
			this.VolumeBar.Name = "VolumeBar";
			this.VolumeBar.Size = new System.Drawing.Size(452, 45);
			this.VolumeBar.TabIndex = 3;
			this.VolumeBar.Value = 5;
			this.VolumeBar.ValueChanged += new System.EventHandler(this.VolumeBar_ValueChanged);
			// 
			// ShockRadio
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(475, 431);
			this.Controls.Add(this.VolumeBar);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.StopButton);
			this.Controls.Add(this.PlayButton);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "ShockRadio";
			this.Text = "Shock Radio";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.VolumeBar)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button PlayButton;
		private System.Windows.Forms.Button StopButton;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.TrackBar VolumeBar;
	}
}

