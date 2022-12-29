using UnityEngine;

public class Delete : MonoBehaviour
{
    private HasPresents hasPresents;

    void Start()
    {
        hasPresents = GameObject.Find("SantaHasPresents").GetComponent<HasPresents>();
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
            hasPresents.GetPresent();
            Destroy(gameObject);
        }
        else
        {
            Debug.Log("other");
            Destroy(this.gameObject);
        }
        Destroy(gameObject);
    }

}
