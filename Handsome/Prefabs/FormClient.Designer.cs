namespace Handsome.Prefabs {

	partial class FormClient {

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

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent () {
			this._clientCard = new System.Windows.Forms.RichTextBox();
			this._mainPanel = new System.Windows.Forms.Panel();
			this._entriesPanel = new System.Windows.Forms.Panel();
			this._mainPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// _clientCard
			// 
			this._clientCard.BackColor = System.Drawing.Color.White;
			this._clientCard.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this._clientCard.Dock = System.Windows.Forms.DockStyle.Top;
			this._clientCard.Location = new System.Drawing.Point(0, 0);
			this._clientCard.Name = "_clientCard";
			this._clientCard.ReadOnly = true;
			this._clientCard.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
			this._clientCard.Size = new System.Drawing.Size(804, 219);
			this._clientCard.Text = "";
			// 
			// _mainPanel
			// 
			this._mainPanel.BackColor = System.Drawing.Color.Lime;
			this._mainPanel.Controls.Add(this._entriesPanel);
			this._mainPanel.Controls.Add(this._clientCard);
			this._mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this._mainPanel.Location = new System.Drawing.Point(0, 0);
			this._mainPanel.Name = "_mainPanel";
			this._mainPanel.Size = new System.Drawing.Size(804, 600);
			// 
			// _entriesPanel
			// 
			this._entriesPanel.BackColor = System.Drawing.Color.GhostWhite;
			this._entriesPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this._entriesPanel.Location = new System.Drawing.Point(0, 219);
			this._entriesPanel.Name = "_entriesPanel";
			this._entriesPanel.Size = new System.Drawing.Size(804, 381);
			this._entriesPanel.TabIndex = 0;
			// 
			// FormClient
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Red;
			this.ClientSize = new System.Drawing.Size(804, 600);
			this.Controls.Add(this._mainPanel);
			this.Name = "FormClient";
			this.Text = "FormClient";
			this._mainPanel.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.RichTextBox _clientCard;
		private System.Windows.Forms.Panel _mainPanel;
		private System.Windows.Forms.Panel _entriesPanel;

	}

}