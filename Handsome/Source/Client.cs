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

		public Entry GetMostRecentEntry (bool includeCheckouts=true) {
			int lastIndex = Entries.Count - 1;

			if (Entries.Count != 0) {
				Entry last = Entries[lastIndex];

				if (includeCheckouts == false && last.IsCheckout) {
					return Entries[lastIndex - 1];
				}

				return last;
			}

			Entry entry = new Entry(DateTime.Today.ToString("d.M.yyyy"), false, new List<Row>());
			Entries.Add(entry);

			return entry;
		}

		public void OverwriteEntries (IEnumerable<Entry> entries) {
			Entries.Clear();

			foreach (Entry entry in entries) {
				Entries.Add(entry);
			}
		}

	}

}