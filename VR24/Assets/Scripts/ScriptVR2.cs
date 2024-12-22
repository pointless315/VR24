using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class ScriptVR2 : MonoBehaviour
{
    public int n = 3;
    public Text count;
    public void OnCollisionEnter(Collision collision)
    {
        n--;
        count.text = n.ToString();
    }
}
