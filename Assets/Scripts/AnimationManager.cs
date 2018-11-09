using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationManager : MonoBehaviour {

    public Animator bolt, latch, padlock, bar, door;
    public AudioSource doorSound, doorBolt, doorPadlock, doorLatch, latchRattle, doorRattle, doorbar;
    private bool padlockDone = false;
    private int locksDone = 0;

    public void TriggerAnimation(string name)
    {
        switch(name)
        {
            case "latch":
                if(padlockDone)
                {
                    doorLatch.PlayDelayed(0.4f);
                    latch.SetTrigger(name);
                    locksDone++;
                }   
                else
                {
                    latchRattle.Play();
                }
                break;
            case "bolt":
                locksDone++;
                doorBolt.PlayDelayed(0.3f);
                bolt.SetTrigger(name);
                break;
            case "padlock":
                locksDone++;
                padlockDone = true;
                doorPadlock.Play();
                padlock.SetTrigger(name);
                break;
            case "bar":
                locksDone++;
                doorbar.Play();
                bar.SetTrigger(name);
                break;
            case "door":
                if(locksDone == 4)
                {
                    door.SetTrigger(name);
                    doorSound.Play();
                }       
                else
                {
                    doorRattle.Play();
                }
                break;

        }

    }

    //private bool CheckIfAnimationAllowed()
    //{

    //}

}
