using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Handsome.Source;

namespace Handsome.Prefabs {

	internal sealed partial class ControlEntry {

		private static readonly Color Green = Color.FromArgb(74, 202, 168);

		private Entry _updatedEntry;
		private bool _didPassUpdate;

		public ControlEntry (Entry entry) {
			InitializeComponent();

			AssembleDateLabel(entry.Date);
			AssembleDataGrid(entry.Data);

			Dock = DockStyle.Top;
			ResizeGrid(null, null);
		}

		public bool TryGetEntry (out Entry entry) {
			if (_didPassUpdate) {
				entry = _updatedEntry;
				return true;
			}

			entry = new Entry(null, null);
			return false;
		}

		private void AssembleDateLabel (string date) {
			_dateLabel.Rtf = RtfFactory.BuildDate(date);
			_dateLabel.GotFocus += RemoveFocus;
		}

		private void RemoveFocus (object sender, EventArgs e) {
			ActiveControl = null;
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

			bool didFail = false;
			List<Row> data = new List<Row>();

			for (var i = 0; i < dataGrid.Rows.Count - 1; i++) {
				DataGridViewRow row = dataGrid.Rows[i];
				object quantityCell = row.Cells[0].Value;
				object priceCell = row.Cells[2].Value;

				if (quantityCell == null || priceCell == null) {
					didFail = true;
					continue;
				}

				if (int.TryParse(quantityCell.ToString(), out int quantity) == false ||
					float.TryParse(priceCell.ToString().Replace(',', '.'), out float price) == false) {
					didFail = true;
					continue;
				}

				row.Cells[3].Value = Row.Format(quantity * price);
				object nameCell = row.Cells[1].Value;

				if (nameCell == null) {
					didFail = true;
					continue;
				}

				data.Add(new Row(quantity, nameCell.ToString(), price));
			}

			if (didFail) {
				//todo alert user
				return;
			}

			//todo create history entry if older date

			// Recreate the current entry
			string date = DateTime.Today.ToString("d.M.yyyy");
			_dateLabel.Rtf = RtfFactory.BuildDate(date);

			_didPassUpdate = true;
			_updatedEntry = new Entry(date, data);
		}

	}

}