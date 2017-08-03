using System;
using System.Collections.Generic;

namespace Handsome.Source {

	internal static class Data {

		public static readonly List<Client> Clients;

		public static bool ShouldSave;

		static Data () {
			Clients = Json.Deserialize<List<Client>>(Json.ReadMostRecent());

			foreach (Client client in Clients) {
				client.Entries.Sort((x, y) => x.Compare(y));
			}

			Clients.Sort((x, y) => string.Compare(x.Name, y.Name, StringComparison.Ordinal));
		}

	}

}