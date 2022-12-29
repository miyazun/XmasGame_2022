using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Test : MonoBehaviour
{
    private int num;
    [SerializeField]
    private Text textUI;

    // Start is called before the first frame update
    void Start()
    {
        num = 0;
        textUI.text = string.Format("{0:0}", num);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Plus()
    {
        num++;
        textUI.text = string.Format("{0:0}", num);
    }

}
