using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkinChanger : MonoBehaviour
{
    public Sprite[] skins;
    public SpriteRenderer sr;

    private void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        sr.sprite = skins[Player.SkinNum];
    }
    private void FixedUpdate()
    {
        sr.sprite = skins[Player.SkinNum];
    }
}
