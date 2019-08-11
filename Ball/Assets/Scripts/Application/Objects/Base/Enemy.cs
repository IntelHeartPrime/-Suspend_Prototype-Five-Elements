using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy 
{
    public Consts.ENEMY_TYPE Type;
    public float MaxHP;
    public float NowHP;
    public float MoveSpeed;
    public float Level;

    public void ReduceHP(float count){
        this.NowHP-=count;
    }
    public void ReduceHP_Rate(float rate){
        this.NowHP=(1-rate)*NowHP;
    }

    public void ReduceHP_To_Rate(float rate){
        float HP_target=this.MaxHP*rate;
        if(HP_target>NowHP){
            NowHP=HP_target;
        }
    }

}
