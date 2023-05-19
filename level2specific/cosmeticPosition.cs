using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cosmeticPosition : MonoBehaviour
{
    public Transform penguin;
    [SerializeField] float upwards;

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(penguin.position.x, penguin.position.y + CharacterController2D.upwardscosmetics, penguin.position.z);
        transform.localScale = penguin.localScale;
    }
}
