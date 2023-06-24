using UnityEngine;

public class DataSave : MonoBehaviour
{
    public string NameObject;
    public int id;

    public void SaveInt()
    {
        PlayerPrefs.SetInt(NameObject, id);
    }
}
