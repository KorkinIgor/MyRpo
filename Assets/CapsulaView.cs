using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CapsulaView : Element
{
    private void OnMouseDown()
    {
        app.controller.capsulaControler.ChangeSize();
    }
}
