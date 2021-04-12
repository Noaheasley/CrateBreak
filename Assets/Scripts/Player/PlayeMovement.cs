using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayeMovement : MonoBehaviour
{
    private Rigidbody _rigidbody;
    public float MovementSpeed = 5.0f;
    public float Speed;
    public float StartCos = 0;
    // Start is called before the first frame update
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("w"))
        { 
            transform.position += new Vector3(MovementSpeed, 0, 0) * Time.deltaTime;
            StartCos += Time.deltaTime;
        }
        else if (Input.GetKey("s"))
        {
            transform.position += new Vector3(-MovementSpeed, 0, 0) * Time.deltaTime;
            StartCos += Time.deltaTime;
        }
        else if (Input.GetKey("a"))
        {
            transform.position += new Vector3(0, 0, MovementSpeed) * Time.deltaTime;
            StartCos += Time.deltaTime;
        }
        else if (Input.GetKey("d"))
        {
            transform.position += new Vector3(0, 0, -MovementSpeed) * Time.deltaTime;
            StartCos += Time.deltaTime;
        }
    }
}
