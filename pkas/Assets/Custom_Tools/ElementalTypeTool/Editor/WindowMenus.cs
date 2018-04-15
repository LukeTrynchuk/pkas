namespace GreenApple.Poke.Tools.ElementalTypeEditor
{

	using System.Collections;
	using System.Collections.Generic;
	using UnityEngine;
	using UnityEditor;

	public class WindowMenus
	{
		[MenuItem("Tools/PokeEngine/Types/Editor")]
		public static void InitTypeEditor()
		{
			TypeEditorWindow.InitEditorWindow ();
		}

	}
}