using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(ShotDelay), typeof( Shoot ) )]
public class PlayerShotInput : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetMouseButton( 0 ))
            if (GetComponent<ShotDelay>().canShot)
                GetComponent<Shoot>().InstantiateShot();
    }
}
