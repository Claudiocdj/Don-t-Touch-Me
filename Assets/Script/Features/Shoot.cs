using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(ShotDelay))]
public class Shoot : MonoBehaviour
{
    [SerializeField]
    private GameObject shotPrefab;

    public void InstantiateShot()
    {
        Instantiate( shotPrefab, transform.position, Quaternion.identity );

        GetComponent<ShotDelay>().StartDelayShot();
    }
}
