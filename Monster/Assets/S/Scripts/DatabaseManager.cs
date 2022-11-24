using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DatabaseManager : MonoBehaviour
// 씬이동, 세이브와 로드, 아이템 등 한번쓰고 없어지는 것이 아닌 기록한 후 사용 가능하게 만들어주는 역할
{
    

    public string[] var_name; //변수이름
    public float[] var;  //float 값을 기억

    public string[] switch_name;
    public bool[] switches; //True, False 값을 기억


    public List<Item> itemList = new List<Item>();

    public void UseItem(int _itemID)
    {
        switch(_itemID)
        {
            case 1:
                Debug.Log("화실이 열렸다");
                break;
            case 2:
                Debug.Log("비밀방이 열렸다");
                break;
        }
    }


    void Start()
    {
        itemList.Add(new Item(1, "화실 열쇠", "화실로 갈 수 있는 열쇠인 것 같다.", Item.ItemType.Key));
        itemList.Add(new Item(2, "비밀방 열쇠", "어디론가 갈 수 있는 열쇠인 것 같다.", Item.ItemType.Key));
        itemList.Add(new Item(3, "서재 열쇠", "화실로 갈 수 있는 열쇠인 것 같다.", Item.ItemType.Key));
        itemList.Add(new Item(4, "세재", "이거랑... 뭐랑.. 같이 쓰는건가?", Item.ItemType.Use));
        itemList.Add(new Item(5, "손수건", "무언가 닦을 수 있는 것 같다.", Item.ItemType.Use));
        itemList.Add(new Item(6, "십자드라이버", "나사를 풀 수 있을 것 같다.", Item.ItemType.Use));
        itemList.Add(new Item(7, "일자드라이버", "나사를 풀 수 있을 것 같다.", Item.ItemType.Use));
        itemList.Add(new Item(8, "정문 열쇠", "어서 빠져나가자!", Item.ItemType.Key));
        itemList.Add(new Item(9, "주방 열쇠", "주방으로 갈 수 있는 열쇠인 것 같다.", Item.ItemType.Key));
        itemList.Add(new Item(10, "집무실 열쇠", "집무실로 갈 수 있는 열쇠인 것 같다.", Item.ItemType.Key));
        itemList.Add(new Item(11, "침실 열쇠", "침실로 갈 수 있는 열쇠인 것 같다.", Item.ItemType.Key));
        itemList.Add(new Item(12, "클립", "이걸로 수갑을...", Item.ItemType.Use));
    }

   
}
