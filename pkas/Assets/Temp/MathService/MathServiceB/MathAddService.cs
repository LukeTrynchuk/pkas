using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GreenApple.Poke.Core.Services;

public class MathAddService : MonoBehaviour , IMathService
{

	void Awake()
	{
		RegisterService ();
	}

	public int DoMath(int a, int b)
	{
		return a + b;
	}

	public void RegisterService ()
	{
		ServiceLocator.Register<IMathService> (this);
	}
}
