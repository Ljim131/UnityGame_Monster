using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ending : MonoBehaviour
{
    public GameObject go;

    private void OnTriggerstay2D(Collider2D collision)
    {
        if(Input.GetKeyDown(KeyCode.Z))
        {
            go.SetActive(true);
        }
    }
}
