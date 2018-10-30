using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationManager : MonoBehaviour {

    public Animator bolt, latch, padlock, bar, door;
    private bool padlockDone = false;
    private int locksDone = 0;

    public void TriggerAnimation(string name)
    {
        switch(name)
        {
            case "latch":
                if(padlockDone)
                {
                    latch.SetTrigger(name);
                    locksDone++;
                }               
                break;
            case "bolt":
                locksDone++;
                bolt.SetTrigger(name);
                break;
            case "padlock":
                locksDone++;
                padlockDone = true;
                padlock.SetTrigger(name);
                break;
            case "bar":
                locksDone++;
                bar.SetTrigger(name);
                break;
            case "door":
                if(locksDone == 4)
                {
                    door.SetTrigger(name);
                }               
                break;

        }

    }

    //private bool CheckIfAnimationAllowed()
    //{

    //}

}
