    using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class NPCMove
{
    [Tooltip("NPCMove를 체크하면 NPC가 움직임")]
    public bool NPCmove;

    public string[] direction;

    [Range(1 ,5)] [Tooltip("숫자가 클수록 연속적으로")]
    public int frequency;
    
}
public class NPCManager : MovingObject
{
    [SerializeField]
    public NPCMove npc;


    void Start()
    {
        queue = new Queue<string>();
    }

    public void SetMove()
    {
        StartCoroutine(MoveCoroutine());
    }
    public void SetNotMove()
    {
        //StopAllCoroutine();
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

                yield return new WaitUntil(() => npcCanMove);
                base.Move(npc.direction[i]);

                if(i == npc.direction.Length - 1)
                    i = -1;


            }
        }
    }
    
}