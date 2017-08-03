using System;
using System.Windows.Forms;
using Handsome.Prefabs;

namespace Handsome.Source {

	internal static class Program {

		[STAThread]
		private static void Main () {
			Application.EnableVisualStyles();
			Application.Run(new FormPicker());
		}

	}

}