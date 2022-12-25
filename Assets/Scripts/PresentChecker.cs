using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;

public class PresentChecker : MonoBehaviour
{
    private bool isPresent;
    private GameObject otherPresent;

    // Start is called before the first frame update
    void Start()
    {
        isPresent = false;
        var key = Observable.EveryUpdate()
                  .Where(_ => Input.GetKeyDown(KeyCode.UpArrow) && isPresent)
                  .Subscribe(_ => DeleteOther());
    }

    private void Update()
    {
        Debug.Log(isPresent);
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        isPresent = true;
        otherPresent = other.gameObject;
    }
    private void OnTriggerStay2D(Collider2D other)
    {
        isPresent = true;
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        isPresent = false;
    }

    private void DeleteOther()
    {
        Destroy(otherPresent);
    }
}
