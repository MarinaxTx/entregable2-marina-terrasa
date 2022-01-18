using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHP : MonoBehaviour
{
    [SerializeField]
    private bool isGameOver;

    private int playerHP = 100;

    public int damege = 30;

    // Start is called before the first frame update
    void Start()
    {
        playerHP = playerHP - damege;
    }

    // Update is called once per frame
    void Update()
    {
        if (isGameOver == false) 
        {
            if (playerHP <= 0) 
            {
                Debug.Log($"Te has quedado sin vida... GAME OVER");
            }

            else if (playerHP < 20) 
            {
                Debug.Log($"¡Tienes poca vida!");

            }

            else
            {
                Debug.Log($"Vas bien de vida: tienes {playerHP} puntos de vida");
            }

        }
        else
        {
            Debug.Log($"GAME OVER");

        }
    }
}
