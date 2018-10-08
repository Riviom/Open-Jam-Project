using UnityEngine;

public class CurrentItemOnSpriteDisplay : MonoBehaviour
{

    [SerializeField] ItemsArray items;

    SpriteRenderer spriteRenderer;
    int currentItemIndex;

    public ItemsArray Items
    {
        private get
        {
            return items;
        }

        set
        {
            items = value;
        }
    }



    // Use this for initialization
    void Awake()
    {
        currentItemIndex = PlayerPrefs.GetInt("currentBallIndex");
        spriteRenderer = GetComponent<SpriteRenderer>();
        spriteRenderer.sprite = Items.items[currentItemIndex].ItemSprite;
    }


}
