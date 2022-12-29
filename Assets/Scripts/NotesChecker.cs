using UnityEngine;
using UniRx;

public class NotesChecker : MonoBehaviour
{
    private bool isNote;
    private GameObject otherNote;
    [SerializeField]
    private KeyCode checkKey;

    void Start()
    {
        isNote = false;
        var key = Observable.EveryUpdate()
                  .Where(_ => Input.GetKeyDown(checkKey) && isNote)
                  .Subscribe(_ => DeleteOther());
    }


    private void OnTriggerEnter2D(Collider2D other)
    {
        isNote = true;
        otherNote = other.gameObject;
        /*if (Input.GetKeyDown(checkKey))
        {
            Destroy(other.gameObject);
        }*/

    }
    private void OnTriggerStay2D(Collider2D other)
    {
        isNote = true;
        otherNote = other.gameObject;
        /*if (Input.GetKeyDown(checkKey))
        {
            Destroy(other.gameObject);
        }*/
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        isNote = false;
    }

    private void DeleteOther()
    {
        otherNote.GetComponent<Delete>().DeleteObj(otherNote.tag);
    }
}
