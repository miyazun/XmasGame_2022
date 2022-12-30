using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Success : MonoBehaviour
{
    [SerializeField]
    private GameObject givePresents;
    [SerializeField]
    private Vector2 startPos;

    public void CreateGivePresent(bool check)
    {
        Debug.Log(check);
        Instantiate(givePresents, startPos, Quaternion.identity);
        if (check)
        {
            givePresents.tag = "success";
        }
        else
        {
            givePresents.tag = "false";
        }
    }
}
