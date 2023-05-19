using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class goombastomp : MonoBehaviour
{
    [SerializeField] Rigidbody2D rb;
    public float bounce;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D other) {
        if (other.CompareTag("enemy")){
            Destroy(other.gameObject);
            rb.velocity = new Vector2(rb.velocity.x, bounce);
        }
    }
}
