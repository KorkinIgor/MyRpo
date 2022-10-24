using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereControler : Element
{
    public void ChangeColor()
    {
        app.view.sphereView.GetComponent<Renderer>().material.color = Color.red;
        
    } 
}
