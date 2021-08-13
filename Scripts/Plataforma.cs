using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plataforma : MonoBehaviour
{
    public static Plataforma instance;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;

        }

    }



    [SerializeField]
    private GameObject plataformaSecreta;


    private Vector3 plataforma1;

    private Vector3 plataforma2;


    // Start is called before the first frame update
    void Start()
    {
        plataforma1 = new Vector3(98, -10, 0);
        plataforma2 = new Vector3(102, -6, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (Diamantes.instance.diamantes == 3)
        {
            Instantiate(plataformaSecreta, plataforma1, Quaternion.identity);
            Instantiate(plataformaSecreta, plataforma2, Quaternion.identity);
        }
    }
}
