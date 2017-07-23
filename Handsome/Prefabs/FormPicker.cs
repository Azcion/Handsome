using System.Collections.Generic;
using System.Windows.Forms;
using Handsome.Source;

namespace Handsome.Prefabs {

	public partial class FormPicker {

		private List<FormClient> _openClientForms;

		public FormPicker () {
			InitializeComponent();

			_openClientForms = new List<FormClient>();
			
			InsertClients();
		}

		private void InsertClients () {
			foreach (Client client in Data.Clients) {
				ControlClient cc = new ControlClient(client) {
					Dock = DockStyle.Top
				};

				if (cc.Controls[0].Controls["_clientCard"] is RichTextBox control) {
					control.Rtf = RtfFactory.BuildClientCard(client);
				}

				_mainPanel.Controls.Add(cc);
			}
		}

	}

}