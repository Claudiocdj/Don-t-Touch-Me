using UnityEngine;

public class GameController : MonoBehaviour
{
    private static GameController instance;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;

            DontDestroyOnLoad( this );
        }
        else
            Destroy( this );
    }
}
