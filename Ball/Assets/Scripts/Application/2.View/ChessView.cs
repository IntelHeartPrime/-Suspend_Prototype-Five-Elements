using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChessView : VisualView
{   
    /* Para **************/
    public Vector2 LeftUpPos;
    public float Unit_x;
    public float Unit_y;
    public float Para_Scale;

    /* Prefab **************/
    public GameObject Road;
    public GameObject Water;
    public GameObject Pitfall_Red;
    public GameObject Pitfall_Bule;
    public GameObject Nest_Red;
    public GameObject Nest_Bule;
    public GameObject Elephant;
    public GameObject Lion;
    public GameObject Tiger;
    public GameObject LeoPard;
    public GameObject Wolf;
    public GameObject Dog;
    public GameObject Cat;
    public GameObject Mouse;

    private List<GameObject> chesses=new List<GameObject>();
    public override string Name{
        get{
            return Consts.V_ChessView;
        }
    }

    void Awake() {
        //add event
        this.AttationEvents.Add(Consts.VE_InitiateChess);
        chesses.Add(Elephant);
        chesses.Add(Lion);
        chesses.Add(Tiger);
        chesses.Add(LeoPard);
        chesses.Add(Wolf);
        chesses.Add(Dog);
        chesses.Add(Cat);
        chesses.Add(Mouse);

    }
    public override void HandleEvent(string eventName, object data){
        if(eventName==Consts.VE_InitiateChess){
            Debug.Log("Initiate Chess View");
            InitiateGame();
        }
    }

    //在 RegisterManger2中调用，初始化游戏场景
    void InitiateGame(){
        //get the data from chessModel and Show the maps and chess

        Map[,] Maps=((ChessModel)this.GetModel<ChessModel>()).Maps;
        //show maps
        for(int y=0;y<9;y++){
            for(int x=0;x<7;x++){
                Map map_unit=Maps[y,x];
                if(map_unit.type==Consts.MapType.ROAD){
                    Vector3 pos=IndexPosToWorldPos(map_unit.pos);
                    GameObject prefab=GameObject.Instantiate(this.Road,pos,Quaternion.identity);
                    prefab.transform.localScale=new Vector3(Para_Scale,Para_Scale,1);
                    prefab.transform.parent=this.transform;
                }
                else if(map_unit.type==Consts.MapType.WATER){
                    Vector3 pos=IndexPosToWorldPos(map_unit.pos);
                    GameObject prefab=GameObject.Instantiate(this.Water,pos,Quaternion.identity);
                    prefab.transform.localScale=new Vector3(Para_Scale,Para_Scale,1);
                    prefab.transform.parent=this.transform;       
                }
                else if(map_unit.type==Consts.MapType.PITFALL_RED){
                    Vector3 pos=IndexPosToWorldPos(map_unit.pos);
                    GameObject prefab1=GameObject.Instantiate(this.Road,pos,Quaternion.identity);
                    GameObject prefab2=GameObject.Instantiate(this.Pitfall_Red,pos,Quaternion.identity);
                    prefab1.transform.localScale=new Vector3(Para_Scale,Para_Scale,1);
                    prefab2.transform.localScale=new Vector3(Para_Scale,Para_Scale,1);
                    prefab1.transform.parent=this.transform;  
                    prefab2.transform.parent=this.transform;      
                }
                else if(map_unit.type==Consts.MapType.PITFALL_BULE){
                    Vector3 pos=IndexPosToWorldPos(map_unit.pos);
                    GameObject prefab1=GameObject.Instantiate(this.Road,pos,Quaternion.identity);
                    GameObject prefab2=GameObject.Instantiate(this.Pitfall_Bule,pos,Quaternion.identity);
                    prefab1.transform.localScale=new Vector3(Para_Scale,Para_Scale,1);
                    prefab2.transform.localScale=new Vector3(Para_Scale,Para_Scale,1);
                    prefab1.transform.parent=this.transform;  
                    prefab2.transform.parent=this.transform;      
                }
                else if(map_unit.type==Consts.MapType.NEST_RED){
                    Vector3 pos=IndexPosToWorldPos(map_unit.pos);
                    GameObject prefab1=GameObject.Instantiate(this.Road,pos,Quaternion.identity);
                    GameObject prefab2=GameObject.Instantiate(this.Nest_Red,pos,Quaternion.identity);
                    prefab1.transform.localScale=new Vector3(Para_Scale,Para_Scale,1);
                    prefab2.transform.localScale=new Vector3(Para_Scale,Para_Scale,1);
                    prefab1.transform.parent=this.transform;  
                    prefab2.transform.parent=this.transform;      
                }
                else if(map_unit.type==Consts.MapType.NEST_BULE){
                    Vector3 pos=IndexPosToWorldPos(map_unit.pos);
                    GameObject prefab1=GameObject.Instantiate(this.Road,pos,Quaternion.identity);
                    GameObject prefab2=GameObject.Instantiate(this.Nest_Bule,pos,Quaternion.identity);
                    prefab1.transform.localScale=new Vector3(Para_Scale,Para_Scale,1);
                    prefab2.transform.localScale=new Vector3(Para_Scale,Para_Scale,1);
                    prefab1.transform.parent=this.transform;  
                    prefab2.transform.parent=this.transform;      
                }
            }
        }
        //show chess
        List<Chess> Chess_Red=((ChessModel)this.GetModel<ChessModel>()).Red_chess;
        for(int i=0;i<Chess_Red.Count;i++){
            Vector3 pos=IndexPosToWorldPos(Chess_Red[i].pos);
            GameObject prefab=GameObject.Instantiate(this.chesses[i],pos,Quaternion.identity);
            prefab.transform.localScale=new Vector3(Para_Scale,Para_Scale,1);
            prefab.transform.parent=this.transform;
        }

        List<Chess> Chess_Bule=((ChessModel)this.GetModel<ChessModel>()).Bule_chess;
        for(int i=0;i<Chess_Bule.Count;i++){
            Vector3 pos=IndexPosToWorldPos(Chess_Bule[i].pos);
            GameObject prefab=GameObject.Instantiate(this.chesses[i],pos,Quaternion.identity);
            prefab.transform.localScale=new Vector3(Para_Scale,Para_Scale,1);
            prefab.transform.parent=this.transform;
        }


    }

    public Vector3 IndexPosToWorldPos(Pos pos){
        float y=LeftUpPos.y-(pos.y+0.5f)*Unit_y;
        float x=LeftUpPos.x+(pos.x+0.5f)*Unit_x;
        return(new Vector3(x,y,0));
    }
}
