namespace Handsome.Source {

	internal static class RtfFactory {

		public static string BuildClientCard (Client client) {
			return ""
				+ @"{\rtf1\ansi\ansicpg1252\deff0\nouicompat\deflang1033"
				+	@"{\fonttbl"
				+		@"{\f0\fnil\fcharset238 Calibri;}"
				+	@"}"
				+	@"{\colortbl ;\red74\green202\blue168;\red105\green105\blue105;}"
				+	@"{\*\generator Riched20 10.0.15063}"
				+	@"\viewkind4\uc1"
				+	@"\pard\sa200\sl240\slmult1\cf1\b\f0\fs36\lang9  " + FixCaron(client.Name) + @"\cf0\fs72\par "
				+	@"\cf2\fs24   " + FixCaron(client.Owner) + @"\cf0\b0\f0\fs22\par "
				+ @"}";
		}

		public static string BuildClientCardLarge (Client client) {
			return ""
				+ @"{\rtf1\ansi\ansicpg1252\deff0\nouicompat\deflang1033"
				+	@"{\fonttbl"
				+		@"{\f0\fnil\fcharset238 Calibri;}"
				+	@"}"
				+	@"{\colortbl ;\red74\green202\blue168;\red105\green105\blue105;}"
				+	@"{\*\generator Riched20 10.0.15063}"
				+	@"\viewkind4\uc1 "
				+	@"\pard\sa200\sl240\slmult1\cf1\b\f0\fs72\lang9  " + FixCaron(client.Name) + @"\cf0\par"
				+	@""
				+	@"\pard\sa200\sl360\slmult1\cf2\fs36    " + FixCaron(client.Owner) + @"\par "
				+	@""
				+	@"\pard\sa200\sl240\slmult1\b0\fs24\" + Pad(FixCaron(client.Address)) + @"\par "
				+	Pad(@"Dav\f0\'e8na - ") + client.VatID + @"\par "
				+	Pad(@"Telefon - ") + client.Phone + @"\f0\par "
				+ @"}";
		}

		public static string BuildDate (string date) {
			return ""
				+ @"{\rtf1\ansi\ansicpg1252\deff0\nouicompat\deflang1033"
				+	@"{\fonttbl"
				+		@"{\f0\fnil\fcharset238 Calibri;}"
				+	@"}"
				+	@"{\colortbl ;\red102\green102\blue102;\red165\green165\blue165;}"
				+	@"{\*\generator Riched20 10.0.15063}"
				+	@"\viewkind4\uc1 "
				+	@"\pard\sa200\sl276\slmult1\cf1\b\f0\fs40\lang9 " + "\t" + date + @"\cf2\par"
				+ @"}";
		}

		public static string BuildValue (string value) {
			return ""
				+ @"{\rtf1\ansi\ansicpg1252\deff0\nouicompat\deflang1033"
				+	@"{\fonttbl"
				+		@"{\f0\fnil\fcharset238 Calibri;}"
				+	@"}"
				+	@"{\colortbl ;\red102\green102\blue102;\red165\green165\blue165;}"
				+	@"{\*\generator Riched20 10.0.15063}"
				+	@"\viewkind4\uc1 "
				+	@"\pard\sa200\sl276\slmult1\cf1\b\f0\fs40\lang9 " + value + @"\cf2\par"
				+ @"}";
		}

		private static string FixCaron (string text) {
			return text.Replace("č", @"\f0\'e8").Replace("Č", @"\lang1033\'c8\lang9");
		}

		private static string Pad (string text) {
			return "  " + text;
		}

	}

}