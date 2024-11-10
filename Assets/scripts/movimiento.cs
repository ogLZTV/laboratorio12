using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimiento : MonoBehaviour
{
    private Rigidbody2D _componentRigidbody2D;
    private float horizontal;
    private float vertical;
    // Start is called before the first frame update
    void Awake()
    {
        _componentRigidbody2D = GetComponent<Rigidbody2D>();
        
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");
    }

    private void FixedUpdate()
    {
        _componentRigidbody2D.velocity = new Vector2(horizontal, vertical);
    }
}
