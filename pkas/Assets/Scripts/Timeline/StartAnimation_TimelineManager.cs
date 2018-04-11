namespace GreenApple.Poke.Timeline
{

	using System.Collections;
	using System.Collections.Generic;
	using UnityEngine;
	using UnityEngine.Timeline;
	using UnityEngine.Playables;
	using GreenApple.Poke.Core.Services;
	using GreenApple.Poke.Scene;

	[RequireComponent(typeof(PlayableDirector))]
	public class StartAnimation_TimelineManager : MonoBehaviour 
	{

		#region Private Variables
		PlayableDirector m_director;
		private ServiceReference<ISceneManager> m_sceneManager = new ServiceReference<ISceneManager>();
		#endregion


		#region Main Methods

		void Start()
		{
			m_director = GetComponent<PlayableDirector> ();
		}

		void Update()
		{
			if (!m_director.playableGraph.IsValid()) 
			{
				ChangeScene ();
			}
		}

		#endregion

		#region Utility Methods
		void ChangeScene()
		{
			if (m_sceneManager.isRegistered ())
				m_sceneManager.Reference.ProceedToNextScene ();
		}
			
		#endregion
	}
}
