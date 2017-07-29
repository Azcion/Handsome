using System.Drawing;
using System.Windows.Forms;

namespace Handsome.Prefabs {

	partial class ControlAddClient {

		private Panel _mainPanel;
		private Label _nameLabel;
		private TextBox _nameBox;
		private Panel _innerPanel;
		private Panel _phone1Panel;
		private TextBox _phone1Box;
		private Panel _phone0Panel;
		private TextBox _phone0Box;
		private Label _phone1Label;
		private Panel _vatPanel;
		private TextBox _vatBox;
		private Label _phone0Label;
		private Panel _addressPanel;
		private TextBox _addressBox;
		private Label _vatLabel;
		private Label _addressLabel;
		private Panel _namePanel;
		private Panel _ownerPanel;
		private TextBox _ownerBox;
		private Label _ownerLabel;

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

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent () {
			this._mainPanel = new Panel();
			this._innerPanel = new Panel();
			this._nameLabel = new Label();
			this._namePanel = new Panel();
			this._nameBox = new TextBox();
			this._ownerLabel = new Label();
			this._ownerPanel = new Panel();
			this._ownerBox = new TextBox();
			this._addressLabel = new Label();
			this._addressPanel = new Panel();
			this._addressBox = new TextBox();
			this._vatLabel = new Label();
			this._vatPanel = new Panel();
			this._vatBox = new TextBox();
			this._phone0Label = new Label();
			this._phone0Panel = new Panel();
			this._phone0Box = new TextBox();
			this._phone1Label = new Label();
			this._phone1Panel = new Panel();
			this._phone1Box = new TextBox();
			this._button = new Button();
			this._mainPanel.SuspendLayout();
			this._innerPanel.SuspendLayout();
			this._namePanel.SuspendLayout();
			this._ownerPanel.SuspendLayout();
			this._addressPanel.SuspendLayout();
			this._vatPanel.SuspendLayout();
			this._phone0Panel.SuspendLayout();
			this._phone1Panel.SuspendLayout();
			this.SuspendLayout();
			// 
			// _mainPanel
			// 
			this._mainPanel.Controls.Add(this._button);
			this._mainPanel.Controls.Add(this._innerPanel);
			this._mainPanel.Dock = DockStyle.Fill;
			this._mainPanel.Location = new Point(0, 0);
			this._mainPanel.Name = "_mainPanel";
			this._mainPanel.Size = new Size(791, 281);
			this._mainPanel.TabIndex = 0;
			// 
			// _innerPanel
			// 
			this._innerPanel.Controls.Add(this._nameLabel);
			this._innerPanel.Controls.Add(this._namePanel);
			this._innerPanel.Controls.Add(this._ownerLabel);
			this._innerPanel.Controls.Add(this._ownerPanel);
			this._innerPanel.Controls.Add(this._addressLabel);
			this._innerPanel.Controls.Add(this._addressPanel);
			this._innerPanel.Controls.Add(this._vatLabel);
			this._innerPanel.Controls.Add(this._vatPanel);
			this._innerPanel.Controls.Add(this._phone0Label);
			this._innerPanel.Controls.Add(this._phone0Panel);
			this._innerPanel.Controls.Add(this._phone1Label);
			this._innerPanel.Controls.Add(this._phone1Panel);
			this._innerPanel.Location = new Point(20, 20);
			this._innerPanel.Name = "_innerPanel";
			this._innerPanel.Size = new Size(641, 241);
			this._innerPanel.TabIndex = 0;
			// 
			// _nameLabel
			// 
			this._nameLabel.AutoSize = true;
			this._nameLabel.Font = new Font("Open Sans Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(238)));
			this._nameLabel.Location = new Point(3, 0);
			this._nameLabel.Name = "_nameLabel";
			this._nameLabel.Size = new Size(53, 22);
			this._nameLabel.TabIndex = 0;
			this._nameLabel.Text = "Naziv";
			// 
			// _namePanel
			// 
			this._namePanel.BackColor = Color.White;
			this._namePanel.BorderStyle = BorderStyle.FixedSingle;
			this._namePanel.Controls.Add(this._nameBox);
			this._namePanel.Location = new Point(7, 25);
			this._namePanel.Name = "_namePanel";
			this._namePanel.Size = new Size(451, 44);
			this._namePanel.TabIndex = 1;
			// 
			// _nameBox
			// 
			this._nameBox.BorderStyle = BorderStyle.None;
			this._nameBox.Font = new Font("Open Sans", 15.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(238)));
			this._nameBox.Location = new Point(7, 7);
			this._nameBox.Name = "_nameBox";
			this._nameBox.Size = new Size(437, 29);
			this._nameBox.TabIndex = 0;
			// 
			// _ownerLabel
			// 
			this._ownerLabel.AutoSize = true;
			this._ownerLabel.Font = new Font("Open Sans Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(238)));
			this._ownerLabel.Location = new Point(3, 81);
			this._ownerLabel.Name = "_ownerLabel";
			this._ownerLabel.Size = new Size(65, 22);
			this._ownerLabel.TabIndex = 2;
			this._ownerLabel.Text = "Lastnik";
			// 
			// _ownerPanel
			// 
			this._ownerPanel.BackColor = Color.White;
			this._ownerPanel.BorderStyle = BorderStyle.FixedSingle;
			this._ownerPanel.Controls.Add(this._ownerBox);
			this._ownerPanel.Location = new Point(7, 106);
			this._ownerPanel.Name = "_ownerPanel";
			this._ownerPanel.Size = new Size(451, 44);
			this._ownerPanel.TabIndex = 3;
			// 
			// _ownerBox
			// 
			this._ownerBox.BorderStyle = BorderStyle.None;
			this._ownerBox.Font = new Font("Open Sans", 15.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(238)));
			this._ownerBox.Location = new Point(7, 7);
			this._ownerBox.Name = "_ownerBox";
			this._ownerBox.Size = new Size(437, 29);
			this._ownerBox.TabIndex = 1;
			// 
			// _addressLabel
			// 
			this._addressLabel.AutoSize = true;
			this._addressLabel.Font = new Font("Open Sans Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(238)));
			this._addressLabel.Location = new Point(3, 162);
			this._addressLabel.Name = "_addressLabel";
			this._addressLabel.Size = new Size(63, 22);
			this._addressLabel.TabIndex = 4;
			this._addressLabel.Text = "Naslov";
			// 
			// _addressPanel
			// 
			this._addressPanel.BackColor = Color.White;
			this._addressPanel.BorderStyle = BorderStyle.FixedSingle;
			this._addressPanel.Controls.Add(this._addressBox);
			this._addressPanel.Location = new Point(7, 187);
			this._addressPanel.Name = "_addressPanel";
			this._addressPanel.Size = new Size(451, 44);
			this._addressPanel.TabIndex = 5;
			// 
			// _addressBox
			// 
			this._addressBox.BorderStyle = BorderStyle.None;
			this._addressBox.Font = new Font("Open Sans", 15.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(238)));
			this._addressBox.Location = new Point(7, 7);
			this._addressBox.Name = "_addressBox";
			this._addressBox.Size = new Size(437, 29);
			this._addressBox.TabIndex = 2;
			// 
			// _vatLabel
			// 
			this._vatLabel.Anchor = ((AnchorStyles)((AnchorStyles.Top | AnchorStyles.Right)));
			this._vatLabel.AutoSize = true;
			this._vatLabel.Font = new Font("Open Sans Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(238)));
			this._vatLabel.Location = new Point(485, 0);
			this._vatLabel.Name = "_vatLabel";
			this._vatLabel.Size = new Size(89, 22);
			this._vatLabel.TabIndex = 6;
			this._vatLabel.Text = "Davčna št.";
			// 
			// _vatPanel
			// 
			this._vatPanel.Anchor = ((AnchorStyles)((AnchorStyles.Top | AnchorStyles.Right)));
			this._vatPanel.BackColor = Color.White;
			this._vatPanel.BorderStyle = BorderStyle.FixedSingle;
			this._vatPanel.Controls.Add(this._vatBox);
			this._vatPanel.Location = new Point(489, 25);
			this._vatPanel.Name = "_vatPanel";
			this._vatPanel.Size = new Size(144, 44);
			this._vatPanel.TabIndex = 7;
			// 
			// _vatBox
			// 
			this._vatBox.BorderStyle = BorderStyle.None;
			this._vatBox.Font = new Font("Open Sans", 15.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(238)));
			this._vatBox.Location = new Point(7, 7);
			this._vatBox.Name = "_vatBox";
			this._vatBox.Size = new Size(131, 29);
			this._vatBox.TabIndex = 3;
			// 
			// _phone0Label
			// 
			this._phone0Label.Anchor = ((AnchorStyles)((AnchorStyles.Top | AnchorStyles.Right)));
			this._phone0Label.AutoSize = true;
			this._phone0Label.Font = new Font("Open Sans Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(238)));
			this._phone0Label.Location = new Point(485, 81);
			this._phone0Label.Name = "_phone0Label";
			this._phone0Label.Size = new Size(67, 22);
			this._phone0Label.TabIndex = 8;
			this._phone0Label.Text = "Telefon";
			// 
			// _phone0Panel
			// 
			this._phone0Panel.Anchor = ((AnchorStyles)((AnchorStyles.Top | AnchorStyles.Right)));
			this._phone0Panel.BackColor = Color.White;
			this._phone0Panel.BorderStyle = BorderStyle.FixedSingle;
			this._phone0Panel.Controls.Add(this._phone0Box);
			this._phone0Panel.Location = new Point(489, 106);
			this._phone0Panel.Name = "_phone0Panel";
			this._phone0Panel.Size = new Size(144, 44);
			this._phone0Panel.TabIndex = 9;
			// 
			// _phone0Box
			// 
			this._phone0Box.BorderStyle = BorderStyle.None;
			this._phone0Box.Font = new Font("Open Sans", 15.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(238)));
			this._phone0Box.Location = new Point(7, 7);
			this._phone0Box.Name = "_phone0Box";
			this._phone0Box.Size = new Size(131, 29);
			this._phone0Box.TabIndex = 4;
			// 
			// _phone1Label
			// 
			this._phone1Label.Anchor = ((AnchorStyles)((AnchorStyles.Top | AnchorStyles.Right)));
			this._phone1Label.AutoSize = true;
			this._phone1Label.Font = new Font("Open Sans Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(238)));
			this._phone1Label.Location = new Point(485, 162);
			this._phone1Label.Name = "_phone1Label";
			this._phone1Label.Size = new Size(67, 22);
			this._phone1Label.TabIndex = 10;
			this._phone1Label.Text = "Telefon";
			// 
			// _phone1Panel
			// 
			this._phone1Panel.Anchor = ((AnchorStyles)((AnchorStyles.Top | AnchorStyles.Right)));
			this._phone1Panel.BackColor = Color.White;
			this._phone1Panel.BorderStyle = BorderStyle.FixedSingle;
			this._phone1Panel.Controls.Add(this._phone1Box);
			this._phone1Panel.Location = new Point(489, 187);
			this._phone1Panel.Name = "_phone1Panel";
			this._phone1Panel.Size = new Size(144, 44);
			this._phone1Panel.TabIndex = 11;
			// 
			// _phone1Box
			// 
			this._phone1Box.BorderStyle = BorderStyle.None;
			this._phone1Box.Font = new Font("Open Sans", 15.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(238)));
			this._phone1Box.Location = new Point(7, 7);
			this._phone1Box.Name = "_phone1Box";
			this._phone1Box.Size = new Size(131, 29);
			this._phone1Box.TabIndex = 5;
			// 
			// _button
			// 
			this._button.Anchor = AnchorStyles.Top;
			this._button.FlatAppearance.BorderSize = 0;
			this._button.FlatStyle = FlatStyle.Flat;
			this._button.Font = new Font("Open Sans", 36F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(238)));
			this._button.ForeColor = Color.White;
			this._button.Location = new Point(678, 20);
			this._button.Name = "_button";
			this._button.Size = new Size(95, 231);
			this._button.TabIndex = 1;
			this._button.Text = "✓";
			this._button.UseVisualStyleBackColor = false;
			// 
			// ControlAddClient
			// 
			this.AutoScaleDimensions = new SizeF(6F, 13F);
			this.AutoScaleMode = AutoScaleMode.Font;
			this.Controls.Add(this._mainPanel);
			this.Name = "ControlAddClient";
			this.Size = new Size(791, 281);
			this._mainPanel.ResumeLayout(false);
			this._innerPanel.ResumeLayout(false);
			this._innerPanel.PerformLayout();
			this._namePanel.ResumeLayout(false);
			this._namePanel.PerformLayout();
			this._ownerPanel.ResumeLayout(false);
			this._ownerPanel.PerformLayout();
			this._addressPanel.ResumeLayout(false);
			this._addressPanel.PerformLayout();
			this._vatPanel.ResumeLayout(false);
			this._vatPanel.PerformLayout();
			this._phone0Panel.ResumeLayout(false);
			this._phone0Panel.PerformLayout();
			this._phone1Panel.ResumeLayout(false);
			this._phone1Panel.PerformLayout();
			this.ResumeLayout(false);

		}

		private Button _button;
	}

}