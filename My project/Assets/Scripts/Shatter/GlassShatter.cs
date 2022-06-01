using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlassShatter : MonoBehaviour
{
    public GameObject glassShattered; //this is the variable for the object this will turn into
    public Rigidbody Tool; //this is the tool that will be used to break the object (probably don't need to touch)
    float force; // this is the force generated by the tool (probably don't need to touch)

    void OnCollisionEnter(Collision collision)
    {
        force = Tool.velocity.magnitude * 100; //calculation for force (probably don't need to touch)
        if (collision.rigidbody == Tool && force >800)//this checks if (the object colliding is actually the hammer and if its force is larger than what the formula gives us as its breaking point
        {
            Instantiate(glassShattered, transform.position, transform.rotation); //this is just for making sure that the replaced object has the same coordinates (probably don't need to touch)
            GetComponent<Rigidbody>().AddExplosionForce(200, transform.position, 5); //this makes it so the pieces go everywhere
            Destroy(gameObject); //this removes the old object
        }
    }
}