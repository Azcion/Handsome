using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Newtonsoft.Json;

namespace Handsome.Source {

	internal static class Json {

		public static string Serialize<T> (T instance) where T : class {
			return JsonConvert.SerializeObject(instance, Formatting.Indented);
		}

		public static T Deserialize<T> (string serialized) where T : class {
			return JsonConvert.DeserializeObject<T>(serialized);
		}

		public static void Save (string json) {
			string path = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
			path += @"\Azcion\Handsome\";

			new FileInfo(path).Directory?.Create();

			DateTime dt = DateTime.Now;
			string idString = $"{dt.Year}{dt.Month:D2}{dt.Day:D2}{dt.Hour:D2}{dt.Minute:D2}";
			long id = long.Parse(idString);
			path += $"Data.{id}.json";

			File.WriteAllText(path, json, Encoding.Unicode);
		}

		public static string ReadMostRecent () {
			string path = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
			path += @"\Azcion\Handsome\";

			List<FileInfo> files = new List<FileInfo>(new DirectoryInfo(path).GetFiles());

			if (files.Count == 0) {
				return null;
			}

			files.Sort((x, y) => -x.LastWriteTime.CompareTo(y.LastWriteTime));

			foreach (FileInfo file in files) {
				if (file.Name.StartsWith("Data.")) {
					return File.ReadAllText(path + file.Name);
				}
			}

			return null;
		}

	}

}