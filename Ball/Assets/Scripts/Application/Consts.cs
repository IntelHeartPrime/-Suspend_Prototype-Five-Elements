using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Consts
{
    //enum
    public enum ELEMENTCONTAINER_TYPE{
        WEAPON=1,
        TREE=2,
        WATER=3,
        FIRE=4,
        WALL=5

    }
    public enum ELEMENT_TYPE
    {
        WEAPON_SIMPLE=1,
        TREE_SIMPLE=2,
        WATER_SIMPLE=3,
        FIRE_SIMPLE=4,
        WALL_SIMPLE=5
    }
    
    public enum ENEMY_TYPE{
        MONSTER_1=1,
        MONSTER_2=2,
        MONSTER_3=3
    }
    
    //Model

    //View
    public const string V_UIMain="V_UIMain";
    //Controller
    public const string C_ChangeScene="C_ChangeScene";
    public const string C_TestCommand="C_TestCommand";
}
