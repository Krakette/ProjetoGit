using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Chave : MonoBehaviour
{

    public static Chave instance;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;

        }

    }


    [SerializeField]
    private Image KeyGold;

    private bool chave;

    [SerializeField]
    private GameObject audioPrefab;

    [SerializeField]
    private GameObject itemPrefab;

    // Start is called before the first frame update
    void Start()
    {
        chave = false;
    }

    // Update is called once per frame
    void Update()
    {

        if (chave)
        {
            KeyGold.color = new Color(1, 1, 1, 1);
        }
        else
        {
            KeyGold.color = new Color(0, 0, 0, 0);
        }

    }


    private void OnTriggerEnter2D(Collider2D other)
    {

        if (other.gameObject.CompareTag("Chave"))
        {
            Destroy(other.gameObject);
            Instantiate(audioPrefab, transform.position, Quaternion.identity);
            Instantiate(itemPrefab, transform.position, Quaternion.identity);
            chave = true;
        }

    }


    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Porta") && chave == true && Input.GetKeyDown(KeyCode.LeftAlt))
        {
            Instantiate(audioPrefab, transform.position, Quaternion.identity);
            transform.position = new Vector3(159, -7, 0);
            chave = false;
            KeyGold.color = new Color(0, 0, 0, 0);
        }

        if (other.gameObject.CompareTag("Porta1") && Input.GetKeyDown(KeyCode.LeftAlt))
        {
            Instantiate(audioPrefab, transform.position, Quaternion.identity);
            transform.position = new Vector3(72, -12, 0);
        }

    }

}
