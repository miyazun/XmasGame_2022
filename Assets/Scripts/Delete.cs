using UnityEngine;

public class Delete : MonoBehaviour
{
    [SerializeField]
    private float missArea;
    private HasPresents hasPresents;

    void Start()
    {
        hasPresents = GameObject.Find("SantaHasPresents").GetComponent<HasPresents>();
    }

    public void DeleteObj(string name)
    {
        if (gameObject.transform.position.x >= Mathf.Abs(missArea))
        {
            name = "miss";
        }

        if (name == "miss")
        {
            if (tag == "bell")
            {
                Debug.Log("miss By Bell");
            }
            else
            {
                Debug.Log("miss by other");
            }
        }
        else if (name == "present")
        {
            Debug.Log("pre");
            hasPresents.GetPresent();
        }
        else
        {
            Debug.Log("other");
            Destroy(this.gameObject);
        }
        Destroy(gameObject);
    }

}
