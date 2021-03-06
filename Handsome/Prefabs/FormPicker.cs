﻿using System;
using System.Windows.Forms;
using Handsome.Source;

namespace Handsome.Prefabs {

	internal sealed partial class FormPicker {

		private ControlAdderButton _controlAdderButton;
		private ControlAddClient _controlAddClient;

		public FormPicker () {
			InitializeComponent();
			Text = @"Handsome 1.1";

			InsertClients();
			InsertClientAdder();
			InsertAdderButton();

			Select();

			FormClosing += SaveData;
			ActiveControl = _mainPanel;
		}

		private void InsertClients () {
			foreach (Client client in Data.Clients) {
				InsertClient(client);
			}
		}

		private void InsertClient (Client client) {
			ControlClient cc = new ControlClient(client) {
				Dock = DockStyle.Top
			};

			if (cc.Controls[0].Controls["_clientCard"] is RichTextBox control) {
				control.Rtf = RtfFactory.BuildClientCard(client);
			}

			_mainPanel.Controls.Add(cc);
		}

		private void InsertClientAdder () {
			_controlAddClient = new ControlAddClient {
				Dock = DockStyle.Top,
				Visible = false
			};

			if (_controlAddClient.Controls[0].Controls["_button"] is Button control) {
				control.Click += CreateClientFromInput;
			}

			_mainPanel.Controls.Add(_controlAddClient);
		}

		private void InsertAdderButton () {
			_controlAdderButton = new ControlAdderButton {
				Dock = DockStyle.Top
			};

			if (_controlAdderButton.Controls[0].Controls["_button"] is Button control) {
				control.Click += ShowClientAdder;
			}

			_mainPanel.Controls.Add(_controlAdderButton);
		}

		private void ResetAdder () {
			_controlAddClient.Visible = false;
			_controlAdderButton.Visible = true;
			_controlAddClient.SendToBack();
			_controlAdderButton.SendToBack();
		}

		#region Event handlers

		private void ShowClientAdder (object sender, EventArgs e) {
			_controlAdderButton.Visible = false;
			_controlAddClient.Visible = true;
			_controlAddClient.Controls["_mainPanel"].Select();
		}

		private void CreateClientFromInput (object sender, EventArgs e) {
			Control.ControlCollection c = ((Button)sender).Parent.Controls[1].Controls;

			string name = GetText(c, "name");

			if (name == "") {
				return;
			}

			string owner = GetText(c, "owner");
			string address = GetText(c, "address");
			string vat = GetText(c, "vat");
			string phone0 = GetText(c, "phone0");
			string phone1 = GetText(c, "phone1");

			Client client = new Client(name, owner, address, vat, $"{phone0} | {phone1}");
			Data.Clients.Add(client);
			Data.ShouldSave = true;
			InsertClient(client);
			ResetAdder();
			
			ActiveControl = _mainPanel;
		}

		private void SaveData (object sender, EventArgs e) {
			if (Data.ShouldSave == false) {
				return;
			}

			Json.Save(Json.Serialize(Data.Clients));
		}

		#endregion

		#region Helpers

		private static string GetText (Control.ControlCollection controls, string name) {
			if (!(controls[$"_{name}Panel"].Controls[0] is TextBox textBox)) {
				return "<error>";
			}

			string text = textBox.Text;

			if (name != "name" || text != "") {
				textBox.Text = "";
			}

			return text;
		}

		#endregion

	}

}