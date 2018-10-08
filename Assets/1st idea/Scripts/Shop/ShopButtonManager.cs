using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ShopButtonManager : MonoBehaviour
{
    [SerializeField] ItemsArray items;
    Item currentItem;
    ItemDisplayUI itemDisplay;

    public int currentItemIndex;
    bool itemIsUnlocked;


    public bool ItemIsUnlocked
    {
        get
        {
            return itemIsUnlocked;
        }
    }


    public ItemsArray Items
    {
        get
        {
            return items;
        }
    }

    public Item CurrentItem
    {
        get
        {
            return currentItem;
        }

        set
        {
            currentItem = value;
        }
    }

    void Start()
    {

        SetBall(items.items[currentItemIndex]);
        InitializeDisplay();
        Display();

    }

    private void Display()
    {
        itemDisplay.DisplayItem(ItemIsUnlocked);
        itemDisplay.WriteAchievemnet(CurrentItem.AchievementText);
    }

    private void InitializeDisplay()
    {
        itemDisplay = GetComponent<ItemDisplayUI>();
        itemDisplay.ItemIndex = currentItemIndex;
        itemDisplay.Items = Items;
    }

    public void SetBall(Item _item)
    {
        CurrentItem = _item;
        itemIsUnlocked = currentItem.unlockedState;

    }
}