using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class failZone : MonoBehaviour
{

    public wordManager wordManager;
    
    void OnTriggerEnter2D (Collider2D col)
    {
        if (col.tag =="Word")
        {
            
            wordManager.failedWord();
        }
    }
}
