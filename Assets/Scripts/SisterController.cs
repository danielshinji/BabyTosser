using UnityEngine;
using System.Collections;

public class SisterController : MonoBehaviour {

    [HideInInspector]
    public Rigidbody2D rb;

    public float speed;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Move()
    {
        float h = Input.GetAxis("Horizontal");

        Vector3 movement = new Vector3(h, 0.0f, 0.0f);
        rb.velocity = movement * speed;
    }
	
	// Update is called once per frame
	void Update ()
    {
        Move();
	}
}
