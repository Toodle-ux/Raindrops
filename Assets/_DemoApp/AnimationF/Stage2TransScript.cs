using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Stage2TransScript : MonoBehaviour
{
    public int SceneID = 0;
    public Animator anim;     //动画的脚本这一句必写可能就是名字不是ani可能是别的什么。这都不重要
    
    public void Start () {
    anim = GetComponent<Animator>();     //这一句也必写相当于你演戏总要先有舞台一样
    anim.SetBool("Stage2", false);        //初始化为false
    }
        
    public void Update ()
{
    if (SceneID == 2)    //这里用按下事件]
    {
        anim.SetBool("Stage2", true);
        //Stage2TransControl.SetTrigger("isJump");       //请看大神评论
    }
        }
    
    public void UpdateScene2(int ID)
    {
        SceneID = ID;
    }

    

       // if (Input.GetKeyDown(KeyCode.Alpha1))    //这里用按下事件]
       // {
       //     anim.SetBool("Stage2", false);
       //     //Stage2TransControl.SetTrigger("isJump");       //请看大神评论
       // }
        //else                                //这个部分是后添加的
        //{
        //    Stage2TransControl.SetBool("Stage2", true);
        // }

}
