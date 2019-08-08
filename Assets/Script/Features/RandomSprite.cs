using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof( SpriteRenderer ) )]
public class RandomSprite : MonoBehaviour
{
    [SerializeField]
    private Sprite[] sprites = null;

    private void Awake()
    {
        int n = Random.Range( 0, sprites.Length );

        GetComponent<SpriteRenderer>().sprite = sprites[n];
    }
}
