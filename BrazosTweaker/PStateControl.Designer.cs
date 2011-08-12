﻿namespace BrazosTweaker
{
	partial class PStateControl
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PStateControl));
			this.Cofstate = new System.Windows.Forms.Label();
			this.CLKNumericUpDown = new System.Windows.Forms.NumericUpDown();
			this.refreshButton = new System.Windows.Forms.Button();
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.VidNumericUpDown = new System.Windows.Forms.NumericUpDown();
			this.tableLayoutPanelPstates = new System.Windows.Forms.TableLayoutPanel();
            this.VIDlabel = new System.Windows.Forms.Label();
			this.CLKlabel = new System.Windows.Forms.Label();
            this.pllfreq = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
			((System.ComponentModel.ISupportInitialize)(this.CLKNumericUpDown)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.VidNumericUpDown)).BeginInit();
			this.tableLayoutPanelPstates.SuspendLayout();
            this.SuspendLayout();
			// 
			// Cofstate
			// 
			this.Cofstate.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Cofstate.AutoSize = true;
			this.Cofstate.Location = new System.Drawing.Point(4, 0);
			this.Cofstate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Cofstate.Name = "Cofstate";
			this.Cofstate.Size = new System.Drawing.Size(82, 17);
			this.Cofstate.TabIndex = 0;
            this.Cofstate.Text = "Mult = 32 divided by ->" ;
            // 
            // PLL Frequency
            // 
            this.pllfreq.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pllfreq.AutoSize = true;
            this.pllfreq.Location = new System.Drawing.Point(4, 0);
            this.pllfreq.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pllfreq.Name = "Reg64CPU";
            this.pllfreq.Size = new System.Drawing.Size(82, 17);
            this.pllfreq.TabIndex = 7;
            this.pllfreq.Text = "Freq";
            // 
			// CLKNumericUpDown
			// 
			this.CLKNumericUpDown.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.CLKNumericUpDown.AutoSize = true;
			this.CLKNumericUpDown.DecimalPlaces = 0;
			this.CLKNumericUpDown.Increment = new decimal(new int[] {10000,0,0,262144});
			this.CLKNumericUpDown.Location = new System.Drawing.Point(94, 51);
			this.CLKNumericUpDown.Margin = new System.Windows.Forms.Padding(4);
			this.CLKNumericUpDown.Maximum = new decimal(new int[] {155,0,0,131072});
			this.CLKNumericUpDown.Minimum = new decimal(new int[] {125,0,0,262144});
			this.CLKNumericUpDown.Name = "CLKNumericUpDown";
			this.CLKNumericUpDown.Size = new System.Drawing.Size(68, 22);
			this.CLKNumericUpDown.TabIndex = 5;
			this.toolTip1.SetToolTip(this.CLKNumericUpDown, resources.GetString("CLKNumericUpDown.ToolTip"));
			this.CLKNumericUpDown.Value = new decimal(new int[] {1225,0,0,196608});
			// 
			// refreshButton
			// 
			this.refreshButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.refreshButton.AutoSize = true;
			this.refreshButton.Image = global::BrazosTweaker.Properties.Resources.refresh;
			this.refreshButton.Location = new System.Drawing.Point(220, 40);
			this.refreshButton.Margin = new System.Windows.Forms.Padding(4);
			this.refreshButton.Name = "refreshButton";
			this.refreshButton.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
			this.tableLayoutPanelPstates.SetRowSpan(this.refreshButton, 2);
			this.refreshButton.Size = new System.Drawing.Size(120, 33);
			this.refreshButton.TabIndex = 6;
			this.refreshButton.Text = "Refresh";
			this.refreshButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.toolTip1.SetToolTip(this.refreshButton, "Load the current settings directly from the CPU registers.");
			this.refreshButton.UseVisualStyleBackColor = true;
			// 
			// toolTip1
			// 
			this.toolTip1.AutoPopDelay = 30000;
			this.toolTip1.InitialDelay = 500;
			this.toolTip1.IsBalloon = true;
			this.toolTip1.ReshowDelay = 500;
			// 
			// VidNumericUpDown
			// 
			this.VidNumericUpDown.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.VidNumericUpDown.AutoSize = true;
			this.VidNumericUpDown.DecimalPlaces = 4;
			this.VidNumericUpDown.Increment = new decimal(new int[] {125,0,0,262144});
			this.VidNumericUpDown.Location = new System.Drawing.Point(94, 21);
			this.VidNumericUpDown.Margin = new System.Windows.Forms.Padding(4);
			this.VidNumericUpDown.Maximum = new decimal(new int[] {155,0,0,131072});
			this.VidNumericUpDown.Minimum = new decimal(new int[] {125,0,0,262144});
			this.VidNumericUpDown.Name = "VidNumericUpDown";
			this.VidNumericUpDown.Size = new System.Drawing.Size(68, 22);
			this.VidNumericUpDown.TabIndex = 3;
			this.toolTip1.SetToolTip(this.VidNumericUpDown, resources.GetString("VidNumericUpDown.ToolTip"));
			this.VidNumericUpDown.Value = new decimal(new int[] {130,0,0,131072});
			// 
			// tableLayoutPanelPstates
			// 
			this.tableLayoutPanelPstates.AutoSize = true;
			this.tableLayoutPanelPstates.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.tableLayoutPanelPstates.ColumnCount = 4;
			this.tableLayoutPanelPstates.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanelPstates.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanelPstates.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanelPstates.Controls.Add(this.VIDlabel, 0, 1);
			this.tableLayoutPanelPstates.Controls.Add(this.CLKlabel, 0, 2);
			this.tableLayoutPanelPstates.Controls.Add(this.flowLayoutPanel1, 1, 0);
			this.tableLayoutPanelPstates.Controls.Add(this.Cofstate, 0, 0);
            this.tableLayoutPanelPstates.Controls.Add(this.CLKNumericUpDown, 1, 2);
			this.tableLayoutPanelPstates.Controls.Add(this.VidNumericUpDown, 1, 1);
			this.tableLayoutPanelPstates.Controls.Add(this.refreshButton, 2, 1);
            this.tableLayoutPanelPstates.Controls.Add(this.pllfreq, 0, 3);
            this.tableLayoutPanelPstates.Dock = System.Windows.Forms.DockStyle.Top;
			this.tableLayoutPanelPstates.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanelPstates.Margin = new System.Windows.Forms.Padding(0);
			this.tableLayoutPanelPstates.Name = "tableLayoutPanelPstates";
			this.tableLayoutPanelPstates.RowCount = 4;
			this.tableLayoutPanelPstates.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanelPstates.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanelPstates.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanelPstates.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
			this.tableLayoutPanelPstates.Size = new System.Drawing.Size(344, 77);
			this.tableLayoutPanelPstates.TabIndex = 0;
            // 
			// VIDlabel
			// 
			this.VIDlabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.VIDlabel.AutoSize = true;
			this.VIDlabel.Location = new System.Drawing.Point(4, 23);
			this.VIDlabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.VIDlabel.Name = "VIDlabel";
			this.VIDlabel.Size = new System.Drawing.Size(66, 17);
			this.VIDlabel.TabIndex = 2;
			this.VIDlabel.Text = "VID:";
			// 
			// CLKlabel
			// 
			this.CLKlabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.CLKlabel.AutoSize = true;
			this.CLKlabel.Location = new System.Drawing.Point(4, 53);
			this.CLKlabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.CLKlabel.Name = "CLKlabel";
			this.CLKlabel.Size = new System.Drawing.Size(57, 17);
			this.CLKlabel.TabIndex = 4;
			this.CLKlabel.Text = "CLK (can't be set):";
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.flowLayoutPanel1.AutoSize = true;
			this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.tableLayoutPanelPstates.SetColumnSpan(this.flowLayoutPanel1, 2);
			this.flowLayoutPanel1.Location = new System.Drawing.Point(90, 8);
			this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.Size = new System.Drawing.Size(254, 0);
			this.flowLayoutPanel1.TabIndex = 1;
			// 
			// PStateControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.tableLayoutPanelPstates);
            //this.Controls.Add(this.tableLayoutPanelStatus);
            this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "PStateControl";
			this.Size = new System.Drawing.Size(344, 90);
			((System.ComponentModel.ISupportInitialize)(this.CLKNumericUpDown)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.VidNumericUpDown)).EndInit();
			this.tableLayoutPanelPstates.ResumeLayout(false);
			this.tableLayoutPanelPstates.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
		}

		#endregion

		private System.Windows.Forms.Label Cofstate;
        private System.Windows.Forms.Label pllfreq;
        private System.Windows.Forms.NumericUpDown CLKNumericUpDown;
		private System.Windows.Forms.Button refreshButton;
		private System.Windows.Forms.ToolTip toolTip1;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanelPstates;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
		private System.Windows.Forms.Label VIDlabel;
		private System.Windows.Forms.Label CLKlabel;
		private System.Windows.Forms.NumericUpDown VidNumericUpDown;
	}
}
