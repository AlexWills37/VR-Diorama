using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FreezeAnimation : MonoBehaviour
{
    [SerializeField] private Animator myAnimationController;

    void Start()
    {
        
    }

    //Start the animation when hover starts
    public void unfreezeAnimation()
    {
        myAnimationController.speed = 1;
    }

    //Stop the animation when hover ends
    public void freezeAnimation()
    {
        myAnimationController.speed = 0;
    }
}
