using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CapsulaControler : Element
{
    public void ChangeSize()
    {
        
        app.view.capsulaView.transform.localScale =new Vector3(2,2,2);
    }

   
}
