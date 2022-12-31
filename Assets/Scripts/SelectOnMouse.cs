using UnityEngine;
using UnityEngine.UI;

public class SelectOnMouse : MonoBehaviour
{
    [SerializeField]
    private Sprite normal;
    [SerializeField]
    private Sprite select;
    [SerializeField]
    private Image image;
    void OnMouseEnter()
    {
        image.sprite = select;
    }

    private void OnMouseExit()
    {
        image.sprite = normal;
    }

    /*private void OnMouseOver()
    {
        Debug.Log("マウスがある");
    }*/
}
