using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Diamantes : MonoBehaviour
{
    public static Diamantes instance;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;

        }
    }


    public int diamantes;




    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }



}
