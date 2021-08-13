using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Moeda : MonoBehaviour
{






    [SerializeField]
    private GameObject audioPrefab;

    [SerializeField]
    private GameObject itemPrefab;


    private bool moeda;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {


    }


    private IEnumerator OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Heroi"))
        {

            Instantiate(audioPrefab, transform.position, Quaternion.identity);
            Instantiate(itemPrefab, transform.position, Quaternion.identity);

           

            yield return new WaitForSeconds(0.5f);

            if (!moeda)
            {
                Dinheiro.instance.dinheiro += 10;
                moeda = true;
            }


        }

    }
}


