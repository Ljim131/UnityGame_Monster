
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SelectManager : MonoBehaviour

{
    public GameObject[] Panel;

    int count = 0;

    void Start()
    {
        StartCoroutine(Select());
    }

    void SelectMenu(int num)
    {

        switch (num)
        {
            case 0:
                SceneManager.LoadScene("골목");
                break;
            case 1:

                break;
            case 2:

                break;
            case 3:
                Application.Quit();
                break;
        }
    }

    IEnumerator Select()
    {
        while (true) {
            
            if (Input.GetKeyDown(KeyCode.UpArrow) && count != 0)
            {
                Panel[count].SetActive(false);
                Panel[--count].SetActive(true);
            }

            else if (Input.GetKeyDown(KeyCode.DownArrow) && count != 3)
            {
                Panel[count].SetActive(false);
                Panel[++count].SetActive(true);
            }

            else if (Input.GetKeyDown(KeyCode.Return))
            {
                SelectMenu(count);
            }
                
            yield return null;
        }
        
    }

}

  