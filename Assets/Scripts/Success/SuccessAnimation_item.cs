using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UniRx;

public class SuccessAnimation_item : MonoBehaviour
{
    [SerializeField]
    private float finishTime;
    [SerializeField]
    private float speed;
    private float time;
    void Start()
    {
        var move = Observable
                   .EveryUpdate()
                   .Where(_ => time < finishTime)
                   .Subscribe(_ => Anim()).AddTo(this);
        var delete = Observable
                     .EveryUpdate()
                     .Where(_ => time >= finishTime)
                     .Delay(TimeSpan.FromSeconds(1))
                     .Subscribe(_ => Destroy(gameObject)).AddTo(this);
    }
    private void Anim()
    {
        time += Time.deltaTime;
        float phase = Time.time * 2 * (float)Math.PI;
        transform.Translate(0.0f, speed * Mathf.Cos(time) * Time.deltaTime, 0.0f);
    }
}
