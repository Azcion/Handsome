using System;
using System.Collections.Generic;

namespace Handsome.Source {

	[Serializable]
	internal struct Entry {

		public readonly string Date;
		public readonly float Value;
		public readonly List<Row> Data;

		public Entry (string date, List<Row> data) {
			Date = date;
			Data = data;
			Value = SumValues(data);
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