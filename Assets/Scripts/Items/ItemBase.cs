using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemBase : MonoBehaviour, IPlayerItem {


    protected const int MAX_OWNERSHIP_NUM = 3;
	public int ownerShipNum;


	public virtual void Buy(GameObject player)
    {
        Debug.Log("hogehoghoege");
    }

    public virtual void func1()
    {
        Debug.Log("hoge");
    }

}
