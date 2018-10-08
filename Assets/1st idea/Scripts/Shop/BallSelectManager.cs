using System;
using UnityEngine;

public class BallSelectManager : MonoBehaviour
{

    ShopButtonManager shopButtonManager;

    private void Start()
    {

        shopButtonManager = GetComponent<ShopButtonManager>();

    }
    public void SelectBall()
    {
        if (shopButtonManager.Items.items[shopButtonManager.currentItemIndex].unlockedState)
        {
            SaveCurrentBall();
            //  DisplayBallSelected();
        }
    }

    private void SaveCurrentBall()
    {
        PlayerPrefs.SetInt("currentBallIndex", shopButtonManager.currentItemIndex);
    }

    private void DisplayBallSelected()
    {
        throw new NotImplementedException();
    }

}
