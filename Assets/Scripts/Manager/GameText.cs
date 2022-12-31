using System;
using UnityEngine;
using TMPro;
using UniRx;
using UniRx.Triggers;

public class GameText : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI presentText;
    [SerializeField]
    private TextMeshProUGUI pointsText;
    [SerializeField]
    private TextMeshProUGUI comboText;
    [SerializeField]
    private HasPresents hasPresents;
    [SerializeField]
    private GameManager gameManager;
    private float activeTime;

    // Start is called before the first frame update
    void Start()
    {
        activeTime = 0.0f;
        hasPresents.presents
        .Subscribe(num => UpdatePresentCounter(num)).AddTo(this);
        gameManager.points
        .Subscribe(num => UpdatePointsCounter(num)).AddTo(this);
        gameManager.combo
        .Subscribe(num => UpdateComboCounter(num)).AddTo(this);
        var active = Observable.EveryUpdate()
                     .Subscribe(_ => ComboAcrive()).AddTo(this);
    }

    private void UpdatePresentCounter(int num)
    {
        presentText.text = num.ToString() + "個";
    }

    private void UpdatePointsCounter(int num)
    {
        pointsText.text = num.ToString() + "ポイント";
    }

    private void UpdateComboCounter(int num)
    {
        if (!comboText.enabled)
        {
            comboText.enabled = true;
        }
        comboText.text = num.ToString() + "コンボ!";
        activeTime = 2.0f;
    }
    private void ComboAcrive()
    {
        activeTime -= Time.deltaTime;
        if (activeTime > 0.0f)
        {
            comboText.enabled = true;
        }
        else
        {
            comboText.enabled = false;
        }
    }
}
