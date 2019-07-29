using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeSceneCommand : VisualController
{   

    //参数为场景名称
    public override void Execute(object data){
        SceneManager.LoadScene(data as string);
        DestorySelf();
    }

}
