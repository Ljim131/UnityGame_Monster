using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DatabaseManager : MonoBehaviour
// ���̵�, ���̺�� �ε�, ������ �� �ѹ����� �������� ���� �ƴ� ����� �� ��� �����ϰ� ������ִ� ����
{
    

    public string[] var_name; //�����̸�
    public float[] var;  //float ���� ���

    public string[] switch_name;
    public bool[] switches; //True, False ���� ���


    public List<Item> itemList = new List<Item>();

    public void UseItem(int _itemID)
    {
        switch(_itemID)
        {
            case 1:
                Debug.Log("ȭ���� ���ȴ�");
                break;
            case 2:
                Debug.Log("��й��� ���ȴ�");
                break;
        }
    }


    void Start()
    {
        itemList.Add(new Item(1, "ȭ�� ����", "ȭ�Ƿ� �� �� �ִ� ������ �� ����.", Item.ItemType.Key));
        itemList.Add(new Item(2, "��й� ����", "���а� �� �� �ִ� ������ �� ����.", Item.ItemType.Key));
        itemList.Add(new Item(3, "���� ����", "ȭ�Ƿ� �� �� �ִ� ������ �� ����.", Item.ItemType.Key));
        itemList.Add(new Item(4, "����", "�̰Ŷ�... ����.. ���� ���°ǰ�?", Item.ItemType.Use));
        itemList.Add(new Item(5, "�ռ���", "���� ���� �� �ִ� �� ����.", Item.ItemType.Use));
        itemList.Add(new Item(6, "���ڵ���̹�", "���縦 Ǯ �� ���� �� ����.", Item.ItemType.Use));
        itemList.Add(new Item(7, "���ڵ���̹�", "���縦 Ǯ �� ���� �� ����.", Item.ItemType.Use));
        itemList.Add(new Item(8, "���� ����", "� ����������!", Item.ItemType.Key));
        itemList.Add(new Item(9, "�ֹ� ����", "�ֹ����� �� �� �ִ� ������ �� ����.", Item.ItemType.Key));
        itemList.Add(new Item(10, "������ ����", "�����Ƿ� �� �� �ִ� ������ �� ����.", Item.ItemType.Key));
        itemList.Add(new Item(11, "ħ�� ����", "ħ�Ƿ� �� �� �ִ� ������ �� ����.", Item.ItemType.Key));
        itemList.Add(new Item(12, "Ŭ��", "�̰ɷ� ������...", Item.ItemType.Use));
    }

   
}
