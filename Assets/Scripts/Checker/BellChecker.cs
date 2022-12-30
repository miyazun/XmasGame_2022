using UnityEngine;
using UniRx;

public class BellChecker : MonoBehaviour
{
    private bool isNote;
    private GameObject otherNote;
    [SerializeField]
    private KeyCode checkKey;
    [SerializeField]
    private HasPresents hasPresents;

    void Start()
    {
        isNote = false;
        var key = Observable.EveryUpdate()
                  .Where(_ => hasPresents.presents.Value > 0 && (Input.GetKeyDown(checkKey) && isNote))
                  .Subscribe(_ => DeleteOther());
        var givePresent = Observable.EveryUpdate()
          .Where(_ => Input.GetKeyDown(checkKey) && hasPresents.presents.Value > 0)
          .Subscribe(_ => hasPresents.GivePresent());
    }


    private void OnTriggerEnter2D(Collider2D other)
    {
        isNote = true;
        otherNote = other.gameObject;
    }
    private void OnTriggerStay2D(Collider2D other)
    {
        isNote = true;
        otherNote = other.gameObject;
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
