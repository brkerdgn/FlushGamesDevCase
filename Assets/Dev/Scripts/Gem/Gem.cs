using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gem : MonoBehaviour
{
    public GemType gemType;
    public float scale;
    public bool isCollectable,isCollected;


    void Update()
    {
        ScaleGem();
    }

    #region Scale Gem
    private void ScaleGem()
    {
        if (scale !< 1 && !isCollected)
        {
            scale += Time.deltaTime * 0.20f;
            Vector3 newScale = transform.localScale;
            newScale.x += 0.001f;
            newScale.y += 0.02f;
            newScale.z += 0.001f;

            transform.localScale = newScale;
        }

        if (scale > 0.25)
        {
            isCollectable = true;
        }
        else
        {
            isCollectable= false;
        }
    }
    #endregion
}
