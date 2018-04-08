using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GreenApple.Poke.Core.Services;

public class ExampleClient : MonoBehaviour 
{
	#region Private Variables
	private ServiceReference<IMathService> m_MathReference = new ServiceReference<IMathService>();
	private int A = 2;
	private int B = 5;
	#endregion

	#region Main Methods
	void Start () 
	{
		m_MathReference.AddRegistrationHandle (OnMathReferenceInitalized);	
	}

	void OnMathReferenceInitalized()
	{
		int value = m_MathReference.Reference.DoMath (A, B);
		Debug.Log (value);
	}
	#endregion
}
