using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public int BeansCount;
    public Text beanscountTXT;

    void Start()
    {
        
    }

    
    void Update()
    {
        beanscountTXT.text = BeansCount.ToString();
    }
}
