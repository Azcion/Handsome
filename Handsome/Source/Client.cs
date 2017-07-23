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

	}

}