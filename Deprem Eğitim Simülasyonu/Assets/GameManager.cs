using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public float timeValue;
    public GameObject alanlar;
    public GameObject depremE�yalar�;
    public GameObject timerText;

    [Header("Which Scene")]
    public bool trainingMode;
    public bool simulationMode;

    public static GameManager instance;
    private void Awake()
    {
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (trainingMode)
        {
            alanlar.SetActive(true);
            depremE�yalar�.SetActive(true);
            timerText.SetActive(false);
        }

        else if (simulationMode)
        {
            alanlar.SetActive(false);
            depremE�yalar�.SetActive(false);
            timerText.SetActive(true);
        }
        //Debug.Log(Mat.instance.objectCount);
    }
}
