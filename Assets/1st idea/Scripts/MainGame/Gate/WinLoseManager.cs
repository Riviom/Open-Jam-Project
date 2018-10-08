using System;
using UnityEngine;
public class WinLoseManager : MonoBehaviour
{
    public static event Action<Transform> OnPointScored = delegate { };
    public static event Action<Transform> OnLose = delegate { };
    public bool isWinTrigger = true;

    void OnTriggerEnter2D(Collider2D col)
    {
        if (isWinTrigger)
        {
            Win();
        }
        else Lose(col);
    }


    void Lose(Collider2D col)
    {
        OnLose(col.transform);
        //        GameManagerScript.gameManager.EndGame();
        PauseScript.PauseManager.gameObject.SetActive(false);
        DeactivateGateController();
    }


    void Win()
    {
        //si asteaf


        OnPointScored(transform.parent.parent);
    }

    void DeactivateGateController()
    {
        Collider2D[] col = GetComponentsInParent<Collider2D>();
        foreach (var colider in col)
        {
            colider.enabled = false;
        }
    }


}
