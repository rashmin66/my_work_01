using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hellow : MonoBehaviour {
    private Rigidbody rb;
    public Vector3 position;
    public float speed;

    // Start is called before the first frame update
    void Start () {
      rb = GetComponent<Rigidbody>();
      position=transform.position;  
    }

    // Update is called once per frame
    void FixedUpdate() {
       position.z += Input.GetAxis("Horizontal") * -0.1f;
       position.x += Input.GetAxis("Vertical") * speed;

       Vector3 vel = rb.velocity;
             //position.x = v;
      //Debug.Log(transform.position.x);
      //if(transform.position.z<4.5 && transform.position.z>1.5)
      position.z = Mathf.Clamp(position.z,1.5f,4.5f);
      position.y = transform.position.y;
      transform.position=position;
          // vel.z = h;
      //else { vel.z = 0; }
              //rb.velocity = vel;
    }
}
