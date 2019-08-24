using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RegisterManger2 : MonoBehaviour
{   
    public VisualModel ChessModel;
    public VisualView ChessView;

    // Start is called before the first frame update
    void  Awake() {
        //register Model
        VisualMVC.Instance.RegisterModel(this.ChessModel);
        this.ChessModel.transform.parent=GameObject.FindGameObjectWithTag("models").gameObject.transform;

        //register View
        VisualMVC.Instance.RegisterView(this.ChessView);
        
    }
    void Start(){

     }
}
