using burakErdogan.Items;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Gem", menuName = "Create Database / Database")]
public class GemDatabase : ScriptableObject
{
    public List<Gems> gems = new List<Gems>();
}
