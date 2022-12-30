using UnityEngine;

public class Delete : MonoBehaviour
{
    [SerializeField]
    private float missArea;
    [SerializeField]
    private GameObject presentEffect;
    [SerializeField]
    private GameObject getEffect;
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
            Instantiate(presentEffect, new Vector2(0.0f, 3.6f), Quaternion.identity);
            hasPresents.GetPresent();
        }
        else
        {
            Debug.Log("other");
            Instantiate(getEffect, transform.position, Quaternion.identity);
            Destroy(this.gameObject);
        }
        Destroy(gameObject);
    }

}
