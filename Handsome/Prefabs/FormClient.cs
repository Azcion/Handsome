using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using Handsome.Source;

namespace Handsome.Prefabs {

	internal partial class FormClient {

		private readonly Client _client;
		private readonly List<Entry> _entries;

		private bool _didChange;
		private bool _didFail;

		private DateTimePicker _date;

		public FormClient (Client client) {
			InitializeComponent();

			_client = client;
			_entries = new List<Entry>(client.Entries);
			
			AssembleClientCard();
			AssembleDatePicker();
			InsertEntries();

			FormClosing += AskIfSaveData;
			Select();
		}

		public void UpdateData (List<Row> data, bool didFail, int id) {
			_didChange = true;
			_didFail = didFail;

			if (didFail) {
				return;
			}

			Entry old = _entries[id];
			Entry entry = new Entry(old.Date, old.IsCheckout, data);
			_entries[id] = entry;
		}

		private void AssembleDatePicker () {
			_date = new DateTimePicker {
				ShowUpDown = true,
				CustomFormat = @"dd.MM.yyyy",
				Format = DateTimePickerFormat.Custom,
				Dock = DockStyle.Top
			};

			_date.SendToBack();
			_mainPanel.Controls.Add(_date);
		}

		private void AssembleClientCard () {
			_clientCard.Rtf = RtfFactory.BuildClientCardLarge(_client);
		}

		private void InsertEntries () {
			for (var i = 0; i < _entries.Count; i++) {
				Entry entry = _entries[i];
				_entriesPanel.Controls.Add(new ControlEntry(this, entry, i));
			}
		}

		#region Event handlers

		private void AskIfSaveData (object sender, CancelEventArgs e) {
			if (_didChange == false) {
				return;
			}

			if (_didFail) {
				DialogResult answer = MessageBox.Show(
					@"Nekatera polja imajo napake. Shranjevanje ni možno. Nadaljujem z zapiranjem okna?",
					@"Zapiranje okna",
					MessageBoxButtons.OKCancel);

				switch (answer) {
					case DialogResult.Cancel:
						e.Cancel = true;
						break;
				}
			} else {
				DialogResult answer = MessageBox.Show(
					@"Shranim spremembe?",
					@"Zapiranje okna",
					MessageBoxButtons.YesNoCancel);

				switch (answer) {
					case DialogResult.Yes:
						Data.ShouldSave = true;
						_client.OverwriteEntries(_entries);
						break;
					case DialogResult.No:
						Data.ShouldSave = false;
						break;
					case DialogResult.Cancel:
						e.Cancel = true;
						break;
				}
			}
		}

		#endregion

	}

}