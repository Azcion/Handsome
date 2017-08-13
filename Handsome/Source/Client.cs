using System;
using System.Collections.Generic;

namespace Handsome.Source {

	[Serializable]
	internal sealed class Client {

		public readonly string Name;
		public readonly string Owner;
		public readonly string Address;
		public readonly string VatID;
		public readonly string Phone;
		public readonly List<Entry> Entries;

		public Client (string name, string owner="", string address="", string vatid="", string phone="") {
			Name = name;
			Owner = owner;
			Address = address;
			VatID = vatid;
			Phone = phone;

			Entries = new List<Entry>();
		}

		public Entry GetMostRecentEntry () {
			if (Entries.Count != 0) {
				return Entries[Entries.Count - 1];
			}

			Entry entry = new Entry(DateTime.Today.ToString("d.M.yyyy"), new List<Row>());
			Entries.Add(entry);

			return entry;
		}

		public void OverwriteEntries (List<Entry> entries) {
			Entries.Clear();

			foreach (Entry entry in entries) {
				Entries.Add(entry);
			}
		}

	}

}