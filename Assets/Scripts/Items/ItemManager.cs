using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemManager : MonoBehaviour
{

    public List<Item> itemList = new List<Item>();

    public GameObject player;
    public GameObject button;
    public Transform itemParentTransform;

    // Use this for initialization
    void Start()
    {

        itemList.Add(new Item(Const.Item.Item1, typeof(PlayerItem1)));
        itemList.Add(new Item(Const.Item.Item2, typeof(PlayerItem2)));
        itemList.Add(new Item(Const.Item.Item3, typeof(PlayerItem3)));
        itemList.Add(new Item(Const.Item.Item4, typeof(PlayerItem4)));


        for (int j = 0; j < itemList.Count; j++)
        {
            Instantiate(button, itemParentTransform);
        }



        var buttonTexts = itemParentTransform.GetComponentsInChildren<Text>();
        var buttons = itemParentTransform.GetComponentsInChildren<Button>();

        int i = 0;
        foreach (var item in itemList)
        {
            if (i >= buttonTexts.Length)
                continue;
            buttonTexts[i].text = item.itemEnum.GetString();
            buttons[i].onClick.AddListener(() =>
            {
                if (player.GetComponent(item.itemType) == null)
                {
                    player.AddComponent(item.itemType);
                }
            });
            i++;
        }
    }
}

public class Item
{
    public Const.Item itemEnum;
    public System.Type itemType;

    public Item(Const.Item itemEnum, System.Type itemType)
    {
        this.itemEnum = itemEnum;
        this.itemType = itemType;
    }
}