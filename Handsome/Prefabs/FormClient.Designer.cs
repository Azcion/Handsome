using System.Drawing;
using System.Windows.Forms;

namespace Handsome.Prefabs {

	partial class FormClient : Form {

		private RichTextBox _clientCard;
		private Panel _mainPanel;
		private Panel _entriesPanel;

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
			this._clientCard = new RichTextBox();
			this._mainPanel = new Panel();
			this._entriesPanel = new Panel();
			this._mainPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// _clientCard
			// 
			this._clientCard.BackColor = Color.White;
			this._clientCard.BorderStyle = BorderStyle.None;
			this._clientCard.Dock = DockStyle.Top;
			this._clientCard.Location = new Point(0, 0);
			this._clientCard.Name = "_clientCard";
			this._clientCard.ReadOnly = true;
			this._clientCard.ScrollBars = RichTextBoxScrollBars.None;
			this._clientCard.Size = new Size(804, 248);
			this._clientCard.Text = "";
			// 
			// _mainPanel
			// 
			this._mainPanel.BackColor = Color.Lime;
			this._mainPanel.Controls.Add(this._entriesPanel);
			this._mainPanel.Controls.Add(this._clientCard);
			this._mainPanel.Dock = DockStyle.Fill;
			this._mainPanel.Location = new Point(0, 0);
			this._mainPanel.Name = "_mainPanel";
			this._mainPanel.Size = new Size(804, 600);
			// 
			// _entriesPanel
			// 
			this._entriesPanel.BackColor = Color.GhostWhite;
			this._entriesPanel.Dock = DockStyle.Fill;
			this._entriesPanel.Location = new Point(0, 248);
			this._entriesPanel.Name = "_entriesPanel";
			this._entriesPanel.Size = new Size(804, 352);
			// 
			// FormClient
			// 
			this.AutoScaleDimensions = new SizeF(6F, 13F);
			this.AutoScaleMode = AutoScaleMode.Font;
			this.BackColor = Color.Red;
			this.ClientSize = new Size(804, 600);
			this.Controls.Add(this._mainPanel);
			this.Name = "FormClient";
			this.Text = "FormClient";
			this._mainPanel.ResumeLayout(false);
			this.ResumeLayout(false);

		}

	}

}