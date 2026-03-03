using UnityEngine;

[CreateAssetMenu(fileName = "NewItem", menuName = "ScriptableObjects/ItemData")]
public class PlayerData : ScriptableObject
{
    public string Name;    // text field
    public Sprite Icon;    // image field
}