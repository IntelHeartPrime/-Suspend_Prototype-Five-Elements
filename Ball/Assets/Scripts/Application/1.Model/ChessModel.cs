using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChessModel : VisualModel
{   
    public Consts.Round nowRound;
    public Map[,] Maps=new Map[9,7];
    public List<Chess> Red_chess=new List<Chess>();
    public List<Chess> Bule_chess=new List<Chess>();
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
                //water,pitfall,nest,road
                //nest RED [0,3] BULE [8,3]
                //water (3<=y<=5 && 1<=x<=2) ||  (3<=y<=5 && 4<=x<=5)
                //pitfall  RED [0,2][0,4][1,3]    BULE[8,2][8,4][7,3]
                if(y==0 && x==3){
                    Maps[y,x]=new Map(Consts.MapType.NEST_RED,new Pos(y,x));
                }
                else if(y==8 && x==3){
                    Maps[y,x]=new Map(Consts.MapType.NEST_BULE,new Pos(y,x));
                }
                else if((y>=3 && y<=5) && (x>=1 && x<=2)){
                    Maps[y,x]=new Map(Consts.MapType.WATER,new Pos(y,x));
                }
                else if((y>=3 && y<=5) && (x>=4 && x<=5)){
                    Maps[y,x]=new Map(Consts.MapType.WATER,new Pos(y,x));
                }
                else if((y==0 && x==2)||(y==0 && x==4)||(y==1 && x==3)){
                    Maps[y,x]=new Map(Consts.MapType.PITFALL_RED,new Pos(y,x));
                }
                else if((y==8 && x==2)||(y==8 && x==4)||(y==7 && x==3)){
                    Maps[y,x]=new Map(Consts.MapType.PITFALL_BULE,new Pos(y,x));
                }else
                {
                    Maps[y,x]=new Map(Consts.MapType.ROAD,new Pos(y,x));
                }
            }
        }

        //initiate the Chess
        //elephant
        this.Red_chess.Add(new Chess(Consts.ChessType.ELEPHANT,new Pos(2,6)));
        this.Bule_chess.Add(new Chess(Consts.ChessType.ELEPHANT,new Pos(6,0)));
        //lion
        this.Red_chess.Add(new Chess(Consts.ChessType.LION,new Pos(0,0)));
        this.Bule_chess.Add(new Chess(Consts.ChessType.LION,new Pos(8,6)));
        //tiger
        this.Red_chess.Add(new Chess(Consts.ChessType.TIGER,new Pos(0,6)));
        this.Bule_chess.Add(new Chess(Consts.ChessType.TIGER,new Pos(8,0)));
        //leopard
        this.Red_chess.Add(new Chess(Consts.ChessType.LEOPARD,new Pos(2,2)));
        this.Bule_chess.Add(new Chess(Consts.ChessType.LEOPARD,new Pos(6,4)));
        //wolf
        this.Red_chess.Add(new Chess(Consts.ChessType.WOLF,new Pos(2,4)));
        this.Bule_chess.Add(new Chess(Consts.ChessType.WOLF,new Pos(6,2)));
        //dog
        this.Red_chess.Add(new Chess(Consts.ChessType.DOG,new Pos(1,1)));
        this.Bule_chess.Add(new Chess(Consts.ChessType.DOG,new Pos(7,5)));
        //cat
        this.Red_chess.Add(new Chess(Consts.ChessType.CAT,new Pos(1,5)));
        this.Bule_chess.Add(new Chess(Consts.ChessType.CAT,new Pos(7,1)));
        //mouse
        this.Red_chess.Add(new Chess(Consts.ChessType.MOUSE,new Pos(2,0)));
        this.Bule_chess.Add(new Chess(Consts.ChessType.MOUSE,new Pos(6,6)));

        //initiate the ChessView <MVC>  SendEventToChessView
        this.SendEvent(Consts.VE_InitiateChess,null);
    }

}


