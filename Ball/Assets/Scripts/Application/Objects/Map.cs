using System.Collections;
using System.Collections.Generic;

public class Map{
    public Consts.MapType type;
    public Pos pos;

    public Map(Consts.MapType type,Pos pos){
        this.type=type;
        this.pos=pos;
    }
}
