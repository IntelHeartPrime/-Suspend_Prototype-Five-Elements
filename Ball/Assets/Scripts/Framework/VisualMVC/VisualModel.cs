using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class VisualModel: MonoBehaviour
{
    //read-only
    public abstract string Name{get;}

    protected void SendEvent(string eveName,object data=null){
        VisualMVC.Instance.SendEvent(eveName,data);
    }
}
