using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySoundOnCollision : MonoBehaviour
{

    public string soundCollision;
    public string soundTrigger;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        FindObjectOfType<AudioManager>().Play(soundCollision);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        FindObjectOfType<AudioManager>().Play(soundTrigger);
    }
}
