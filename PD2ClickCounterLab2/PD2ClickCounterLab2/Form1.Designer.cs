namespace PD2ClickCounterLab2
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
            this.components = new System.ComponentModel.Container();
            this.btnTap = new System.Windows.Forms.Button();
            this.lblCounter = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.tmTimer = new System.Windows.Forms.Timer(this.components);
            this.lblClock = new System.Windows.Forms.Label();
            this.btnStopTimer = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCadence = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblstrokeMins = new System.Windows.Forms.Label();
            this.lbxLapCount = new System.Windows.Forms.ListBox();
            this.txbPoolLength = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbxStrokeLength = new System.Windows.Forms.ListBox();
            this.txbStrokesMade = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnTap
            // 
            this.btnTap.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTap.Location = new System.Drawing.Point(45, 53);
            this.btnTap.Name = "btnTap";
            this.btnTap.Size = new System.Drawing.Size(121, 122);
            this.btnTap.TabIndex = 0;
            this.btnTap.Text = "TAP";
            this.btnTap.UseVisualStyleBackColor = true;
            this.btnTap.Click += new System.EventHandler(this.btnTap_Click);
            // 
            // lblCounter
            // 
            this.lblCounter.AutoSize = true;
            this.lblCounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCounter.Location = new System.Drawing.Point(41, 9);
            this.lblCounter.Name = "lblCounter";
            this.lblCounter.Size = new System.Drawing.Size(108, 24);
            this.lblCounter.TabIndex = 1;
            this.lblCounter.Text = "Current Lap";
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnReset.Location = new System.Drawing.Point(180, 118);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(84, 57);
            this.btnReset.TabIndex = 2;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // tmTimer
            // 
            this.tmTimer.Interval = 1000;
            this.tmTimer.Tick += new System.EventHandler(this.tmTimer_Tick);
            // 
            // lblClock
            // 
            this.lblClock.AutoSize = true;
            this.lblClock.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClock.Location = new System.Drawing.Point(59, 225);
            this.lblClock.Name = "lblClock";
            this.lblClock.Size = new System.Drawing.Size(75, 24);
            this.lblClock.TabIndex = 3;
            this.lblClock.Text = "0.00000";
            // 
            // btnStopTimer
            // 
            this.btnStopTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnStopTimer.Location = new System.Drawing.Point(180, 53);
            this.btnStopTimer.Name = "btnStopTimer";
            this.btnStopTimer.Size = new System.Drawing.Size(84, 59);
            this.btnStopTimer.TabIndex = 4;
            this.btnStopTimer.Text = "StopTimer";
            this.btnStopTimer.UseVisualStyleBackColor = true;
            this.btnStopTimer.Click += new System.EventHandler(this.btnStopTimer_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(281, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "SecondsPerStroke";
            // 
            // lblCadence
            // 
            this.lblCadence.AutoSize = true;
            this.lblCadence.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblCadence.Location = new System.Drawing.Point(297, 74);
            this.lblCadence.Name = "lblCadence";
            this.lblCadence.Size = new System.Drawing.Size(55, 24);
            this.lblCadence.TabIndex = 6;
            this.lblCadence.Text = "0.000";
            this.lblCadence.Click += new System.EventHandler(this.lblCadence_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(281, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "StrokesPerMinute";
            // 
            // lblstrokeMins
            // 
            this.lblstrokeMins.AutoSize = true;
            this.lblstrokeMins.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblstrokeMins.Location = new System.Drawing.Point(297, 151);
            this.lblstrokeMins.Name = "lblstrokeMins";
            this.lblstrokeMins.Size = new System.Drawing.Size(55, 24);
            this.lblstrokeMins.TabIndex = 8;
            this.lblstrokeMins.Text = "0.000";
            // 
            // lbxLapCount
            // 
            this.lbxLapCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbxLapCount.FormattingEnabled = true;
            this.lbxLapCount.ItemHeight = 16;
            this.lbxLapCount.Location = new System.Drawing.Point(45, 292);
            this.lbxLapCount.Name = "lbxLapCount";
            this.lbxLapCount.Size = new System.Drawing.Size(133, 132);
            this.lbxLapCount.TabIndex = 9;
            // 
            // txbPoolLength
            // 
            this.txbPoolLength.Location = new System.Drawing.Point(282, 242);
            this.txbPoolLength.Name = "txbPoolLength";
            this.txbPoolLength.Size = new System.Drawing.Size(100, 20);
            this.txbPoolLength.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(279, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "Pool Length Meters";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(269, 337);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "Stroke Length Meters";
            // 
            // lbxStrokeLength
            // 
            this.lbxStrokeLength.FormattingEnabled = true;
            this.lbxStrokeLength.Location = new System.Drawing.Point(272, 368);
            this.lbxStrokeLength.Name = "lbxStrokeLength";
            this.lbxStrokeLength.Size = new System.Drawing.Size(120, 56);
            this.lbxStrokeLength.Sorted = true;
            this.lbxStrokeLength.TabIndex = 15;
            // 
            // txbStrokesMade
            // 
            this.txbStrokesMade.Location = new System.Drawing.Point(282, 304);
            this.txbStrokesMade.Name = "txbStrokesMade";
            this.txbStrokesMade.Size = new System.Drawing.Size(100, 20);
            this.txbStrokesMade.TabIndex = 16;
            this.txbStrokesMade.TextChanged += new System.EventHandler(this.txbStrokesMade_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(269, 274);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 17);
            this.label3.TabIndex = 17;
            this.label3.Text = "Strokes Made (lap)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 453);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txbStrokesMade);
            this.Controls.Add(this.lbxStrokeLength);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txbPoolLength);
            this.Controls.Add(this.lbxLapCount);
            this.Controls.Add(this.lblstrokeMins);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblCadence);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnStopTimer);
            this.Controls.Add(this.lblClock);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.lblCounter);
            this.Controls.Add(this.btnTap);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnTap;
		private System.Windows.Forms.Label lblCounter;
		private System.Windows.Forms.Button btnReset;
		private System.Windows.Forms.Timer tmTimer;
		private System.Windows.Forms.Label lblClock;
		private System.Windows.Forms.Button btnStopTimer;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lblCadence;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label lblstrokeMins;
		private System.Windows.Forms.ListBox lbxLapCount;
		private System.Windows.Forms.TextBox txbPoolLength;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.ListBox lbxStrokeLength;
		private System.Windows.Forms.TextBox txbStrokesMade;
		private System.Windows.Forms.Label label3;
	}
}

