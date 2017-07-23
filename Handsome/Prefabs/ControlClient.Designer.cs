using System.Windows.Forms;

namespace Handsome.Prefabs {

	internal partial class ControlClient : UserControl {

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
			this._clientCard = new System.Windows.Forms.RichTextBox();
			this._clientValue = new System.Windows.Forms.RichTextBox();
			this._button = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// _clientCard
			// 
			this._clientCard.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this._clientCard.Dock = System.Windows.Forms.DockStyle.Fill;
			this._clientCard.Location = new System.Drawing.Point(137, 0);
			this._clientCard.Name = "_clientCard";
			this._clientCard.Size = new System.Drawing.Size(370, 123);
			this._clientCard.TabIndex = 0;
			this._clientCard.Text = "";
			// 
			// _clientValue
			// 
			this._clientValue.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this._clientValue.Dock = System.Windows.Forms.DockStyle.Left;
			this._clientValue.Location = new System.Drawing.Point(0, 0);
			this._clientValue.Name = "_clientValue";
			this._clientValue.Size = new System.Drawing.Size(137, 123);
			this._clientValue.TabIndex = 1;
			this._clientValue.Text = "";
			// 
			// _button
			// 
			this._button.Dock = System.Windows.Forms.DockStyle.Right;
			this._button.FlatAppearance.BorderSize = 0;
			this._button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this._button.Location = new System.Drawing.Point(507, 0);
			this._button.Name = "_button";
			this._button.Size = new System.Drawing.Size(224, 123);
			this._button.TabIndex = 2;
			this._button.UseVisualStyleBackColor = false;
			// 
			// ControlClient
			// 
			this.Controls.Add(this._clientCard);
			this.Controls.Add(this._clientValue);
			this.Controls.Add(this._button);
			this.Name = "ControlClient";
			this.Size = new System.Drawing.Size(731, 123);
			this.ResumeLayout(false);

		}

	}

}