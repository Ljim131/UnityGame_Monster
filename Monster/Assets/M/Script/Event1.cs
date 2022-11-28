using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
public class Event1 : MonoBehaviour
{
    
    //public Dialogue dialogue_1;
    //public Dialogue dialogue_2;

    private DialogueManager theDM;
    private OrderManager theOrder;
    private PlayerManager thePlayer;

    private bool flag;
    

    void Start()
    {
        theDM = FindObjectOfType<DialogueManager>();
        theOrder = FindObjectOfType<OrderManager>();
        thePlayer = FindObjectOfType<PlayerManager>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(!Flag && Input.GetKey(KeyCode.Z))
        {
            falg = true;
        }
    }

    IEnumerator EventCoroutine()
    {
        theOrder.PreLoadCharacter();

        theOrder.NotMove();

        theDM.ShowDialogue(dialogue_1);

        yield return new WaitUntil(() => !theDM.talking);

        theOrder.Move("player", "RIGHT");
        theOrder.Move("player", "UP");

        yield return new WaitUntil(() => thePlayer.queue.Count == 0);

        theDM.ShowDialogue(dialogue_2);
        yield return new WaitUntil(() => !theDM.talking);



        theOrder.Move();

    }
}
*/