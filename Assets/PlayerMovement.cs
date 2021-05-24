using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    public float jumpspeed;
    public float playerspeed;
    // Update is called once per frame
    void FixedUpdate()
    {
       // JumpMovement();
        this.GetComponent<Rigidbody>().velocity=new Vector3(playerspeed*Time.deltaTime,GetComponent<Rigidbody>().velocity.y,GetComponent<Rigidbody>().velocity.z);
    }

    private void OnCollisionStay(Collision collision)
    {
       // print(collision.gameObject.name);
        if(collision.gameObject.CompareTag("block"))
        {
        JumpMovement();
        }
    }

    private  void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.GetComponent<ObstacleBehaviour>()!=null)
        {
            Destroy(this.gameObject);
        }
    }

    private void JumpMovement()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            this.GetComponent<Rigidbody>().AddForce(new Vector3(0,jumpspeed,0));
           // print("Jumped");
        }
    }
}
