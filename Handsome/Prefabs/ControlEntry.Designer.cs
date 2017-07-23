using System.Drawing;
using System.Windows.Forms;

namespace Handsome.Prefabs {

	sealed partial class ControlEntry : UserControl {

		private Panel _entryPanel;
		private DataGridView _dataGrid;
		private RichTextBox _dateLabel;

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
			DataGridViewCellStyle cellStyle0 = new DataGridViewCellStyle();
			DataGridViewCellStyle cellStyle1 = new DataGridViewCellStyle();
			DataGridViewCellStyle cellStyle2 = new DataGridViewCellStyle();
			this._entryPanel = new Panel();
			this._dataGrid = new DataGridView();
			this._dateLabel = new RichTextBox();
			this._entryPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this._dataGrid)).BeginInit();
			this.SuspendLayout();
			// 
			// _entryPanel
			// 
			this._entryPanel.AutoScroll = true;
			this._entryPanel.BackColor = Color.White;
			this._entryPanel.Controls.Add(this._dataGrid);
			this._entryPanel.Controls.Add(this._dateLabel);
			this._entryPanel.Dock = DockStyle.Top;
			this._entryPanel.Location = new Point(0, 0);
			this._entryPanel.MaximumSize = new Size(0, 300);
			this._entryPanel.MinimumSize = new Size(0, 75);
			this._entryPanel.Name = "_entryPanel";
			this._entryPanel.Size = new Size(500, 75);
			this._entryPanel.TabIndex = 5;
			// 
			// _dataGrid
			// 
			this._dataGrid.AllowUserToResizeColumns = false;
			this._dataGrid.AllowUserToResizeRows = false;
			cellStyle0.Alignment = DataGridViewContentAlignment.MiddleLeft;
			cellStyle0.BackColor = Color.WhiteSmoke;
			cellStyle0.Font = new Font("Open Sans", 12F, FontStyle.Regular, GraphicsUnit.Point, (byte) 238);
			cellStyle0.ForeColor = Color.DimGray;
			cellStyle0.SelectionBackColor = Color.Gainsboro;
			cellStyle0.SelectionForeColor = Color.Black;
			cellStyle0.WrapMode = DataGridViewTriState.False;
			this._dataGrid.AlternatingRowsDefaultCellStyle = cellStyle0;
			this._dataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			this._dataGrid.BorderStyle = BorderStyle.None;
			this._dataGrid.CellBorderStyle = DataGridViewCellBorderStyle.None;
			this._dataGrid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
			cellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
			cellStyle1.BackColor = Color.White;
			cellStyle1.Font = new Font("Open Sans", 12F, FontStyle.Regular, GraphicsUnit.Point, (byte) 238);
			cellStyle1.ForeColor = Color.DimGray;
			cellStyle1.SelectionBackColor = Color.White;
			cellStyle1.SelectionForeColor = Color.DimGray;
			cellStyle1.WrapMode = DataGridViewTriState.False;
			this._dataGrid.ColumnHeadersDefaultCellStyle = cellStyle1;
			this._dataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			cellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
			cellStyle2.BackColor = SystemColors.Window;
			cellStyle2.Font = new Font("Open Sans", 12F, FontStyle.Regular, GraphicsUnit.Point, (byte) 238);
			cellStyle2.ForeColor = Color.DimGray;
			cellStyle2.SelectionBackColor = Color.Gainsboro;
			cellStyle2.SelectionForeColor = Color.Black;
			cellStyle2.WrapMode = DataGridViewTriState.False;
			this._dataGrid.DefaultCellStyle = cellStyle2;
			this._dataGrid.Dock = DockStyle.Fill;
			this._dataGrid.GridColor = Color.White;
			this._dataGrid.Location = new Point(0, 38);
			this._dataGrid.Name = "_dataGrid";
			this._dataGrid.RowTemplate.Height = 25;
			this._dataGrid.RowTemplate.Resizable = DataGridViewTriState.False;
			this._dataGrid.ScrollBars = ScrollBars.Vertical;
			this._dataGrid.ShowCellToolTips = false;
			this._dataGrid.ShowEditingIcon = false;
			this._dataGrid.Size = new Size(500, 37);
			this._dataGrid.TabIndex = 1;
			// 
			// _dateLabel
			// 
			this._dateLabel.BackColor = Color.White;
			this._dateLabel.BorderStyle = BorderStyle.None;
			this._dateLabel.Dock = DockStyle.Top;
			this._dateLabel.Location = new Point(0, 0);
			this._dateLabel.Multiline = false;
			this._dateLabel.Name = "_dateLabel";
			this._dateLabel.ReadOnly = true;
			this._dateLabel.ScrollBars = RichTextBoxScrollBars.None;
			this._dateLabel.Size = new Size(500, 38);
			this._dateLabel.TabIndex = 2;
			this._dateLabel.Text = "";
			this._dateLabel.WordWrap = false;
			// 
			// EntryControl
			// 
			this.AutoScaleDimensions = new SizeF(6F, 13F);
			this.AutoScaleMode = AutoScaleMode.Font;
			this.Controls.Add(this._entryPanel);
			this.Name = "EntryControl";
			this.Size = new Size(500, 300);
			this._entryPanel.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this._dataGrid)).EndInit();
			this.ResumeLayout(false);

		}

	}

}