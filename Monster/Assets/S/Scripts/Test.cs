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
    [SerializeField]
    public TestMove[] move;

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
            //theOrder;??
            for(int i = 0; i < move.Length; i++)
            {
                theOrder.Move(move[i].name, move[i].direction);
            }
            
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
