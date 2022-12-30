using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;

public class GetPresentMove : MonoBehaviour
{
    [SerializeField]
    private GameObject getEffect;
    [SerializeField]
    private Vector2 startPos;
    [SerializeField]
    private Vector2 arrivalPos;
    [SerializeField]
    private float time;

    private float xSpeed;
    private float ySpeed;

    void Start()
    {
        calculationSpeed();
        Instantiate(getEffect, transform.position, Quaternion.identity);
        var move = Observable.EveryUpdate()
                   .Subscribe(_ => Move()).AddTo(this);
        var finish = Observable.EveryUpdate()
                     .Where(_ => Mathf.Abs(transform.position.x) >= Mathf.Abs(arrivalPos.x))
                     .Subscribe(_ => Delete()).AddTo(this);
    }

    private void calculationSpeed()
    {
        float x = Mathf.Abs(startPos.x - arrivalPos.x);
        float y = Mathf.Abs(startPos.y - arrivalPos.y);
        xSpeed = x / time;
        ySpeed = y / time;
    }

    private void Move()
    {
        transform.Translate(-xSpeed * Time.deltaTime, -ySpeed * Time.deltaTime, 0);
    }

    private void Delete()
    {
        Destroy(gameObject);
    }

}
