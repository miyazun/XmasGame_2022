using UnityEngine;
using UniRx;

public class NotesMove : MonoBehaviour
{
    private float speed;
    [SerializeField]
    private float over;
    [SerializeField]
    private float bpm;
    [SerializeField]
    private float section;
    [SerializeField]
    private float distance;
    [SerializeField]
    private Delete delete;

    // Start is called before the first frame update
    void Start()
    {
        ComputeSpeed();
        var xMove = Observable.EveryUpdate().Subscribe(_ => XMove()).AddTo(this);
        var destroyObj = Observable.EveryUpdate().Where(_ => transform.position.x <= over).Subscribe(_ => Delete()).AddTo(this);
    }

    private void XMove()
    {
        transform.Translate(-speed * Time.deltaTime, 0, 0);
    }

    public void Delete()
    {
        delete.DeleteObj("miss");
    }
    private void ComputeSpeed()
    {
        speed = distance / ((60.0f / bpm) * section);
    }

}
