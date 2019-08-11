using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElementContainer
{
    public Consts.ELEMENTCONTAINER_TYPE Type;
    public int Level;
    public float MaxCapacity;
    public float NowCapacity;
    public float Cd;
    public float ReversionSpeed;
    public float ConsumeUnit;

    //Register Sons
    public Consts.ELEMENT_TYPE[] Sons;

    public bool IsSelected=false;

    
    ////Functions
    /*Reduce capacity while use it */
    public void ConsumeOnce(){
        this.NowCapacity-=this.ConsumeUnit;
    }

    public void ReversionToFull(){
        this.NowCapacity=MaxCapacity;
    }

    /* Add x% MaxCapacity  */
    public void AddMaxCapacity(float rate){
        MaxCapacity=(1+rate)*MaxCapacity;
    }

    /*Add x% NowCapacity */
    public void AddNowCapacity(float rate){
        NowCapacity=(1+rate)*NowCapacity;
    }

    public void Execute(){

    }
}
