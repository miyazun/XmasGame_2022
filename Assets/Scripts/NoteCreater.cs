using System;
using UnityEngine;
using UniRx;

public class NoteCreater : MonoBehaviour
{
    [SerializeField]
    private GameObject note;
    [SerializeField]
    private Vector2 startPosition;
    private bool isNote;

    void Start()
    {
        isNote = true;
    }

    public void CreateNote()
    {
        if (isNote)
        {
            isNote = false;
            Instantiate(note, startPosition, Quaternion.identity);
            isNote = true;
        }
    }


}
