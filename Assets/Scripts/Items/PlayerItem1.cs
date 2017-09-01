using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerItem1 : ItemBase {


    public override void func1()
    {
        Debug.Log("Item1 func1");
    }
    public override void Buy(GameObject player)
	{
		if (ownerShipNum > MAX_OWNERSHIP_NUM)
			return;
		
	}

    float time;
    
    void Update () {
        time += Time.deltaTime;
        if (time > 3f) {
            time = 0;
            Debug.Log("Item1 Update");
        }
    }

}
