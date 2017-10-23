using System;
using System.IO;
using System.Threading.Tasks;
using MobileApp2;
using MobileApp2.Android;
using Xamarin.Forms;

[assembly: Dependency(typeof(SaveAndLoad_Android))]

namespace MobileApp2.Android
{
	public class SaveAndLoad_Android : ISaveAndLoad
	{
		#region ISaveAndLoad implementation

		public void SaveTextAsync(string filename, string text)
		{
			var path = CreatePathToFile(filename);
			using (StreamWriter sw = File.CreateText(path))
				sw.Write(text);
		}

		public string LoadTextAsync(string filename)
		{
			var path = CreatePathToFile(filename);
			using (StreamReader sr = File.OpenText(path))
				return sr.ReadToEnd();
		}

		public bool FileExists(string filename)
		{
			return File.Exists(CreatePathToFile(filename));
		}

		#endregion

		string CreatePathToFile(string filename)
		{
            var docsPath = Environment.GetFolderPath(Environment.SpecialFolder.Programs);
			return Path.Combine(docsPath, filename);
		}
	}
}