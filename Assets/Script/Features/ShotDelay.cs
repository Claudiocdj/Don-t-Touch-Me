using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotDelay : MonoBehaviour
{
    [SerializeField]
    private float delayTime;

    public bool canShot = false;

    public void StartDelayShot()
    {
        canShot = false;

        StartCoroutine( DelayCoroutine() );
    }

    private IEnumerator DelayCoroutine()
    {
        yield return new WaitForSeconds( delayTime );

        canShot = true;
    }
}
