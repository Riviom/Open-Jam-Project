using System;
using UnityEngine;


public class AvailableBalls : MonoBehaviour
{
    
    public int At1, At2, At3, At4, At5, At6, At7, At8, At9, At10, Hi1, Hi2, Hi3, Hi4, Hi5, Hi6, Hi7, Hi8, Hi9, Hi10;
    [SerializeField] ItemsArray items;

    private void Awake()
    {

        UnlockItems();
    }

    private void UnlockItems()
    {
        items.items[0].unlockedState = UnlockItem();

        if(PlayerPrefs.GetInt("attempts")>=At1){
            items.items[1].unlockedState = UnlockItem();
        }

        if (PlayerPrefs.GetInt("attempts") >= At2)
        {
            items.items[3].unlockedState = UnlockItem();
        }

        if(PlayerPrefs.GetInt("attempts")>=At3){
            items.items[5].unlockedState = UnlockItem();
        }
       
        if (PlayerPrefs.GetInt("attempts") >= At4)
        {
            items.items[7].unlockedState = UnlockItem();
        }

        if (PlayerPrefs.GetInt("attempts") >= At5)
        {
            items.items[9].unlockedState = UnlockItem();
        }
       
        if (PlayerPrefs.GetInt("attempts") >= At6)
        {
            items.items[11].unlockedState = UnlockItem();
        }
       
        if (PlayerPrefs.GetInt("attempts") >= At7)
        {
            items.items[13].unlockedState = UnlockItem();
        }
       
        if (PlayerPrefs.GetInt("attempts") >= At8)
        {
            items.items[15].unlockedState = UnlockItem();
        }
       
        if (PlayerPrefs.GetInt("attempts") >= At9)
        {
            items.items[17].unlockedState = UnlockItem();
        }
       
        if (PlayerPrefs.GetInt("attempts") >= At10)
        {
            items.items[19].unlockedState = UnlockItem();
        }



        if (PlayerPrefs.GetInt("highscore") >= Hi1)
        {
            items.items[2].unlockedState = UnlockItem();
        }

        if (PlayerPrefs.GetInt("highscore") >= Hi2)
        {
            items.items[4].unlockedState = UnlockItem();
        }

        if (PlayerPrefs.GetInt("highscore") >= Hi3)
        {
            items.items[6].unlockedState = UnlockItem();
        }

        if (PlayerPrefs.GetInt("highscore") >= Hi4)
        {
            items.items[8].unlockedState = UnlockItem();
        }

        if (PlayerPrefs.GetInt("highscore") >= Hi5)
        {
            items.items[10].unlockedState = UnlockItem();
        }

        if (PlayerPrefs.GetInt("highscore") >= Hi6)
        {
            items.items[12].unlockedState = UnlockItem();
        }

        if (PlayerPrefs.GetInt("highscore") >= Hi7)
        {
            items.items[14].unlockedState = UnlockItem();
        }

        if (PlayerPrefs.GetInt("highscore") >= Hi8)
        {
            items.items[16].unlockedState = UnlockItem();
        }

        if (PlayerPrefs.GetInt("highscore") >= Hi9)
        {
            items.items[18].unlockedState = UnlockItem();
        }

        if (PlayerPrefs.GetInt("highscore") >= Hi10)
        {
            items.items[20].unlockedState = UnlockItem();
        }

        //items.items[1].unlockedState = UnlockItem();
        //balls.balls[2].unlockedState = BallUnlock1();
    }

    private bool LockItem()
    {
        return false;
    }

    private bool UnlockItem()
    {
        return true;
    }


    private bool ItemUnlockType1()
    {
        return false;
    }


}

