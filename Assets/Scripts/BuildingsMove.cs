using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingsMove : MonoBehaviour
{
    private Transform trees;
    private Rigidbody2D rb;
    [SerializeField]
    private float speed;
    [SerializeField]
    private float back;
    private Vector3 startPosition;

    // Start is called before the first frame update
    void Start()
    {
        trees = this.gameObject.transform;
        rb = GetComponent<Rigidbody2D>();
        startPosition = gameObject.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector3(-speed, 0.0f, 0.0f);
        if (trees.position.x <= back)
        {
            trees.position = startPosition;
        }
    }
}
