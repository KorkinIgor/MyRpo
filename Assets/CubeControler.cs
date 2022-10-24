using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class CubeControler : Element
{
    public void ChancheColor()
    {
        app.model.click++;
        app.view.cubeView.GetComponent<Renderer>().material.color = Color.magenta;
    }
   
}
