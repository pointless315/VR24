using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script : MonoBehaviour
{
    public Animator anim;
    private void OnMouseDown()
    {
        anim.SetTrigger("Start");
    }
}
