namespace GreenApple.Poke.Input
{
	using System.Collections;
	using System.Collections.Generic;
	using UnityEngine;
	using GreenApple.Poke.Core.Services;

	public interface IInputService : IService 
	{
		Vector2 GetMovementVector();
		bool PressedSelect();
		bool PressedCancel();
		bool PressedMenu();
	}
}
