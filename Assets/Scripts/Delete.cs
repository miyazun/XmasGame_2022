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
    private GameManager gameManager;
    private ComboCalculator comboCalculator;

    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        comboCalculator = GameObject.Find("GameManager").GetComponent<ComboCalculator>();
        hasPresents = GameObject.Find("SantaHasPresents").GetComponent<HasPresents>();
    }

    public bool DeleteObj(string name)
    {
        bool success = false;
        if (gameObject.transform.position.x >= Mathf.Abs(missArea))
        {
            name = "miss";
        }

        if (name == "miss")
        {
            if (tag == "bell")
            {
                //Debug.Log("miss By Bell");
            }
            else
            {
                //Debug.Log("miss by other");
            }
            success = false;
        }
        else if (name == "present")
        {
            //Debug.Log("pre");
            Instantiate(presentEffect, new Vector2(0.0f, 3.6f), Quaternion.identity);
            hasPresents.GetPresent();
            success = false;
        }
        else
        {
            //Debug.Log("other");
            gameManager.AddCombo();
            comboCalculator.CalculatoPoints();
            Instantiate(getEffect, transform.position, Quaternion.identity);
            success = true;
        }
        Destroy(gameObject);
        return success;
    }

}
