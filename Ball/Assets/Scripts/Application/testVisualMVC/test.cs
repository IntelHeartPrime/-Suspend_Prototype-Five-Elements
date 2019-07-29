using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{   
    public GameObject ViewPrefab;
    public View222 view222;
    // Start is called before the first frame update
    void Start()
    {   
        view222=ViewPrefab.GetComponent<View222>();

        //注册MVC
        VisualMVC.Instance.RegisterController(VisualConsts.E_test,typeof(testController));

        VisualMVC.Instance.SendEvent(VisualConsts.E_test,"test");

        VisualMVC.Instance.RegisterView(view222);
        Debug.Log((VisualMVC.Instance.Views[VisualConsts.V_View222] as View222).info);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
