using System.Collections;
using System.Collections.Generic;

public class Chess 
{   
    public Consts.ChessType type;
    public Pos pos;
    public Chess(Consts.ChessType type,Pos pos){
        this.type=type;
        this.pos=pos;
    }
}
