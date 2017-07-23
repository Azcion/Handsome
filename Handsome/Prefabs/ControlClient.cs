using System;
using System.Drawing;
using Handsome.Source;

namespace Handsome.Prefabs {

	internal partial class ControlClient {

		private static readonly Color Green = Color.FromArgb(74, 202, 168);

		private readonly Client _client;

		public ControlClient (Client client) {
			InitializeComponent();

			AssembleValue(client);
			AssembleCard(client);
			AssembleButton();

			_client = client;

			_button.Click += OpenFormClient;
			_button.MouseUp += RemoveFocus;
			_clientCard.MouseUp += RemoveFocus;
			_clientValue.MouseUp += RemoveFocus;
		}

		private void AssembleValue (Client client) {
			float totalValue = 0;

			foreach (Entry entry in client.Entries) {
				totalValue += entry.Value;
			}

			_clientValue.Rtf = RtfFactory.BuildValue(Row.Format(totalValue));
		}

		private void AssembleCard (Client client) {
			_clientCard.Rtf = RtfFactory.BuildClientCard(client);
		}

		private void AssembleButton () {
			_button.BackColor = Green;
		}

		#region Event handlers

		private void OpenFormClient (object sender, EventArgs e) {
			FormClient clientForm = new FormClient(_client);
			clientForm.Show();
		}

		private void RemoveFocus (object sender, EventArgs e) {
			ActiveControl = null;
		}

		#endregion

	}

}