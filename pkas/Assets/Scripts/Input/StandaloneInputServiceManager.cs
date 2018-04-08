namespace GreenApple.Poke.Input
{
	using System.Collections;
	using System.Collections.Generic;
	using UnityEngine;

	public class StandaloneInputServiceManager : MonoBehaviour 
	{

		#region Private Variables
		[SerializeField]
		private GameObject m_standaloneController;
		[SerializeField]
		private GameObject m_standaloneKeyboard;
		private bool m_controllerConnected;
		#endregion

		#region Main Methods
		void Start()
		{
			if (ControllerConnected ()) 
			{
				m_controllerConnected = true;
				m_standaloneController.SetActive (true);
				m_standaloneKeyboard.SetActive (false);
			}

			if (!ControllerConnected ()) 
			{
				m_controllerConnected = false;
				m_standaloneController.SetActive (false);
				m_standaloneKeyboard.SetActive (true);
			}
		}

		void Update () 
		{
			SwitchStandaloneServiceMethod ();
		}

		#endregion

		#region Utility Methods
		private void SwitchStandaloneServiceMethod()
		{
			#if UNITY_STANDALONE
			if(m_controllerConnected && !ControllerConnected())
			{
				m_controllerConnected = false;
				m_standaloneController.SetActive(false);
				m_standaloneKeyboard.SetActive(true);
			}

			if(!m_controllerConnected && ControllerConnected())
			{
				m_controllerConnected = true;
				m_standaloneController.SetActive(true);
				m_standaloneKeyboard.SetActive(false);
			}
			#endif
		}
		
		#endregion

		#region Low Level Functions

		private bool ControllerConnected()
		{
			if (Input.GetJoystickNames ().Length > 0)
				return true;
			return false;
		}
				
		#endregion
	}
}
