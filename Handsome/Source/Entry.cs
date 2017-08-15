using System;
using System.Collections.Generic;

namespace Handsome.Source {

	[Serializable]
	internal struct Entry {

		public readonly string Date;
		public readonly float Value;
		public readonly bool IsCheckout;
		public readonly List<Row> Data;

		private readonly DateTime _date;

		public Entry (string date, bool isCheckout, List<Row> data) {
			Date = date;
			IsCheckout = isCheckout;
			Data = data;
			Value = SumValues(data);

			_date = DateTime.ParseExact(date, "d.M.yyyy", System.Globalization.CultureInfo.InvariantCulture);
		}

		public int Compare (Entry other) {
			return DateTime.Compare(_date, other._date);
		}

		private static float SumValues (IEnumerable<Row> data) {
			float totalValue = 0;

			foreach (Row row in data) {
				totalValue += row.Value;
			}

			return totalValue;
		}

	}

}