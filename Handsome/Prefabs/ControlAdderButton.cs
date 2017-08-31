using System;
using System.Drawing;
using System.Windows.Forms;

namespace Handsome.Prefabs {

	internal sealed partial class ControlAdderButton : UserControl {

		private static readonly Color Green = Color.FromArgb(74, 202, 168);

		public ControlAdderButton () {
			InitializeComponent();

			AssembleButton();
		}

		private void AssembleButton () {
			_button.BackColor = Green;
			_button.MouseUp += RemoveFocus;
		}

		#region Event handlers

		private void RemoveFocus (object sender, EventArgs e) {
			ActiveControl = _mainPanel;
		}

		#endregion

	}

}