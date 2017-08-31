using System.Drawing;
using System.Windows.Forms;

namespace Handsome.Prefabs {

	internal sealed partial class ControlAddClient : UserControl {

		private static readonly Color Green = Color.FromArgb(74, 202, 168);

		public ControlAddClient () {
			InitializeComponent();

			AssembleButton();
		}

		private void AssembleButton () {
			_button.BackColor = Green;
		}

	}

}