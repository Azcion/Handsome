using System.Drawing;
using System.Windows.Forms;

namespace Handsome.Prefabs {

	sealed partial class ControlEntry : UserControl {

		private Panel _labelsPanel;
		private TextBox _valueLabel;
		private TextBox _dateLabel;
		private TextBox _checkoutLabel;
		private Panel _entryPanel;
		private DataGridView _dataGrid;

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
			this._labelsPanel = new Panel();
			this._dateLabel = new TextBox();
			this._checkoutLabel = new TextBox();
			this._valueLabel = new TextBox();
			this._entryPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this._dataGrid)).BeginInit();
			this._labelsPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// _entryPanel
			// 
			this._entryPanel.AutoScroll = true;
			this._entryPanel.AutoSize = true;
			this._entryPanel.BackColor = Color.White;
			this._entryPanel.Controls.Add(this._dataGrid);
			this._entryPanel.Controls.Add(this._labelsPanel);
			this._entryPanel.Dock = DockStyle.Top;
			this._entryPanel.Location = new Point(0, 0);
			this._entryPanel.Name = "_entryPanel";
			this._entryPanel.Size = new Size(500, 29);
			this._entryPanel.TabIndex = 0;
			// 
			// _dataGrid
			// 
			this._dataGrid.AllowUserToResizeColumns = false;
			this._dataGrid.AllowUserToResizeRows = false;
			cellStyle0.Alignment = DataGridViewContentAlignment.MiddleLeft;
			cellStyle0.BackColor = Color.WhiteSmoke;
			cellStyle0.Font = new Font("Open Sans", 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(238)));
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
			cellStyle1.Font = new Font("Open Sans", 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(238)));
			cellStyle1.ForeColor = Color.DimGray;
			cellStyle1.SelectionBackColor = Color.White;
			cellStyle1.SelectionForeColor = Color.DimGray;
			cellStyle1.WrapMode = DataGridViewTriState.False;
			this._dataGrid.ColumnHeadersDefaultCellStyle = cellStyle1;
			this._dataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			cellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
			cellStyle2.BackColor = SystemColors.Window;
			cellStyle2.Font = new Font("Open Sans", 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(238)));
			cellStyle2.ForeColor = Color.DimGray;
			cellStyle2.SelectionBackColor = Color.Gainsboro;
			cellStyle2.SelectionForeColor = Color.Black;
			cellStyle2.WrapMode = DataGridViewTriState.False;
			this._dataGrid.DefaultCellStyle = cellStyle2;
			this._dataGrid.Dock = DockStyle.Fill;
			this._dataGrid.GridColor = Color.White;
			this._dataGrid.Location = new Point(0, 29);
			this._dataGrid.Name = "_dataGrid";
			this._dataGrid.RowTemplate.Height = 25;
			this._dataGrid.RowTemplate.Resizable = DataGridViewTriState.False;
			this._dataGrid.ScrollBars = ScrollBars.Vertical;
			this._dataGrid.ShowCellToolTips = false;
			this._dataGrid.ShowEditingIcon = false;
			this._dataGrid.Size = new Size(500, 0);
			this._dataGrid.AutoSize = true;
			// 
			// _labelsPanel
			// 
			this._labelsPanel.Controls.Add(this._dateLabel);
			this._labelsPanel.Controls.Add(this._checkoutLabel);
			this._labelsPanel.Controls.Add(this._valueLabel);
			this._labelsPanel.Dock = DockStyle.Top;
			this._labelsPanel.Location = new Point(0, 0);
			this._labelsPanel.Name = "_labelsPanel";
			this._labelsPanel.Size = new Size(500, 29);
			// 
			// _dateLabel
			// 
			this._dateLabel.Anchor = AnchorStyles.Top;
			this._dateLabel.BorderStyle = BorderStyle.None;
			this._dateLabel.Font = new Font("Open Sans", 15.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
			this._dateLabel.Location = new Point(175, 0);
			this._dateLabel.Name = "_dateLabel";
			this._dateLabel.Size = new Size(150, 29);
			this._dateLabel.Text = "Date";
			this._dateLabel.TextAlign = HorizontalAlignment.Center;
			// 
			// _checkoutLabel
			// 
			this._checkoutLabel.BorderStyle = BorderStyle.None;
			this._checkoutLabel.Dock = DockStyle.Left;
			this._checkoutLabel.Enabled = false;
			this._checkoutLabel.Font = new Font("Open Sans", 15.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
			this._checkoutLabel.Location = new Point(0, 0);
			this._checkoutLabel.Name = "_checkoutLabel";
			this._checkoutLabel.Size = new Size(150, 29);
			this._checkoutLabel.Text = "CheckOut";
			this._checkoutLabel.TextAlign = HorizontalAlignment.Center;
			// 
			// _valueLabel
			// 
			this._valueLabel.BorderStyle = BorderStyle.None;
			this._valueLabel.Dock = DockStyle.Right;
			this._valueLabel.Enabled = false;
			this._valueLabel.Font = new Font("Open Sans", 15.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
			this._valueLabel.Location = new Point(350, 0);
			this._valueLabel.Name = "_valueLabel";
			this._valueLabel.Size = new Size(150, 29);
			this._valueLabel.Text = "Value";
			this._valueLabel.TextAlign = HorizontalAlignment.Center;
			// 
			// ControlEntry
			// 
			this.AutoScaleDimensions = new SizeF(6F, 13F);
			this.AutoScaleMode = AutoScaleMode.Font;
			this.Controls.Add(this._entryPanel);
			this.Name = "ControlEntry";
			this.Size = new Size(500, 300);
			this._entryPanel.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this._dataGrid)).EndInit();
			this._labelsPanel.ResumeLayout(false);
			this._labelsPanel.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
		}

	}

}