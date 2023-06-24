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
        if(PlayerPrefs.HasKey("Money"))
        {
            BeansCount = PlayerPrefs.GetInt("Money");
            beanscountTXT.text = BeansCount.ToString();
        }
    }

    
    void Update()
    {
        beanscountTXT.text = BeansCount.ToString();
        PlayerPrefs.SetInt("Money", BeansCount);
    }
}
