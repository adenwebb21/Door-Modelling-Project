using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationManager : MonoBehaviour {

    public Animator bolt, latch, padlock, bar, door;

    public void TriggerAnimation(string name)
    {
        switch(name)
        {
            case "latch":
                latch.SetTrigger(name);
                break;
            case "bolt":
                bolt.SetTrigger(name);
                break;
            case "padlock":
                padlock.SetTrigger(name);
                break;
            case "bar":
                bar.SetTrigger(name);
                break;
            case "door":
                door.SetTrigger(name);
                break;

        }

    }

    //private bool CheckIfAnimationAllowed()
    //{

    //}

}
