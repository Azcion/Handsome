using System.Drawing;
using System.Windows.Forms;

namespace Handsome.Prefabs {

	internal sealed partial class FormClient : Form {

		private RichTextBox _clientCard;
		private Panel _entriesPanel;
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
			this._entriesPanel = new Panel();
			this._clientCard = new RichTextBox();
			this._mainPanel = new Panel();
			this._mainPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// _entriesPanel
			// 
			this._entriesPanel.AutoSize = true;
			this._entriesPanel.BackColor = Color.DeepPink;
			this._entriesPanel.Dock = DockStyle.Top;
			this._entriesPanel.Location = new Point(0, 248);
			this._entriesPanel.Name = "_entriesPanel";
			this._entriesPanel.Size = new Size(804, 0);
			// 
			// _clientCard
			// 
			this._clientCard.BackColor = Color.White;
			this._clientCard.BorderStyle = BorderStyle.None;
			this._clientCard.Dock = DockStyle.Top;
			this._clientCard.Enabled = false;
			this._clientCard.Location = new Point(0, 0);
			this._clientCard.Name = "_clientCard";
			this._clientCard.ReadOnly = true;
			this._clientCard.ScrollBars = RichTextBoxScrollBars.None;
			this._clientCard.Size = new Size(804, 248);
			this._clientCard.Text = "";
			// 
			// _mainPanel
			// 
			this._mainPanel.AutoScroll = true;
			this._mainPanel.BackColor = Color.GhostWhite;
			this._mainPanel.Controls.Add(this._entriesPanel);
			this._mainPanel.Controls.Add(this._clientCard);
			this._mainPanel.Dock = DockStyle.Fill;
			this._mainPanel.Location = new Point(0, 0);
			this._mainPanel.Name = "_mainPanel";
			this._mainPanel.Size = new Size(804, 600);
			// 
			// FormClient
			// 
			this.AutoScaleDimensions = new SizeF(6F, 13F);
			this.AutoScaleMode = AutoScaleMode.Font;
			this.BackColor = Color.Red;
			this.ClientSize = new Size(804, 600);
			this.Controls.Add(this._mainPanel);
			this.Name = "FormClient";
			this.Text = "Komitent";
			this._mainPanel.ResumeLayout(false);
			this._mainPanel.PerformLayout();
			this.ResumeLayout(false);
		}

	}

}