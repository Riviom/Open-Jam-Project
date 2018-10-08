using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GateExploder : MonoBehaviour
{
    private void OnEnable()
    {
        Debug.Log(this.ToString());
    }
    ////[SerializeField] ParticleSystem gateExplosion;
    //PoolingSystem gateExplosionPoolingSystem;
    //PoolingSystem gatePoolingSystem;

    //GameObject gateExplosion;

    //public void Initialize(PoolingSystem _gateExplosionPoolingSystem, PoolingSystem _gatePoolingSystem)
    //{
    //    gatePoolingSystem = _gatePoolingSystem;
    //    gateExplosionPoolingSystem = _gateExplosionPoolingSystem;
    //}

    //void Start()
    //{
    //    WinLoseManager.OnPointScored += WinLoseManager_OnPointScored;
    //}

    //void WinLoseManager_OnPointScored(Transform gate)
    //{
    //    if (gate.gameObject.activeInHierarchy && gate.GetChild(0).gameObject.activeInHierarchy)
    //    {
    //        Explode(gate);
    //        GraphicsSetActive(false, gate);
    //        StartCoroutine(FinishExplosion(gate));
    //    }
    //}


    //private void Explode(Transform gate)
    //{
    //    gateExplosion = gateExplosionPoolingSystem.GetObject();
    //    gateExplosion.transform.position = gate.position;
    //}

    //private void GraphicsSetActive(bool active, Transform gate)
    //{
    //    Transform graphics = gate.GetChild(0);
    //    graphics.gameObject.SetActive(active);
    //}

    //IEnumerator FinishExplosion(Transform gate)
    //{
    //    yield return new WaitForSeconds(1f);
    //    gateExplosionPoolingSystem.ReturnObject(gateExplosion);
    //    gatePoolingSystem.ReturnObject(gate.gameObject);
    //}

}
