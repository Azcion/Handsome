using System;
using System.Collections.Generic;
using Handsome.Source;

namespace Handsome.Prefabs {

	internal partial class FormClient {

		private readonly Client _client;

		public FormClient (Client client) {
			InitializeComponent();

			_client = client;

			AssembleClientCard();
			InsertEntries();

			ActiveControl = _mainPanel;
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

	}

}