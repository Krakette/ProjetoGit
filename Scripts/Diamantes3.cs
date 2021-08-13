using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Diamantes3 : MonoBehaviour
{
    public static Diamantes3 instance;

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
    private Image Diamante3;



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


        if (other.gameObject.CompareTag("Diamante3"))
        {
            colidir.enabled = false;
            Destroy(other.gameObject);
            Instantiate(itemPrefab, transform.position, Quaternion.identity);
            Diamantes.instance.diamantes += 1;
            Diamante3.color  = new Color(1, 1, 1, 1);
              

        }

    }
}
