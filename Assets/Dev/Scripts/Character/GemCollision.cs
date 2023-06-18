using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GemCollision : MonoBehaviour
{
    private GemStack gemStack;

    private void Awake()
    {
        gemStack = GetComponent<GemStack>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        GameObject collidedGem = collision.gameObject;

        Gem gem = collidedGem.GetComponent<Gem>();
        SphereCollider collider = collidedGem.GetComponent<SphereCollider>();
        
        if (gem != null && gem.isCollectable)
        {
            gemStack.AddToStack(collidedGem);
            Destroy(collider);
            gem.isCollected = true;
        }
    }
}
