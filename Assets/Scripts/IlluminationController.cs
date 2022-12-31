using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UniRx;

public class IlluminationController : MonoBehaviour
{
    [SerializeField]
    private Sprite[] illumination;
    [SerializeField]
    private SpriteRenderer spriteRenderer;
    private int num;

    void Start()
    {
        num = 0;
        var changeIllumination = Observable
                                .EveryUpdate()
                                .ThrottleFirst(TimeSpan.FromSeconds(1))
                                .Subscribe(_ => ChangeImage()).AddTo(this);
    }

    private void ChangeImage()
    {
        num++;
        num = num % illumination.Length;
        spriteRenderer.sprite = illumination[num];
    }
}
