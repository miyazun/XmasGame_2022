using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UniRx;

public class PresentsText : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI presentText;
    [SerializeField]
    private HasPresents hasPresents;

    // Start is called before the first frame update
    void Start()
    {
        hasPresents.presents
        .Subscribe(num => UpdateCounter(num));
    }

    private void UpdateCounter(int num)
    {
        presentText.text = num.ToString();
    }
}
