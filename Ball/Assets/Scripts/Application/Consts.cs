using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Consts
{
    //enum
    public enum Round
    {
        BULE,
        RED
    }
    public enum ChessType
    {
        ELEPHANT=0,
        LION=1,
        TIGER=2,
        LEOPARD=3,
        WOLF=4,
        DOG=5,
        CAT=6,
        MOUSE=7
    }
    
    public enum MapType
    {
        ROAD=0,
        WATER=1,
        PITFALL_RED=2,
        PITFALL_BULE=3,
        NEST_RED=4,
        NEST_BULE=5
    }
    //Model
    public const string M_ChessModel="M_ChessModel";
    //View
    public const string V_UIMain="V_UIMain";

    public const string V_ChessView="V_ChessView";
    
    //Controller
    public const string C_ChangeScene="C_ChangeScene";

    //View_EVENT
    public const string VE_InitiateChess="VE_InitiateChess";
}
