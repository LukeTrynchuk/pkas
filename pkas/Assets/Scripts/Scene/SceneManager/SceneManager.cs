namespace GreenApple.Poke.Scene
{

	using System.Collections;
	using System.Collections.Generic;
	using UnityEngine;
	using GreenApple.Poke.Core.Services;
	using UnityEngine.SceneManagement;

	public class SceneManager : MonoBehaviour , ISceneManager
	{

		#region Main Methods
		void Awake()
		{
			RegisterService ();
		}
			
		public void RegisterService ()
		{
			ServiceLocator.Register<ISceneManager> (this);
		}
			
		public void ProceedToNextScene()
		{
			string sceneToLoad = FindNextScene ();

			if (sceneToLoad == null) 
			{
				Debug.LogError ("Unable to find next scene to load...");
				return;
			}

			OpenScene (sceneToLoad);
		}
		#endregion

		#region Utility Methods
		string FindNextScene()
		{
			switch (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().name) 
			{
				case "Preload":
					return "StartAnimationIntro";
					break;

				case "StartAnimationIntro":
					return "StartMenu";
					break;

				default:
					return null;
			}
		}
		#endregion

		#region Low Level Functions

		void OpenScene(string sceneName)
		{
			Scene scene = UnityEngine.SceneManagement.SceneManager.GetSceneByName (sceneName);

			UnityEngine.SceneManagement.SceneManager.LoadScene (sceneName);
		}

		#endregion
	}
}
