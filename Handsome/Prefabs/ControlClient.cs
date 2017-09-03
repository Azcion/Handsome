using System;
using Handsome.Source;

namespace Handsome.Prefabs {

	internal sealed partial class ControlClient {

		private readonly Client _client;

		public ControlClient (Client client) {
			InitializeComponent();

			_client = client;

			AssembleValue();
			AssembleCard();
			AssembleButton();
		}

		private void AssembleValue () {
			UpdateValue(null, null);
			_clientValue.Enabled = false;
		}

		private void AssembleCard () {
			_clientCard.Rtf = RtfFactory.BuildClientCard(_client);
			_clientCard.Enabled = false;
		}

		private void AssembleButton () {
			_button.BackColor = Colors.Theme;
			_button.Click += OpenFormClient;
		}

		#region Event handlers

		private void OpenFormClient (object sender, EventArgs e) {
			FormClient clientForm = new FormClient(_client);
			clientForm.FormClosed += UpdateValue;

			clientForm.Show();
		}

		private void UpdateValue (object sender, EventArgs e) {
			_clientValue.Rtf = RtfFactory.BuildValue(Row.Format(_client.GetMostRecentEntry(false).Value));
		}

		#endregion

	}

}