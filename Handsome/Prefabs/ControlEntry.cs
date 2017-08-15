using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Handsome.Source;

namespace Handsome.Prefabs {

	internal sealed partial class ControlEntry {

		private static readonly Color Green = Color.FromArgb(74, 202, 168);

		private readonly FormClient _form;

		public ControlEntry (FormClient form, Entry entry) {
			InitializeComponent();

			_form = form;

			AssembleDateLabel(entry.Date);
			AssembleDataGrid(entry.Data);

			Dock = DockStyle.Top;
			ResizeGrid(null, null);
		}

		private static void SetStyle (ref DataGridViewCell cell, bool restore = false) {
			if (restore) {
				if (cell.RowIndex % 2 == 0) {
					cell.Style.BackColor = cell.DataGridView.DefaultCellStyle.BackColor;
					cell.Style.ForeColor = cell.DataGridView.DefaultCellStyle.ForeColor;
				} else {
					cell.Style.BackColor = cell.DataGridView.AlternatingRowsDefaultCellStyle.BackColor;
					cell.Style.ForeColor = cell.DataGridView.AlternatingRowsDefaultCellStyle.ForeColor;
				}

				return;
			}

			cell.Style.BackColor = Color.IndianRed;
			cell.Style.ForeColor = Color.White;
		}

		private void AssembleDateLabel (string date) {
			_dateLabel.Rtf = RtfFactory.BuildDate(date);
			_dateLabel.GotFocus += RemoveFocus;
		}

		private void AssembleDataGrid (IEnumerable<Row> data) {
			_dataGrid.ColumnCount = 4;
			_dataGrid.Columns[0].Name = "Količina";
			_dataGrid.Columns[1].Name = "Izdelek";
			_dataGrid.Columns[2].Name = "Cena/kos";
			_dataGrid.Columns[3].Name = "Vrednost";

			foreach (Row row in data) {
				int index = _dataGrid.Rows.Add(row.Stringify());
				_dataGrid.Rows[index].Cells[3].ReadOnly = true;
			}

			_dataGrid.BackgroundColor = Green;

			ResizeGrid(null, null);
			_dataGrid.UserAddedRow += ResizeGrid;
			_dataGrid.CellValueChanged += UpdateGrid;
		}

		private void RecreateEntry (List<Row> data, bool didFail) {
			string date = _form.GetDate();
			_dateLabel.Rtf = RtfFactory.BuildDate(date);

			FormClient parent = ParentForm as FormClient;
			parent?.UpdateEntries(new Entry(date, data), didFail);
		}

		#region Event handlers

		private void RemoveFocus (object sender, EventArgs e) {
			ActiveControl = null;
		}

		private void ResizeGrid (object sender, EventArgs e) {
			int h = _dataGrid.ColumnHeadersHeight + _dateLabel.Height;
			h += _dataGrid.RowCount * _dataGrid.RowTemplate.Height;

			if (_dataGrid.RowCount < 8) {
				h += 4;
			}

			_entryPanel.Height = h;
		}

		private void UpdateGrid (object sender, EventArgs e) {
			DataGridView dataGrid = sender as DataGridView;

			if (dataGrid == null) {
				return;
			}

			List<Row> data = new List<Row>();
			bool didFail = false;

			for (var i = 0; i < dataGrid.RowCount - 1; i++) {
				DataGridViewRow row = dataGrid.Rows[i];
				DataGridViewCell quantityCell = row.Cells[0];
				DataGridViewCell nameCell = row.Cells[1];
				DataGridViewCell priceCell = row.Cells[2];

				if (int.TryParse(quantityCell.Value?.ToString(), out int quantity) == false) {
					SetStyle(ref quantityCell);
					didFail = true;
				} else {
					SetStyle(ref quantityCell, true);
				}

				if (float.TryParse(priceCell.Value?.ToString().Replace(',', '.'), out float price) == false) {
					SetStyle(ref priceCell);
					didFail = true;
				} else {
					SetStyle(ref priceCell, true);
				}

				row.Cells[3].Value = Row.Format(quantity * price);

				if (nameCell.Value == null) {
					SetStyle(ref nameCell);
					didFail = true;
				} else {
					SetStyle(ref nameCell, true);
				}

				if (didFail == false) {
					data.Add(new Row(quantity, nameCell.Value?.ToString(), price));
				}
			}

			// Last row
			DataGridViewCellCollection cells = dataGrid.Rows[dataGrid.RowCount - 1].Cells;
			int failCount = 0;

			if (int.TryParse(cells[0].Value?.ToString(), out int lastCellQuantity) == false) {
				lastCellQuantity = 0;
				++failCount;
			}

			if (float.TryParse(cells[2].Value?.ToString().Replace(',', '.'), out float lastCellPrice) == false) {
				lastCellPrice = 0;
				++failCount;
			}

			string lastCellName = "";

			if (cells[1].Value == null) {
				++failCount;
			} else {
				lastCellName = cells[1].Value.ToString();
			}

			// Add last cell without style change if it's not empty
			if (failCount < 3) {
				data.Add(new Row(lastCellQuantity, lastCellName, lastCellPrice));
			}

			//todo create history entry if older date

			RecreateEntry(data, didFail);
		}

		#endregion

	}

}