using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GemInfo : MonoBehaviour
{
    public Sprite gemIcon;
    public string gemType;
    public int gemCount;
    public Image gemImage;

    public TMP_Text gemTypeText, gemCountTxt;
    private void Update()
    {
        gemImage.sprite = gemIcon;
        gemCountTxt.text = gemCount.ToString(); 
        gemTypeText.text = gemType;
    }
}
