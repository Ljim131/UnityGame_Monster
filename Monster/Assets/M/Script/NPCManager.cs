using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCMove
{
    
    public bool NPCmove;

    public string[] direction;

    [Range(1 ,5)]
    public int frequency;
}
public class NPCManager : MovingObject
{
    [SerializeField]
    public NPCMove npc;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(MoveCoroutine());
    }

    public void SetMove()
    {

    }
    public void SetNotMove()
    {

    }

    IEnumerator MoveCoroutine()
    {
        if (npc.direction.Length != 0)
        {
            for(int i = 0; i < npc.direction.Length; i++)
            {
                switch(npc.frequency)
                {
                    case 1:
                        yield return new WaitForSeconds(4f);
                        break;
                    case 2:
                        yield return new WaitForSeconds(3f);
                        break;
                    case 3:
                        yield return new WaitForSeconds(2f);
                        break;
                    case 4:
                        yield return new WaitForSeconds(1f);
                        break;
                    case 5:
                        break;
                    
                }

                base.Move(npc.direction[i]);

                if(i == npc.direction.Length - 1)
                    i = -1;


            }
        }
    }
}
