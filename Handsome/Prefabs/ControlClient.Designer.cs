using System.Drawing;
using System.Windows.Forms;
using Handsome.Source;

namespace Handsome.Prefabs {

	internal sealed partial class ControlClient : UserControl {

		private Panel _mainPanel;
		private RichTextBox _clientCard;
		private RichTextBox _clientValue;
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
			this._clientCard = new RichTextBox();
			this._clientValue = new RichTextBox();
			this._button = new Button();
			this._mainPanel = new Panel();
			this._mainPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// _clientCard
			// 
			this._clientCard.BorderStyle = BorderStyle.None;
			this._clientCard.Dock = DockStyle.Fill;
			this._clientCard.Location = new Point(137, 0);
			this._clientCard.Name = "_clientCard";
			this._clientCard.Size = new Size(370, 123);
			this._clientCard.Text = "";
			// 
			// _clientValue
			// 
			this._clientValue.BorderStyle = BorderStyle.None;
			this._clientValue.Dock = DockStyle.Left;
			this._clientValue.Location = new Point(0, 0);
			this._clientValue.Name = "_clientValue";
			this._clientValue.Size = new Size(137, 123);
			this._clientValue.Text = "";
			// 
			// _button
			// 
			this._button.Dock = DockStyle.Right;
			this._button.FlatAppearance.BorderSize = 0;
			this._button.FlatStyle = FlatStyle.Flat;
			this._button.Font = new Font("Open Sans", 36F, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
			this._button.ForeColor = Colors.Background;
			this._button.Location = new Point(507, 0);
			this._button.Name = "_button";
			this._button.Size = new Size(224, 123);
			this._button.Text = "→";
			this._button.UseVisualStyleBackColor = false;
			// 
			// _mainPanel
			// 
			this._mainPanel.Controls.Add(this._clientCard);
			this._mainPanel.Controls.Add(this._clientValue);
			this._mainPanel.Controls.Add(this._button);
			this._mainPanel.Dock = DockStyle.Fill;
			this._mainPanel.Location = new Point(0, 0);
			this._mainPanel.Name = "_mainPanel";
			this._mainPanel.Size = new Size(731, 123);
			// 
			// ControlClient
			// 
			this.Controls.Add(this._mainPanel);
			this.Name = "ControlClient";
			this.Size = new Size(731, 123);
			this._mainPanel.ResumeLayout(false);
			this.ResumeLayout(false);
		}

	}

}