using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Handsome.Source;

namespace Handsome.Prefabs {

	internal sealed partial class FormPicker : Form {

		private Panel _mainPanel;

		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose (bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}

			base.Dispose(disposing);
		}

		private void InitializeComponent () {
			ComponentResourceManager resources = new ComponentResourceManager(typeof(FormPicker));
			this._mainPanel = new Panel();
			this.SuspendLayout();
			// 
			// _mainPanel
			// 
			this._mainPanel.AutoScroll = true;
			this._mainPanel.BackColor = Colors.Background;
			this._mainPanel.Dock = DockStyle.Fill;
			this._mainPanel.Location = new Point(0, 0);
			this._mainPanel.Name = "_mainPanel";
			this._mainPanel.Size = new Size(804, 600);
			// 
			// FormPicker
			// 
			this.AutoScaleDimensions = new SizeF(6F, 13F);
			this.AutoScaleMode = AutoScaleMode.Font;
			this.ClientSize = new Size(804, 600);
			this.Controls.Add(this._mainPanel);
			this.Icon = ((Icon)(resources.GetObject("$this.Icon")));
			this.Name = "FormPicker";
			this.Text = "Handsome 1.0";
			this.ResumeLayout(false);
		}

	}

}