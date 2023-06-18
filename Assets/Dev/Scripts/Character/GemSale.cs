using burakErdogan.Items;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using TMPro;

public class GemSale : MonoBehaviour
{
    public float gold;
    [SerializeField] private TMP_Text scoreText;
    GemStack gemStack;
    [SerializeField] private float saleSpeed;
    public GemDatabase gemDatabase;
    float gemStartPrice;
    float timer = 0f;
    private void Start()
    {
        gemStack = GetComponent<GemStack>();
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("SalePoint"))
        {
            SaleGem();
        }
    }

    private void Update()
    {
        scoreText.text = gold.ToString();
    }

    private void SaleGem()
    {
        timer += Time.deltaTime;
        if(gemStack.stackedGems.Count > 0 && timer >= saleSpeed)
        {
            Gem gem= gemStack.stackedGems[gemStack.stackedGems.Count - 1].GetComponent<Gem>();

            for(int i=0; i < gemDatabase.gems.Count; i++)
            {
                if ((int)gemDatabase.gems[i].GemType == (int)gem.gemType)
                {
                    gemStartPrice = gemDatabase.gems[i].gemStartPrice;
                    gemDatabase.gems[i].collectedCount++;
                }
            }

          
            gold += Mathf.FloorToInt( gemStartPrice + gem.scale * 100);
           
            Destroy(gemStack.stackedGems[gemStack.stackedGems.Count - 1]);
            gemStack.stackedGems.Remove(gemStack.stackedGems[gemStack.stackedGems.Count - 1]);
            gemStack.stackHigh = gemStack.stackHigh - 1;

            timer = 0f;
        }
    }
}
