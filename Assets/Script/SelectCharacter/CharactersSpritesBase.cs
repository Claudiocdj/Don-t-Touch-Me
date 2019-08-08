using UnityEngine;

public class CharactersSpritesBase : MonoBehaviour
{
    [SerializeField]
    private Sprite[] characters = null;

    private int currentCharacterIndex = 0;

    public Sprite GetSprite(int index)
    {
        int newIndex = currentCharacterIndex + index;
        
        if (newIndex < 0)
            currentCharacterIndex = characters.Length - 1;

        else if (newIndex >= characters.Length)
            currentCharacterIndex = 0;

        else
            currentCharacterIndex = newIndex;

        return characters[currentCharacterIndex];
    }
}
