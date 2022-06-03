using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorPlayerSensor : MonoBehaviour
{

    public Animator doorAnimator;   

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("otwierac kurwa");
        doorAnimator.SetBool("open",true);
        doorAnimator.SetBool("close",false);
    }
    private void OnTriggerExit(Collider other)
    {
        Debug.Log("zamyka� huje");
        doorAnimator.SetBool("open", false);
        doorAnimator.SetBool("close", true);
    }
}
