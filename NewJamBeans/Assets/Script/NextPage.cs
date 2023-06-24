using UnityEngine.SceneManagement;
using UnityEngine;

public class NextPage : MonoBehaviour
{
    
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            SceneManager.LoadScene(2);
        }
    }
}
