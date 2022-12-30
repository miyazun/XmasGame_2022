using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;

public class BagController : MonoBehaviour
{

    [SerializeField]
    private HasPresents hasPresents;
    void Start()
    {
        hasPresents.presents
        .Subscribe(num => BagSize(num));
    }

    private void BagSize(int num)
    {
        if (num < 10)
        {
            gameObject.transform.localScale = new Vector2(0.1f, 0.1f);
        }
        else if (num >= 10 && num < 20)
        {
            gameObject.transform.localScale = new Vector2(0.2f, 0.2f);
        }
        else
        {
            gameObject.transform.localScale = new Vector2(0.3f, 0.3f);
        }
    }

}
