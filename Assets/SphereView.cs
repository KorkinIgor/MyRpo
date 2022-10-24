using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereView : Element
{
    private void OnCollisionEnter(Collision other)
    {
        app.controller.sphereControler.ChangeColor();
    }
}
