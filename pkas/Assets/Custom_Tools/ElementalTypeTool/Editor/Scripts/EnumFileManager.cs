namespace GreenApple.Poke.Tools.ElementalTypeEditor
{

	using System.Collections;
	using System.Collections.Generic;
	using UnityEngine;
	using System.IO;

	public class EnumFileManager : MonoBehaviour 
	{

		#region Private Variables
		private const string ENUM_FILE_PATH = "/Scripts/System/Types/TypeEnum.cs";
		#endregion

		#region Main Methods
		public static void CreateNewType(string type, Color color)
		{
			if (!ValidateInput (type, color))
				return;

			CheckFilePath ();

		}
		#endregion

		#region Utility Methods
		private static bool ValidateInput(string type, Color color)
		{
			bool value = true;

			value = value && ValidateTypeName (type);
			value = value && ValidateColor (color);

			return value;
		}

		static void CheckFilePath()
		{
			string path = Application.dataPath + ENUM_FILE_PATH;

			if (File.Exists (path))
				return;

			File.Create (path).Dispose();
			//File.Create (path);

			//WaitUntilDone (path);
			CreateBaseFile (path);
		

		}

		static void CreateBaseFile(string path)
		{
			List<string> lines = new List<string> ();

			lines.Add ("namespace GreenApple.Poke.Types");
			lines.Add ("{");
			lines.Add ("public enum Elemental_Type");
			lines.Add ("{");
			lines.Add ("}");
			lines.Add ("}");

			string[] linesToWrite = lines.ToArray ();

			//System.IO.File.WriteAllLines (path, linesToAdd);
		
			using (StreamWriter outputFile = new StreamWriter (path)) 
			{
				foreach (string line in linesToWrite)
					outputFile.WriteLine (line);
			}
		}

		static void WaitUntilDone(string path)
		{
			do{
				
			}while (!File.Exists(path));
		
			CreateBaseFile (path);
		}
		#endregion

		#region Low Level Functions

		static bool ValidateTypeName (string type)
		{
			if (type == null) {
				Debug.LogError ("Type Name must be filled out before creating a new type");
				return false;
			}
			return true;
		}


		static bool ValidateColor (Color color)
		{
			if (color == null) {
				Debug.LogError ("Color is null");
				return false;
			}
			return true;
		}
		#endregion
	}
}