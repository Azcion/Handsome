using System;
using System.Windows.Forms;
using Handsome.Source;

namespace Handsome.Prefabs {

	internal sealed partial class ControlAdderButton : UserControl {

		public ControlAdderButton () {
			InitializeComponent();

			AssembleButton();
		}

		private void AssembleButton () {
			_button.BackColor = Colors.Theme;
			_button.MouseUp += RemoveFocus;
		}

		#region Event handlers

		private void RemoveFocus (object sender, EventArgs e) {
			ActiveControl = _mainPanel;
		}

		#endregion

	}

}