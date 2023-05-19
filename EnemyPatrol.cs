using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPatrol : MonoBehaviour
{   
    [SerializeField] GameObject pointA;
    [SerializeField] GameObject pointB;
    private Rigidbody2D rb;
    private Transform currentpoint;
    [SerializeField] float speed;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        currentpoint = pointB.transform;
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 point = currentpoint.position - transform.position;
        if (currentpoint == pointB.transform){
            rb.velocity = new Vector2(speed, 0);
        }
        else{
            rb.velocity = new Vector2(-speed, 0);
        }
        if(Vector2.Distance(transform.position, currentpoint.position) < 0.3f && currentpoint == pointB.transform){
            flip();
            currentpoint = pointA.transform;
        }
        if(Vector2.Distance(transform.position, currentpoint.position) < 0.3f && currentpoint == pointA.transform){
            flip();
            currentpoint = pointB.transform;
        }
    }
    private void flip(){
        Vector3 localScale = transform.localScale;
        localScale.x *= -1;
        transform.localScale = localScale;
    }
}
