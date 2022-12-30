using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissChecker : MonoBehaviour
{
    [SerializeField]
    private GameManager gameManager;
    private void OnTriggerEnter2D(Collider2D other)
    {
        gameManager.ComboZero();
    }
}
