using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tri : MonoBehaviour
{
    public Stage2TransScript Trans ;
    // Start is called before the first frame update
    void Awake()
    
    
    {
        Trans = GameObject.FindObjectOfType<Stage2TransScript>();
        Trans.UpdateScene2(2);    
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
