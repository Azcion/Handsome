using System.Windows.Forms;
using Handsome.Source;

namespace Handsome.Prefabs {

	internal sealed partial class ControlAddClient : UserControl {

		public ControlAddClient () {
			InitializeComponent();

			AssembleButton();
		}

		private void AssembleButton () {
			_button.BackColor = Colors.Theme;
		}

	}

}