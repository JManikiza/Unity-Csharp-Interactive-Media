using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class AnimatorSeperateEvent : MonoBehaviour
{
    public GameObject drawer;
    public bool opened;
    public Animator anim;
    void Start()
    {
        anim = GetComponent<Animator>();
        opened = false;
        
    }

    public void Click()
    {
        if(opened == false)
        {
            anim.Play("DrawerOpen");
            opened = true;
        }else if(opened == true)
        {
            anim.Play("DrawerClose");
            opened = false;
        }
    }
}
