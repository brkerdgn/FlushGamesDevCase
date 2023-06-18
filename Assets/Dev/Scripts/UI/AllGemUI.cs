using System.Collections.Generic;
using UnityEngine;

public class AllGemUI : MonoBehaviour
{
    [SerializeField] private GemDatabase gemDatabase;
    [SerializeField] private GameObject allGemPanel,allGemButton,CanvasJoystick,GemInfoPrefab;
    public RectTransform contentTransform;
    GameObject panel;

    public List<GameObject> gemInfoPanels = new List<GameObject>();


    private void Start()
    {
        CreateGemInfo();
    }

    private void Update()
    {
        UpdateGemCount();
    }

    public void CreateGemInfo()
    {
        for(int i = 0; i< gemDatabase.gems.Count; i++)
        {
            panel = Instantiate(GemInfoPrefab, contentTransform);
            gemInfoPanels.Add(panel);
            GemInfo gemInfo = panel.GetComponent<GemInfo>();
            gemInfo.gemIcon = gemDatabase.gems[i].gemIcon;
            gemInfo.gemType = gemDatabase.gems[i].gemName;
            gemInfo.gemCount = gemDatabase.gems[i].collectedCount;
        }
    }

    public void UpdateGemCount()
    {              
         for (int i = 0; i < gemDatabase.gems.Count; i++)
         {
             GameObject panel = gemInfoPanels[i];
             GemInfo gemInfo = panel.GetComponent<GemInfo>();
             gemInfo.gemCount = gemDatabase.gems[i].collectedCount;
         }
        
    }

    public void ButtonClick()
    {
        allGemButton.SetActive(false);
        allGemPanel.SetActive(true);
        CanvasJoystick.SetActive(false);
    }

    public void AllGemPanelCloseButton()
    {
        allGemPanel.SetActive(false);
        allGemButton.SetActive(true);
        CanvasJoystick.SetActive(true);
    }
}
