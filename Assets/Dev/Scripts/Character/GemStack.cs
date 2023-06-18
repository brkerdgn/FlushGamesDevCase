using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class GemStack : MonoBehaviour
{
    public List<GameObject> stackedGems = new List<GameObject>();
    [SerializeField] private Transform bagTransform;
    public int stackHigh;

    public void AddToStack(GameObject gem)
    {
        stackedGems.Add(gem);
        gem.transform.SetParent(bagTransform);
        gem.transform.localPosition = Vector3.zero;

        gem.SetActive(true);
        if (stackedGems.Count >=1)
        {
            gem.transform.DOMove(new Vector3(gem.transform.position.x, (0.7f + stackHigh), gem.transform.position.z), 0.01f);
        }
        stackHigh = stackHigh + 1;

        if (stackedGems.Count == 0) 
        {
            stackHigh = 0;
        }


    }
}
