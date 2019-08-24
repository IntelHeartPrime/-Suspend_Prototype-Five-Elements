using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChessModel : VisualModel
{   
    public Consts.Round nowRound;
    public Map[,] Maps=new Map[9,7];
    public override string Name{
        get{
            return Consts.M_ChessModel;
        }
    } 

    void Start(){
        //initiate the round
        this.nowRound=Consts.Round.RED;
        
        //initiate the Map
        for(int y=0;y<9;y++){
            for(int x=0;x<7;x++){
                
            }
        }

        //initiate the Chess

        //initiate the ChessView <MVC>  SendEventToChessView
    }

}


