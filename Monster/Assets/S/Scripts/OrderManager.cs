using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrderManager : MonoBehaviour
{
    private PlayerManager thePlayer;
    private List<MovingObject> characters;

    // Start is called before the first frame update
    void Start()
    {
        thePlayer = FindObjectOfType<PlayerManager>();
    }

    public void PreLoadCharacter()
    {
        characters = ToList();
    }
    
    public List<MovingObject> ToList()
    {
        List<MovingObject> tempList = new List<MovingObject>();
        MovingObject[] temp = FindObjectsOfType<MovingObject>();

        for(int i = 0; i < temp.Length; i++)
        {
            tempList.Add(temp[i]);
        }

        return tempList;

    }
    /*
    public void NotMove()
    {
        thePlayer.notMove = true;
    }

    public void Move()
    {
        thePlayer.notMove = false;
    }
    */

    public void SetThorought(string _name)
    {
        for (int i=0; i < characters.Count; i++)
        {
            if (_name == characters[i].characterName)
            {
                characters[i].boxCollider.enabled = false;
            }
        }
    }
    
    public void Move(string _name, string _dir)
    {
        for (int i = 0; i < characters.Count; i++)
        {
            if (_name == characters[i].characterName)
            {
                characters[i].Move(_dir);
            }
        }
    }
    
    // Update is called once per frame
    void Update()
    {
        
    }
}
