using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Item
{
    public int itemID;  // 아이템의 고유 ID 값, 중복 불가능
    public string itemName; //아이템의 이름, 중복 가능
    public string itemDescription; //아이템 설명
    public int itemCount; // 플레이어가 아이템을 몇 개 소지하고 있는지 (소지개수)
    public Sprite itemIcon; //아이템의 아이콘
    public ItemType itemType;

    public enum ItemType //enum이란 열거라는 뜻
    {
        Key,  //열쇠아이템
        Use  //소모아이템
    }

    public Item(int _itemID, string _itemName, string _itemDes, ItemType _itemType, int _itemCount = 1) //void와 같은 것이 없으므로 생성자로 쓰겠다는 의미이다.
    {
        itemID = _itemID;
        itemName = _itemName;
        itemDescription = _itemDes;
        itemType = _itemType; 
        itemCount = _itemCount;
        itemIcon = Resources.Load("ItemIcon/" + _itemID.ToString(), typeof(Sprite)) as Sprite;
    }
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}