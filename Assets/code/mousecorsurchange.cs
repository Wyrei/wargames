using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mousecorsurchange : MonoBehaviour
{
    public void OnMouseEnter()
    {
        mouseCorsur.instance.clickable();
    }
    public void OnMouseExit()
    {
        mouseCorsur.instance.defualt();
    }
}
