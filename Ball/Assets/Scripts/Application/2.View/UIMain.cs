﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIMain : VisualView
{   
    public override string Name
    {
        get{
            return Consts.V_UIMain;
        }
    }
    public override void HandleEvent(string eventName, object data){

    }

    //PlayLevel按钮函数
    public void PlayLevelBtn(){
        VisualMVC.Instance.SendEvent(Consts.C_ChangeScene,"2.SingleLevel");
        Debug.Log("Load Scene: SingleLevel");
    }

    public void MultiPlayerBtn(){
        VisualMVC.Instance.SendEvent(Consts.C_ChangeScene,"3.MultiPlayerLevel");
        Debug.Log("Load Scene: MultiPlayerLevel");
    }
}
