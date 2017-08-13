using System;
using System.Drawing;
using Handsome.Source;

namespace Handsome.Prefabs {

	internal partial class ControlClient {

		private static readonly Color Green = Color.FromArgb(74, 202, 168);

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
			_button.BackColor = Green;
			_button.Click += OpenFormClient;
		}

		#region Event handlers

		private void OpenFormClient (object sender, EventArgs e) {
			FormClient clientForm = new FormClient(_client);
			clientForm.FormClosed += UpdateValue;

			clientForm.Show();
		}

		private void UpdateValue (object sender, EventArgs e) {
			_clientValue.Rtf = RtfFactory.BuildValue(Row.Format(_client.GetMostRecentEntry().Value));
		}

		#endregion

	}

}