using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenZone : MonoBehaviour
{
    public GameObject hidingImage;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("PlayerTrigger"))
        {
            hidingImage.SetActive(true);
        }

        else
        {
            hidingImage.SetActive(false);
        }
    }
}
