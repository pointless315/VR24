using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class ScriptVR1 : MonoBehaviour
{
    public GameObject box;
    public void ButtonOn()
    {
        box.SetActive(!(box.activeSelf));
    }
}