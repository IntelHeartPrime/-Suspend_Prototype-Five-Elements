using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testController : VisualController
{

    //重写需要加关键字 override
    public override void Execute(object data=null){
        Debug.Log("哈哈哈哈");
        //this.DestorySelf();

        View222 view222=this.GetView<View222>() as View222;
        Debug.Log(view222);
        Debug.Log(view222.info);

    }
}
