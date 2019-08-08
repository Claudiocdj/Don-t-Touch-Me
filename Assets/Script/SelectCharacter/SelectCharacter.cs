using UnityEngine;

public class SelectCharacter : MonoBehaviour
{
    private CharactersSpritesBase spritesBase;

    private SpriteRenderer playerSprite;

    private void Awake()
    {
        spritesBase = GetComponent<CharactersSpritesBase>();

        playerSprite = GameObject.FindWithTag( "Player" ).GetComponent<SpriteRenderer>();
    }

    public void ChangeCharacter(int direction)
    {
        playerSprite.sprite = spritesBase.GetSprite( direction );
    }
}
