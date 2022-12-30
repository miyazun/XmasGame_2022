using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;

public class SuccessCreater : MonoBehaviour
{
    [SerializeField]
    private float speed;
    [SerializeField]
    private GameObject successItem;
    [SerializeField]
    private Vector2 createPos;

    void Start()
    {
        var move = Observable
                   .EveryUpdate()
                   .Subscribe(_ => Move()).AddTo(this);
        var create = Observable
                     .EveryUpdate()
                     .Where(_ => transform.position.y <= -5.4)
                     .First()
                     .Subscribe(_ => CreateItem()).AddTo(this);
    }

    private void Move()
    {
        transform.Translate(0.0f, -speed * Time.deltaTime, 0.0f);
    }

    private void CreateItem()
    {
        if (tag == "success")
        {
            Instantiate(successItem, createPos, Quaternion.identity);
        }
        Destroy(gameObject);
    }
}
