using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageableController: MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnTriggerStay2D(Collider2D collision)
    {
        RubyController rb = collision.GetComponent<RubyController>();
        if (rb != null)
        {
            rb.ChangeHealth(-1);
        }
    }
}
