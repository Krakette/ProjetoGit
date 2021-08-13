using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dinheiro : MonoBehaviour
{
    public static Dinheiro instance;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;

        }
    }



    [SerializeField]
    private Text txtDinheiro;

    [SerializeField]
    private GameObject audioPrefab;

    [SerializeField]
    private GameObject itemPrefab;

    
    public int dinheiro;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
        txtDinheiro.text = dinheiro.ToString("000");


        if (dinheiro >= 999)
        {
            dinheiro = 0;
        }

    }


    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("MoedaB"))
        {
            Destroy(other.gameObject);
            Instantiate(audioPrefab, transform.position, Quaternion.identity);
            Instantiate(itemPrefab, transform.position, Quaternion.identity);
            dinheiro += 1;
        }
        if (other.gameObject.CompareTag("MoedaP"))
        {
            Destroy(other.gameObject);

            Instantiate(audioPrefab, transform.position, Quaternion.identity);
            Instantiate(itemPrefab, transform.position, Quaternion.identity);

            dinheiro += 5;
        }
        if (other.gameObject.CompareTag("MoedaG"))
        {
            Destroy(other.gameObject);
            Instantiate(audioPrefab, transform.position, Quaternion.identity);
            Instantiate(itemPrefab, transform.position, Quaternion.identity);
            dinheiro += 10;
        }

        if (other.gameObject.CompareTag("Moeda"))
        {
            Destroy(other.gameObject);
            Instantiate(audioPrefab, transform.position, Quaternion.identity);
            Instantiate(itemPrefab, transform.position, Quaternion.identity);
        }


        if (other.gameObject.CompareTag("moedaB"))
        {
            Destroy(other.gameObject);
           Instantiate(itemPrefab, transform.position, Quaternion.identity);
            dinheiro += 1;
        }


        if (other.gameObject.CompareTag("moedaP"))
        {
            Destroy(other.gameObject);
            Instantiate(audioPrefab, transform.position, Quaternion.identity);
            dinheiro += 5;
        }

        if (other.gameObject.CompareTag("moedaG"))
        {
            Destroy(other.gameObject);
            Instantiate(audioPrefab, transform.position, Quaternion.identity);
            Instantiate(itemPrefab, transform.position, Quaternion.identity);
            dinheiro += 10;
        }
    }

}
