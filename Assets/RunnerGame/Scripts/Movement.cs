using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Movement : MonoBehaviour
{
    public float MoveSpeed;
    public float Walkspeed;
    public Rigidbody RBody;

    // Start is called before the first frame update
    void Start()
    {
        RBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float moveX = Input.GetAxis("Horizontal");
        float moveZ = Input.GetAxis("Vertical");
        //Vector3 moveVec = new Vector3(moveX, 0, Walkspeed) * MoveSpeed * Time.fixedDeltaTime;
        transform.Translate(new Vector3(moveX * Walkspeed * Time.deltaTime, 0, MoveSpeed * Time.deltaTime));




    }
}
