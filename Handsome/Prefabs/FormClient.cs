using System;
using Handsome.Source;

namespace Handsome.Prefabs {

	internal partial class FormClient {

		private readonly Client _client;

		public FormClient (Client client) {
			_client = client;

			InitializeComponent();
			
			AssembleClientCard();
			InsertEntries();
		}

		private void AssembleClientCard () {
			_clientCard.Rtf = RtfFactory.BuildClientCardLarge(_client);
			_clientCard.GotFocus += RemoveFocus;
		}

		private void InsertEntries () {
			foreach (Entry entry in _client.Entries) {
				_entriesPanel.Controls.Add(new ControlEntry(entry));
			}
		}

		private void RemoveFocus (object sender, EventArgs e) {
			ActiveControl = null;
		}

	}

}