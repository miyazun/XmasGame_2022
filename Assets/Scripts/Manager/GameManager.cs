using UnityEngine;
using UniRx;

public class GameManager : MonoBehaviour
{
    public ReactiveProperty<int> combo = new ReactiveProperty<int>();
    public ReactiveProperty<int> points = new ReactiveProperty<int>();

    void Start()
    {
        combo.Value = 0;
        points.Value = 0;
    }

    public void AddCombo()
    {
        combo.Value++;
    }

    public void ComboZero()
    {
        combo.Value = 0;
    }

    public void AddPoints(int num)
    {
        points.Value += num;
    }

}
