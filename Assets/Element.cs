using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Element : MonoBehaviour
{

    public Application app
    {
        get
        {
            return GameObject.FindObjectOfType<Application>(); 
            
        }
    }
}
