using System;
using System.IO;
using System.Text;
using Newtonsoft.Json;

namespace Handsome.Source {

	internal static partial class Json {

		public static string Serialize<T> (T instance) where T : class {
			return JsonConvert.SerializeObject(instance, Formatting.Indented);
		}

		public static T Deserialize<T> (string serialized) where T : class {
			return JsonConvert.DeserializeObject<T>(serialized);
		}

		public static void Save (string json, string name, Type type) {
			string path = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
			path += @"\Azcion\Handsome\";

			new FileInfo(path).Directory?.Create();

			path += $"{Enum.GetName(typeof(Type), type)}.{name.Replace(' ', '_')}.json";
			File.WriteAllText(path, json, Encoding.Unicode);
		}

	}

}