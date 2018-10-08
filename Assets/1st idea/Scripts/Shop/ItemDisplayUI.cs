using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Image))]
public class ItemDisplayUI : MonoBehaviour
{
    [SerializeField] ItemsArray items;
    int itemIndex;
    Text achievementText;
    Image itemImage;
    Button button;


    public int ItemIndex
    {
        set
        {
            itemIndex = value;
        }
    }

    public ItemsArray Items
    {
        set
        {
            items = value;
        }
    }

    private void Awake()
    {
        button = GetComponent<Button>();
        itemImage = GetComponent<Image>();
        achievementText = GetComponentInChildren<Text>();

    }

    public void WriteAchievemnet(string achievementString)
    {
        achievementText.text = achievementString;
    }

    public void DisplayItem(bool unlocked)
    {
        itemImage.sprite = items.items[itemIndex].ItemSprite;
        if (!unlocked)
        {
            itemImage.color = Color.black;
            button.interactable = false;
        }
    }
}