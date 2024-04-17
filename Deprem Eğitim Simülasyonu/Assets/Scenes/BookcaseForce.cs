using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BookcaseForce : MonoBehaviour
{
    public float speed = 1.0f; //how fast it shakes
    public float amount = 1.0f; //how much it shakes

    public bool test = true;
    Rigidbody b_rigidbody;
    public float forceMagnitude = 20f;
    // Start is called before the first frame update
    void Start()
    {
        b_rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (test)
        {
            Debug.Log("sikiþ");
            //transform.position.x = Mathf.Sin(Time.time * speed) * amount;
            //b_rigidbody.AddForce(Vector3.left * forceMagnitude);
            test = false;
        }
    }
}
