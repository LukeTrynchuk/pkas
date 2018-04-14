namespace GreenApple.Poke.Scene
{

	using System.Collections;
	using System.Collections.Generic;
	using UnityEngine;
	using GreenApple.Poke.Core.Services;

	public interface ISceneManager : IService
	{
		void ProceedToNextScene();
	}
}
