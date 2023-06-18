using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TextUI : MonoBehaviour
{
    [SerializeField] private GemSale gemSale;
    [SerializeField] private Animator animator;
    float lastGold;

    private void Update()
    {
        if(gemSale.gold != lastGold)
        {
            animator.SetTrigger("isScale");
            lastGold = gemSale.gold;
        }
    }
}
