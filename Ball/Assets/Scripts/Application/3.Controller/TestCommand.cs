using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestCommand : VisualController
{
    public override void Execute(object data){
        Debug.Log("Register Manager is sucessful!");
        //VisualMVC.Instance.SendEvent(Consts.C_ChangeScene,"1.Start");
        DestorySelf();
    }

}
