using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MonsterManager : MovingObject
{

    public float totargetSpeed;
    public float monsterSpeed;
    public float currentSpeed;

    public float directionChangeInterval;
    public bool followPlayer;

    Coroutine moveCoroutine;
    Rigidbody2D rb2d;
    public CircleCollider2D CircleCollider2D;
    
    
    Transform targetTransform = null;
    Vector3 endPosition;
    float currenAngle = 0;
    
    
    void Start()
    {
        animator = GetComponent<Animator>();
        rb2d = GetComponent<Rigidbody2D>();
        CircleCollider2D = GetComponent<CircleCollider2D>();
        currentSpeed = monsterSpeed;
        StartCoroutine(MonsterRoutine());
    }

    
    void Update()
    {
        Debug.DrawLine(rb2d.position, endPosition, Color.red);
    }

    public IEnumerator MonsterRoutine()
    {
        while (true)
        {
            ChooseNewEndPoint();

            if(moveCoroutine != null)
            {
                StopCoroutine(moveCoroutine);
            }
            moveCoroutine = StartCoroutine(Move(rb2d, currentSpeed));

            yield return new WaitForSeconds(directionChangeInterval);
        }
    }

    void ChooseNewEndPoint()
    {
        currenAngle += Random.Range(0, 360);
        currenAngle = Mathf.Repeat(currenAngle, 360);
        endPosition += Vector3FromAngle(currenAngle);
    }

    Vector3 Vector3FromAngle(float inputAngleDegrees)
    {
        float inputAngleRadians = inputAngleDegrees * Mathf.Deg2Rad;

        return new Vector3(Mathf.Cos(inputAngleRadians), Mathf.Sin(inputAngleRadians), 0);
    
    }
    public IEnumerator Move(Rigidbody2D rigidBodyToMove, float speed)
    {
        float remainingDistance =(transform.position - endPosition).sqrMagnitude;

        while (remainingDistance > float.Epsilon)
        {
            if(targetTransform != null)
            {
                endPosition = targetTransform.position;
            }
            if(rigidBodyToMove != null)
            {
                animator.SetBool("Walking", true);
                Vector3 newPosition = Vector3.MoveTowards(rigidBodyToMove.position, endPosition, speed * Time.deltaTime);

                rb2d.MovePosition(newPosition);
                remainingDistance = (transform.position - endPosition).sqrMagnitude;
            }
            yield return new WaitForFixedUpdate();
        }
        animator.SetBool("Walking", false);
    }

//추적하는 기능
    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Player") && followPlayer)
        {
            currentSpeed = totargetSpeed;
            targetTransform = collision.gameObject.transform;
            if(moveCoroutine != null)
            {
                StopCoroutine(moveCoroutine);
            }

            moveCoroutine = StartCoroutine(Move(rb2d, currentSpeed));
        }
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            animator.SetBool("Walking", false);
            currentSpeed = monsterSpeed;

            if(moveCoroutine != null)
            {
                StopCoroutine(moveCoroutine);
            }
            targetTransform = null;
        }
    }

    void OnDrawGizmos()
    {
        if(CircleCollider2D != null)
        {
            Gizmos.DrawWireSphere(transform.position, CircleCollider2D.radius);
        }
    }



}
