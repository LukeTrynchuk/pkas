namespace GreenApple.Poke.Scene
{

	using System.Collections;
	using System.Collections.Generic;
	using UnityEngine;
	using UnityEngine.SceneManagement;
	using GreenApple.Poke.Core.Services;
	using GreenApple.Poke.Scene;

	public class LoadStartupSceneOnceInitialized : MonoBehaviour 
	{
		#region Private Variables
		private ServiceReference<ISceneManager> m_sceneManager = new ServiceReference<ISceneManager>();
		#endregion

		#region Main Methods
		void Start()
		{
			m_sceneManager.AddRegistrationHandle (HandleSceneManagerRegistered);
		}

		void HandleSceneManagerRegistered()
		{
			m_sceneManager.Reference.ProceedToNextScene ();
		}

		#endregion
	}
}
