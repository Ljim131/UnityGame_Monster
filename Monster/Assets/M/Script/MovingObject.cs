using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingObject : MonoBehaviour
{
    public float speed; 
    public int walkCount; 
    protected int currentWalkCount;

    protected bool npcCanMove = true;

    protected Vector3 vector;
    
    public BoxCollider2D boxCollider;
    public LayerMask layerMask;  //통과가 불가능한 레이어 (가상 벽)
    public Animator animator;



    public string currentMapName;

    public float runSpeed;
    public float applyRunSpeed;
    public bool applyRunFlag = false;


    public bool canMove = true; 




    protected void Move(string _dir)
    {
        StartCoroutine(MoveCoroutine(_dir));
    }

    IEnumerator MoveCoroutine(string _dir)
    {
        npcCanMove = false;
        vector.Set(0, 0, vector.z);
        switch(_dir)
        {
            case "UP":
                vector.y = 1f;
                break;
            case "DOWN":
                vector.y = -1f;
                break;
            case "RIGHT":
                vector.x = 1f;
                break;
            case "LEFT":
                vector.x = -1f;
                break;
        }
        animator.SetFloat("DirX", vector.x);
        animator.SetFloat("DirY", vector.y);
        animator.SetBool("Walking", true);

        while (currentWalkCount < walkCount)
            {
                transform.Translate(vector.x * speed, vector.y * speed, 0); 
                currentWalkCount++;
                yield return new WaitForSeconds(0.01f);
            }
            currentWalkCount=0;
            animator.SetBool("Walking", false);
            npcCanMove = true;
        
    }


    protected bool CheckCollsion()
        {
            RaycastHit2D hit; 

                Vector2 start = transform.position; 
                Vector2 end = start + new Vector2(vector.x * speed * walkCount, vector.y * speed * walkCount); 

                boxCollider.enabled = false;
                hit = Physics2D.Linecast(start, end, layerMask);
                boxCollider.enabled = true;

                if (hit.transform != null)
                    return true;
                return false;
        }
}
