using System.Collections.Generic;

namespace Handsome.Source {

	internal static class Data {

		public static readonly List<Client> Clients;

		static Data () {
			Clients = new List<Client>();

			//todo remove

			// First
			Client client = new Client(
				"Cvetličarna Vrtnica",
				"Vesna Koropec, s.p.",
				"Šolska ulica 18, 2314 Zgornja Polskava",
				"94066833",
				"02 803 55 44 | 041 884 011");

			List<Row> data = new List<Row> {
				new Row(110, "voščilnica", 2.8f),
				new Row(6, "A5 voščilnica", 5.0f),
				new Row(4, "opeka", 16),
				new Row(26, "kamen v.", 2.5f),
				new Row(48, "kamen m.", 1.2f)
			};

			client.Entries.Add(new Entry("27.6.2017", data));
			Clients.Add(client);

			// Second
			client = new Client(
				name: "Korporacija Kaktus",
				owner: "Amigo Amigerson",
				address: "Tam Nekje 5, 2222, Kopr",
				phone: "12 2345 53");

			data = new List<Row> {
				new Row(1, "voščilnica", 2.8f),
				new Row(2, "A5 voščilnica", 5.0f)
			};

			client.Entries.Add(new Entry("27.6.2017", data));
			Clients.Add(client);

			foreach (Client c in Clients) {
				Json.Save(Json.Serialize(c), c.Name, Json.Type.Client);
			}

			Json.Save(Json.Serialize(Clients), "Clients", Json.Type.Complete);
		}

	}

}