using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public GameObject ShopPanel;
    public bool isOpen;

    public void Quit() 
    {
        Application.Quit();
    }

    public void GoMainMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void Retry()
    {
        SceneManager.LoadScene(2);
    }

    public void Shop()
    {
        if(isOpen == true)
        {
            ShopPanel.SetActive(false);
            isOpen = false;
        }
        else if(isOpen == false)
        {
            ShopPanel.SetActive(true);
            isOpen = true;
        }
    }

    public void StarGame()
    {
        SceneManager.LoadScene(1);
    }
}