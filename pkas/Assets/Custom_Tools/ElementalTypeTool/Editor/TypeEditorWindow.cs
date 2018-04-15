namespace GreenApple.Poke.Tools.ElementalTypeEditor
{
	using System.Collections;
	using System.Collections.Generic;
	using UnityEngine;
	using UnityEditor;

	public class TypeEditorWindow : EditorWindow 
	{
		#region Public Variables
		public static TypeEditorWindow CurWindow;
		#endregion

		#region Private Variables
		private const string WINDOW_NAME = "Type Editor";
		private static GUIStyle titleStyle;

		private static string m_typeName;
		private static Color m_typeColor;
		#endregion

		#region Main Methods
		public static void InitEditorWindow()
		{
			CurWindow = (TypeEditorWindow)EditorWindow.GetWindow<TypeEditorWindow> ();

			GUIContent content = new GUIContent ();
			content.text = WINDOW_NAME;
			CurWindow.titleContent = content;
		}

		void OnGUI()
		{
			DrawTitle ();
			DrawLeftToolsPanel ();
			DrawListTools ();
			DrawEditTool ();
			DrawDeleteTool ();
		}
		#endregion

		#region GUI Functions
		static void DrawTitle ()
		{
			GUILayout.Space (10);
			DrawTitleLabel ("Type Editor");
			GUILayout.Space (10);

			DrawLine ();
		}
			
		static void DrawLeftToolsPanel()
		{
			DrawTitleLabel ("Creation");

			GUILayout.BeginHorizontal ();
			GUILayout.Label ("Type Name : ");
			m_typeName =  EditorGUILayout.TextField (m_typeName, null);
			GUILayout.EndHorizontal ();

			GUILayout.BeginHorizontal ();
			GUILayout.Label ("Type Color : ");
			m_typeColor = EditorGUILayout.ColorField (m_typeColor, null);
			GUILayout.EndHorizontal ();

			if (GUILayout.Button ("Create Type")) 
			{
				EnumFileManager.CreateNewType (m_typeName, m_typeColor);
			}

			DrawLine ();
		}

		static void DrawListTools()
		{
			GUILayout.Space (10);
			DrawTitleLabel ("List");

			if (GUILayout.Button ("List Types")) 
			{
				Debug.Log ("List types");
			}

			DrawLine ();
		}

		static void DrawEditTool()
		{
			GUILayout.Space (10);
			DrawTitleLabel ("Edit");

			DrawLine ();
		}

		static void DrawDeleteTool()
		{
			GUILayout.Space (10);
			DrawTitleLabel ("Delete");

			if (GUILayout.Button ("Delete Type")) 
			{
				Debug.Log ("Deleting type");
			}

			DrawLine ();
		}
		#endregion

		#region Low Level GUI Functions

		static void DrawLine()
		{
			EditorGUILayout.LabelField("", GUI.skin.horizontalSlider);
		}

		static void DrawTitleLabel(string labelValue)
		{
			GUILayout.BeginHorizontal ();
			GUILayout.FlexibleSpace ();
			GUILayout.Label (labelValue);
			GUILayout.FlexibleSpace ();
			GUILayout.EndHorizontal ();
		}

		#endregion
	}
}
