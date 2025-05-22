using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "NewItem", menuName = "Item/SpeedItem")]
public class ItemData : ScriptableObject
{
    public string itemName;
    public string description;
    public float effectDuration = 5f;
    public float speedMultiplier = 2f;
}
