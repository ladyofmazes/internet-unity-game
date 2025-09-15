using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    int totWater;
    [SerializeField] float destroyDelay = 0.5f;
    void Start()
    {
        totWater = 0;
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Collision happened");
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Package")
        {
            Debug.Log("Water picked up");
            totWater += 1;
        }
        else
        {
            Debug.Log(totWater);
            if (totWater > 44)
            {
                Destroy(collision.gameObject, destroyDelay);
            }
        }
    }
}
