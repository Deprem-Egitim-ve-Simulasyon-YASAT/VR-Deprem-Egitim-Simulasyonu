using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Mat : MonoBehaviour
{
    public int objectCount = 0;

    [SerializeField] Ease easeType = Ease.OutBounce;

    public static Mat instance;
    #region Singleton
    private void Awake()
    {
        instance = this;
    }
    #endregion
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Material"))
        {
            objectCount++;
            collision.gameObject.tag = "Selected";
        }

        else if (collision.gameObject.tag == "Untagged")
        {
            collision.transform.DOMove(new Vector3(15, 5, 17), 1f).SetEase(easeType);
        }
    }
}
