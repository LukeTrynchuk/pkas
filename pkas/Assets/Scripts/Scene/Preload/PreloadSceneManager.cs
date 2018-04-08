namespace GreenApple.Poke.Scene
{

	using System.Collections;
	using System.Collections.Generic;
	using UnityEngine;
	using UnityEngine.SceneManagement;

	public class PreloadSceneManager : MonoBehaviour 
	{
		#region Main Methods
		void LateUpdate()
		{
			SceneManager.LoadScene (1);
		}

		#endregion
	}
}
