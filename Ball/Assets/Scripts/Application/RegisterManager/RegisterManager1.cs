using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RegisterManager1 : MonoBehaviour
{
    public VisualView UIMain;
    public void Awake(){
        //Register View
        VisualMVC.Instance.RegisterView(UIMain);
    }
}
