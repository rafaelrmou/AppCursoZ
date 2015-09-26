using System;

namespace CRUD.Droid
{
	public class FileAcessHelper
	{
		public static string GetLocalFilePath(string fileName)
		{
			string path = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
			return System.IO.Path.Combine(path, fileName);
		}
	}
}

