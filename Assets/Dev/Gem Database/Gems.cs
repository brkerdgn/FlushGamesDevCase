using UnityEngine;

namespace burakErdogan.Items
{
    [CreateAssetMenu(fileName = "New Gem", menuName = "Create Gem/Gem")]
    public class Gems : ScriptableObject
    {
        [Header("Gem Info")]
        public GemType GemType;
        public string gemName;
        public float gemStartPrice;
        public GameObject gemPrefab;
        public Sprite gemIcon;
        public int collectedCount;

    }

  
}