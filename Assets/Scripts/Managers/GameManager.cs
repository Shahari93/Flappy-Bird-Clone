using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager gameManager;
    public bool shouldPlay = true;

    private void Awake()
    {
        if(gameManager != null && gameManager != this)
        {
            Destroy(gameObject);
            return;
        }
        else
        {
            gameManager = this;
            DontDestroyOnLoad(gameObject);
        }
    }
}
