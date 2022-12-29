using UnityEngine;
using UniRx;

public class HasPresents : MonoBehaviour
{
    public ReactiveProperty<int> presents = new ReactiveProperty<int>();

    [SerializeField]
    private int startPresents;

    // Start is called before the first frame update
    void Start()
    {
        presents.Value = startPresents;
    }

    public void GetPresent()
    {
        presents.Value++;
    }

    public void GivePresent()
    {
        presents.Value--;
    }

}
