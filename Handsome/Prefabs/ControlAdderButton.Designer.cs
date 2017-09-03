using System.Drawing;
using System.Windows.Forms;
using Handsome.Source;

namespace Handsome.Prefabs {

	internal sealed partial class ControlAdderButton {

		private Panel _mainPanel;
		private Button _button;

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
			this._mainPanel = new Panel();
			this._button = new Button();
			this._mainPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// _mainPanel
			// 
			this._mainPanel.Controls.Add(this._button);
			this._mainPanel.Dock = DockStyle.Fill;
			this._mainPanel.Font = new Font("Open Sans", 8.25F, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
			this._mainPanel.Location = new Point(0, 0);
			this._mainPanel.Name = "_mainPanel";
			this._mainPanel.Size = new Size(768, 140);
			// 
			// _button
			// 
			this._button.Anchor = AnchorStyles.Top;
			this._button.FlatAppearance.BorderSize = 0;
			this._button.FlatStyle = FlatStyle.Flat;
			this._button.Font = new Font("Open Sans", 36F, FontStyle.Regular, GraphicsUnit.Point, (byte) 238);
			this._button.ForeColor = Colors.Background;
			this._button.Location = new Point(256, 25);
			this._button.Name = "_button";
			this._button.Size = new Size(256, 90);
			this._button.Text = "+";
			this._button.UseVisualStyleBackColor = false;
			// 
			// ControlAdderButton
			// 
			this.AutoScaleDimensions = new SizeF(6F, 13F);
			this.AutoScaleMode = AutoScaleMode.Font;
			this.Controls.Add(this._mainPanel);
			this.Name = "ControlAdderButton";
			this.Size = new Size(768, 140);
			this._mainPanel.ResumeLayout(false);
			this.ResumeLayout(false);
		}

	}

}