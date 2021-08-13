using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Diamantes1 : MonoBehaviour
{
    public static Diamantes1 instance;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;

        }
    }

    [SerializeField]
    private GameObject audioPrefab;

    [SerializeField]
    private Image Diamante1;

    [SerializeField]
    private GameObject itemPrefab;

    [SerializeField]
    private PolygonCollider2D colidir;

    // Start is called before the first frame update
    void Start()
    {
        colidir.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {

    }


    private void OnTriggerEnter2D(Collider2D other)
    {


        if (other.gameObject.CompareTag("Diamante1"))
        {
            colidir.enabled = false;
            Instantiate(audioPrefab, transform.position, Quaternion.identity);
            Instantiate(itemPrefab, transform.position, Quaternion.identity);
            Diamantes.instance.diamantes += 1; 
            Diamante1.color  = new Color(0, 0, 0, 0);
              

        }

    }
}
