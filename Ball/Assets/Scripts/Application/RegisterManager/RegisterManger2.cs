using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RegisterManger2 : MonoBehaviour
{
    // Start is called before the first frame update
    void  Awake() {
        //Register Controller
        VisualMVC.Instance.RegisterController(Consts.C_TestCommand,typeof(TestCommand));
    }
    void Start(){
        VisualMVC.Instance.SendEvent(Consts.C_TestCommand,"");
    }
}
