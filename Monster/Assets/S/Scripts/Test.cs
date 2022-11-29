using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]

public class TestMove
{
    public string name;
    public string direction;
}


public class Test : MonoBehaviour
{
    //[SerializeField]
    //public TestMove[] move;

    public string direction;
    private OrderManager theOrder;
    //private NumberSystem theNumber;

    public bool flag;
    //public int correctNumber;
    
    void Start()
    {
        theOrder = FindObjectOfType<OrderManager>();
        //theNumber = FindObjectOfType<NumberSystem>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.name == "Player")
        {
            theOrder.PreLoadCharacter();
            //for(int i = 0; i < move.Length; i++)
            //{
            //    theOrder.Move(move[i].name, move[i].direction);
            //}
            theOrder.Turn("npc1", direction); //npc 이름 확인
            
        }

        /*if(!flag)
        {
            StartCoroutine(ACoroutine());
        }*/

    }

    /*
    IEnumerator ACoroutine()
    {
        flag = true;
        theOrder.NotMove();
        theNumber.ShowNumber(correctNumber);
        yield return new WaitUntil(() => !theNumber.activated);
        theOrder.Move();
    }
    */
}
