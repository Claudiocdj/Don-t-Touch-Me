using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFollowMouseController : MonoBehaviour
{
    private FollowMouse playerFollowMouse;

    private ShotDelay playerShot;

    private void Awake()
    {
        GameObject player = GameObject.FindWithTag( "Player" );

        playerFollowMouse = player.GetComponent<FollowMouse>();

        playerShot = player.GetComponent<ShotDelay>();

        SetActive( false );
    }

    public void SetActive(bool n)
    {
        Cursor.visible = !n;

        playerFollowMouse.enabled = n;

        playerShot.canShot = n;
    }
}
