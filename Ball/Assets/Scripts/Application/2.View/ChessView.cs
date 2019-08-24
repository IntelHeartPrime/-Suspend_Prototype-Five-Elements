using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChessView : VisualView
{   

    public override string Name{
        get{
            return Consts.V_ChessView;
        }
    }

    public override void HandleEvent(string eventName, object data){

    }

    //在 RegisterManger2中调用，初始化游戏场景
    void InitiateGame(){
        
    }
}
