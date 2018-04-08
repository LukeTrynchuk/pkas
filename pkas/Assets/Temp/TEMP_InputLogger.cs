using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GreenApple.Poke.Core.Services;
using GreenApple.Poke.Input;

public class TEMP_InputLogger : MonoBehaviour 
{

	#region Private Variables
	private ServiceReference<IInputService> m_inputReference;
	#endregion

	void Start () 
	{
		m_inputReference = new ServiceReference<IInputService> ();
	}

	void Update () 
	{
		if (!m_inputReference.isRegistered ()) 
		{
			return;
		}

		if (m_inputReference.Reference.PressedSelect ())
			Debug.Log ("SELECT");

		if (m_inputReference.Reference.PressedCancel ())
			Debug.Log ("CANCEL");

		if (m_inputReference.Reference.PressedMenu ())
			Debug.Log ("MENU");
	}
}
