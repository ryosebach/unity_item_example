using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerItem2 : MonoBehaviour, IPlayerItem
{

	public void func1()
	{
		Debug.Log("Item1 func1");
	}

	float time;

	void Update()
	{
		time += Time.deltaTime;
		if (time > 2f)
		{
			time = 0;
			Debug.Log("Item2 Update");
		}
	}

    public void Buy(GameObject player)
    {
        throw new NotImplementedException();
    }
}
