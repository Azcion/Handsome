using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using Handsome.Source;

namespace Handsome.Prefabs {

	internal partial class FormClient {

		private readonly Client _client;

		private bool _didChange;

		public FormClient (Client client) {
			InitializeComponent();

			_client = client;
			
			AssembleClientCard();
			InsertEntries();

			FormClosing += AskIfCloseData;
			ActiveControl = _mainPanel;
		}

		public void UpdateEntries (Entry updatedEntry) {
			_didChange = true;

			for (var i = 0; i < _client.Entries.Count; ++i) {
				Entry entry = _client.Entries[i];

				if (entry.Date == updatedEntry.Date) {
					_client.Entries[i] = updatedEntry;
					return;
				}
			}

			_client.Entries.Add(updatedEntry);
		}

		private void AssembleClientCard () {
			_clientCard.Rtf = RtfFactory.BuildClientCardLarge(_client);
		}

		private void InsertEntries () {
			if (_client.Entries.Count == 0) {
				Entry entry = new Entry(DateTime.Today.ToString("d.M.yyyy"), new List<Row>());
				_mainPanel.Controls.Add(new ControlEntry(entry));
			}

			foreach (Entry entry in _client.Entries) {
				_mainPanel.Controls.Add(new ControlEntry(entry));
			}

			_clientCard.SendToBack();
		}

		#region Event handlers

		private void AskIfCloseData (object sender, CancelEventArgs e) {
			if (_didChange) {
				DialogResult answer = MessageBox.Show(
					@"Shranim spremembe?", @"Zapiranje okna", MessageBoxButtons.YesNoCancel);

				switch (answer) {
					case DialogResult.Yes:
						Json.Save(Json.Serialize(_client), _client.Name, Json.Type.Client);
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