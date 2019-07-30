using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElementContainer : MonoBehaviour
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

    }

    public void ReversionToFull(){

    }

    /* Add x% MaxCapacity  */
    public void AddMaxCapacity(float rate){

    }

    /*Add x% NowCapacity */
    public void AddNowCapacity(float rate){

    }
}
