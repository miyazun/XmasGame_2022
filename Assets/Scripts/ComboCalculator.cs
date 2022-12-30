using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComboCalculator : MonoBehaviour
{
    [SerializeField]
    private GameManager gameManager;

    public void CalculatoPoints()
    {
        int combo = gameManager.combo.Value;
        if (combo <= 1)
        {
            gameManager.AddPoints(100);
        }
        else if (combo > 1 && combo < 5)
        {
            gameManager.AddPoints(100 * combo);
        }
        else
        {
            gameManager.AddPoints(500);
        }
    }
}
