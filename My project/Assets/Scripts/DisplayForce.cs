using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayForce : MonoBehaviour
{
    public Rigidbody rb;
    public Text ValueText;
    float force;
    float mass = 100;
    void Update()
    {
        force = rb.velocity.magnitude * mass;
        ValueText.text = "Force: " + force.ToString();
    }
}
