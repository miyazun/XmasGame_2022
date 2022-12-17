using UnityEngine;

public class NoteCreater : MonoBehaviour
{
    [SerializeField]
    private GameObject note;
    [SerializeField]
    private Vector2 startPosition;

    public void CreateNote()
    {
        Instantiate(note, startPosition, Quaternion.identity);
    }

}
