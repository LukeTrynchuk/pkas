namespace GreenApple.Poke.General
{
	using System.Collections;
	using System.Collections.Generic;
	using UnityEngine;

	public class DoNotDestroyOnLoad : MonoBehaviour 
	{
		#region Main Methods
		void Awake () 
		{
			DontDestroyOnLoad (this.gameObject);	
		}
		#endregion
	}
}
