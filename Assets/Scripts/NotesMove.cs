using UnityEngine;
using UniRx;

public class NotesMove : MonoBehaviour
{
    [SerializeField]
    private float speed;

    // Start is called before the first frame update
    void Start()
    {
        var xMove = Observable.EveryUpdate().Subscribe(_ => XMove()).AddTo(this);
    }

    private void XMove()
    {
        transform.Translate(-speed * Time.deltaTime, 0, 0);
    }

}
