using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosionOnDistroy : MonoBehaviour
{
    [SerializeField] ParticleSystem particles;
    [SerializeField] Vector3 offset = new Vector3(0, 2, 0);

    public void Explode(Transform _transform)
    {
        particles.gameObject.SetActive(true);
        particles.transform.position = _transform.position + offset;
    }

}
