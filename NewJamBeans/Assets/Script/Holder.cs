using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Holder : MonoBehaviour
{
    public bool defeate;
    public GameObject panelDead;

    void Update()
    {
        if(defeate)
        {
            panelDead.SetActive(true);
        }
    }
}
