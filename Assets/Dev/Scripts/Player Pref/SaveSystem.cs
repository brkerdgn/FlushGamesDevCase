using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class SaveSystem : MonoBehaviour
{
    [SerializeField] GemSale gemSale;
   
    void Start()
    {
        gemSale.gold =PlayerPrefs.GetFloat(nameof(gemSale.gold),gemSale.gold);
    }

    void Update()
    {
        PlayerPrefs.SetFloat(nameof(gemSale.gold), gemSale.gold);
    }


    [MenuItem("Player Pref/Clear")]

    static void Init()
    {
        PlayerPrefs.DeleteAll();
    }
}
