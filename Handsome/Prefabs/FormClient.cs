﻿using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using Handsome.Source;

namespace Handsome.Prefabs {

	internal partial class FormClient {

		private readonly Client _client;

		private List<Entry> _entries;

		private bool _didChange;
		private bool _didFail;

		public FormClient (Client client) {
			InitializeComponent();

			_client = client;
			_entries = new List<Entry>(client.Entries);
			
			AssembleClientCard();
			InsertEntries();

			FormClosing += AskIfSaveData;
			ActiveControl = _mainPanel;
		}

		public void UpdateEntries (Entry updatedEntry, bool didFail) {
			_didChange = true;
			_didFail = didFail;

			for (var i = 0; i < _entries.Count; ++i) {
				Entry entry = _entries[i];

				if (entry.Date == updatedEntry.Date) {
					_entries[i] = updatedEntry;

					return;
				}
			}

			_entries.Add(updatedEntry);

			Control clientCard = _mainPanel.Controls["_clientCard"];

			_mainPanel.Controls.Clear();
			_mainPanel.Controls.Add(clientCard);

			InsertEntries();
		}

		private void AssembleClientCard () {
			_clientCard.Rtf = RtfFactory.BuildClientCardLarge(_client);
		}

		private void InsertEntries () {
			foreach (Entry entry in _entries) {
				_mainPanel.Controls.Add(new ControlEntry(entry));
			}

			_clientCard.SendToBack();
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