using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BookcaseForce : MonoBehaviour
{
    public float shakeMagnitude = 0.5f;
    public float shakeSpeed = 20f;

    private Vector3 initialPosition;

    public bool test = true;
    Rigidbody b_rigidbody;
    public float forceMagnitude = 200f;

    // Start is called before the first frame update
    void Start()
    {
        b_rigidbody = GetComponent<Rigidbody>();
        initialPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            float shakeAmountX = Random.Range(-1f, 1f) * shakeMagnitude;
            float shakeAmountY = Random.Range(-1f, 1f) * shakeMagnitude;

            Vector3 newPos = initialPosition + new Vector3(shakeAmountX, shakeAmountY, 0);
            transform.position = Vector3.Lerp(transform.position, newPos, Time.deltaTime * shakeSpeed);
        }

        if (test)
        {
            if (Input.GetKeyUp(KeyCode.E))
            {
                Vector3 localForward = transform.TransformDirection(Vector3.back);
                b_rigidbody.AddForce(localForward * forceMagnitude);
                
                //b_rigidbody.AddForce(Vector3.left * forceMagnitude);
            }
        }
    }
}
