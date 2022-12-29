using UnityEngine;

public class Delete : MonoBehaviour
{
    private Test test;

    void Start()
    {
        test = GameObject.Find("Text").GetComponent<Test>();
    }
    public void DeleteObj(string name)
    {
        if (name == "miss")
        {
            if (tag == "bell")
            {
                Debug.Log("miss");
            }
            Destroy(gameObject);
        }
        else if (name == "present")
        {
            Debug.Log("pre");
            Destroy(gameObject);
        }
        else
        {
            Debug.Log("other");
            Destroy(this.gameObject);
            test.Plus();
        }
        Destroy(gameObject);
    }

}
