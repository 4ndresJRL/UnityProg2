using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Item", menuName = "Create New Item")]
public class Item : ScriptableObject
{
    [Header("Variables")]
    public string names;
    public string description;
    public Sprite itemSprite;
}
