using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Item
{
    public int itemID;  // �������� ���� ID ��, �ߺ� �Ұ���
    public string itemName; //�������� �̸�, �ߺ� ����
    public string itemDescription; //������ ����
    public int itemCount; // �÷��̾ �������� �� �� �����ϰ� �ִ��� (��������)
    public Sprite itemIcon; //�������� ������
    public ItemType itemType;

    public enum ItemType //enum�̶� ���Ŷ�� ��
    {
        Key,  //���������
        Use  //�Ҹ������
    }

    public Item(int _itemID, string _itemName, string _itemDes, ItemType _itemType, int _itemCount = 1) //void�� ���� ���� �����Ƿ� �����ڷ� ���ڴٴ� �ǹ��̴�.
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
