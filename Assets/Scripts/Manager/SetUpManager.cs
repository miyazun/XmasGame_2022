using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;

public class SetUpManager : MonoBehaviour
{
    [SerializeField]
    private GameObject setUpSet;

    // Start is called before the first frame update
    void Start()
    {
        var active = Observable.EveryUpdate()
                     .Where(_ => Input.GetKeyDown(KeyCode.Escape))
                     .Subscribe(_ => ActiveSetUp()).AddTo(this);
    }

    public void ActiveSetUp()
    {
        if (setUpSet.activeSelf)
        {
            setUpSet.SetActive(false);
        }
        else
        {
            setUpSet.SetActive(true);
        }
    }
}
