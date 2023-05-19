using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movingplatform : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] int startingPoint;
    [SerializeField] Transform[] points;
    private int i;
    void Start()
    {
        transform.position = points[startingPoint].position;
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector2.Distance(transform.position, points[i].position) < 0.02f){
            i++;
            if (i == points.Length){
                i = 0;
            }
        }
        transform.position = Vector2.MoveTowards(transform.position, points[i].position, speed * Time.deltaTime);
    }
    private void OnCollisionEnter2D(Collision2D other) {
        if (other.collider.tag == "Player"){
            other.transform.SetParent(transform);
        }
        
    }
    private void OnCollisionExit2D(Collision2D other) {
        if (other.collider.tag == "Player"){
            other.transform.SetParent(null);
            }
    }
}
