using System;
using System.Windows.Forms;
using Handsome.Source;

namespace Handsome.Prefabs {

	public partial class FormPicker {

		private ControlAddClient _controlAddClient;

		public FormPicker () {
			InitializeComponent();
			
			InsertClients();
			InsertClientAdder();
			InsertAdderButton();

			ActiveControl = _mainPanel;
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

		private void InsertClientAdder () {
			_controlAddClient = new ControlAddClient {
				Dock = DockStyle.Top,
				Visible = false
			};

			_mainPanel.Controls.Add(_controlAddClient);
		}

		private void InsertAdderButton () {
			ControlAdderButton cab = new ControlAdderButton {
				Dock = DockStyle.Top
			};

			if (cab.Controls[0].Controls["_button"] is Button control) {
				control.Click += ShowClientAdder;
			}

			_mainPanel.Controls.Add(cab);
		}

		#region Event handlers

		private void ShowClientAdder (object sender, EventArgs e) {
			if (sender is Button control) {
				control.Parent.Parent.Visible = false;
				_controlAddClient.Visible = true;
			}			
		}

		#endregion

	}

}