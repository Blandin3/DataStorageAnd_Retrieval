using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlayerDataDisplay : MonoBehaviour
{
    public PlayerData itemData;               // reference to ScriptableObject
    public TextMeshProUGUI itemNameText;
    public Image itemIconImage;

    void Start()
    {
        // Display the ScriptableObject data in the UI
        if (itemData != null)
        {
            itemNameText.text = itemData.Name;
            itemIconImage.sprite = itemData.Icon;
        }
    }
}