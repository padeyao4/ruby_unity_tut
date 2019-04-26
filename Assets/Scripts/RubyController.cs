using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RubyController : MonoBehaviour
{
    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Debug.Log(horizontal);
        Debug.Log(vertical);


        Vector2 position = rb.position;
        position.x = position.x + 3f * horizontal * Time.deltaTime;
        position.y = position.y + 3f * vertical * Time.deltaTime;
        rb.MovePosition(position);
    }
}
