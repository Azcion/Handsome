using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using Handsome.Source;

namespace Handsome.Prefabs {

	internal sealed partial class FormClient {

		private readonly Client _client;
		private readonly List<Entry> _entries;

		private bool _didChange;
		private bool _didFail;

		private ControlAdderButton _controlAdderButton;

		public FormClient (Client client) {
			InitializeComponent();
			Text = @"Komitent";

			_client = client;
			_entries = new List<Entry>(client.Entries);
			
			AssembleClientCard();
			InsertAdderButton();
			InsertEntries();

			FormClosing += AskIfSaveData;
			Select();
		}

		public void UpdateDate (string date, int id) {
			_didChange = true;
			Entry old = _entries[id];
			Entry entry = new Entry(date, old.IsCheckout, old.Data);
			_entries[id] = entry;
		}

		public Entry UpdateData (List<Row> data, string date, bool didFail, int id) {
			_didChange = true;
			_didFail = didFail;

			if (didFail) {
				return new Entry();
			}

			Entry entry = new Entry(date, _entries[id].IsCheckout, data);
			_entries[id] = entry;

			return entry;
		}

		private void AssembleClientCard () {
			_clientCard.Rtf = RtfFactory.BuildClientCardLarge(_client);
		}

		private void InsertAdderButton () {
			_controlAdderButton = new ControlAdderButton {
				Dock = DockStyle.Top
			};

			if (_controlAdderButton.Controls[0].Controls["_button"] is Button control) {
				control.Click += InsertNewEntry;
			}

			_mainPanel.Controls.Add(_controlAdderButton);
			_clientCard.SendToBack();
		}

		private void InsertEntries () {
			for (int i = 0; i < _entries.Count; i++) {
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

		private void InsertNewEntry (object sender, EventArgs e) {
			_didChange = true;
			int index = _entriesPanel.Controls.Count;
			
			if (_entriesPanel.Controls[index - 1] is ControlEntry ce) {
				string date = DateTime.Today.ToString("d.M.yyyy");
				bool isCheckout = !ce.IsCheckout;
				List<Row> data = new List<Row>();

				Entry entry = new Entry(date, isCheckout, data);
				_entries.Add(entry);
				_entriesPanel.Controls.Add(new ControlEntry(this, entry, index));
			} else {
				_didFail = true;
			}
		}

		#endregion

	}

}