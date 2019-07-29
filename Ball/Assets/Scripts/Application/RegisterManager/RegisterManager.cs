using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RegisterManager : MonoBehaviour
{
    public void Start(){
        //Register Controller
        VisualMVC.Instance.RegisterController(Consts.C_ChangeScene,typeof(ChangeSceneCommand));
        VisualMVC.Instance.SendEvent(Consts.C_ChangeScene,"1.Start");
        
    }
}
