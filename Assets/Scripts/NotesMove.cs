using UnityEngine;
using UniRx;

public class NotesMove : MonoBehaviour
{
    [SerializeField]
    private float speed;
    [SerializeField]
    private float over;

    // Start is called before the first frame update
    void Start()
    {
        var xMove = Observable.EveryUpdate().Subscribe(_ => XMove()).AddTo(this);
        var destroyObj = Observable.EveryUpdate().Where(_ => transform.position.x <= over).Subscribe(_ => Delete()).AddTo(this);
    }

    private void XMove()
    {
        transform.Translate(-speed * Time.deltaTime, 0, 0);
    }

    public void Delete()
    {
        Destroy(this.gameObject);
    }

}
