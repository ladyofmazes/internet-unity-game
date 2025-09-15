using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] float steerSpeed = 40.0f;
    [SerializeField] float moveSpeed = 5.0f;
    void Start()
    {

    }

    // Update is called once per frame
    void LateUpdate()
    {
        float steerBackForth = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
        float steerAmount = Input.GetAxis("Horizontal") * steerSpeed * Time.deltaTime;
        transform.Rotate(0, 0, -steerAmount);
        transform.Translate(0, steerBackForth, 0);
    }
}
