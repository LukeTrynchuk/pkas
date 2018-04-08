using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GreenApple.Poke.Core.Services;

public interface IMathService : IService
{
	int DoMath(int a, int b);
}
