using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static Play;

public class Name : MonoBehaviour
{

    public Text userName;
    // Start is called before the first frame update
    void Start()
    {
        userName.text = Names;
    }

    
}
