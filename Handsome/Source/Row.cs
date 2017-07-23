using System;

namespace Handsome.Source {

	[Serializable]
	internal struct Row {

		public readonly int Quantity;
		public readonly string Name;
		public readonly float Price;
		public readonly float Value;

		public Row (int quantity, string name, float price) {
			Quantity = quantity;
			Name = name;
			Price = price;
			Value = (float) Math.Round(quantity * price, 2);
		}

		public object[] Stringify () {
			return new object[] {Quantity.ToString(), Name, Format(Price), Format(Value)};
		}

		public static string Format (float value) {
			return value.ToString("0.00").Replace('.', ',');
		}

	}

}