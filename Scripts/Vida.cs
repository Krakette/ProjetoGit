using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Vida : MonoBehaviour
{

    public static Vida instance;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;

        }

    }


    [SerializeField]
    private Image[] Life;


    public int vida;

    // Start is called before the first frame update
    void Start()
    {
        vida = 3;
    }

    // Update is called once per frame
    void Update()
    {
        ControleVida();

        if (vida > 3)
        {
            vida = 3;
        }

        if (vida <= 0)
        {
            vida = 0;
        }
    }




    void ControleVida()
    {
        switch (vida)
        {
            case 0:
                Life[0].color = new Color(0, 0, 0, 0);
                Life[1].color = new Color(0, 0, 0, 0);
                Life[2].color = new Color(0, 0, 0, 0);
                break;
            case 1:
                Life[0].color = new Color(1, 1, 1, 1);
                Life[1].color = new Color(0, 0, 0, 0);
                Life[2].color = new Color(0, 0, 0, 0);        
                break;
            case 2:
                Life[0].color = new Color(1, 1, 1, 1);
                Life[1].color = new Color(1, 1, 1, 1);
                Life[2].color = new Color(0, 0, 0, 0);            
                break;
            case 3:
                Life[0].color = new Color(1, 1, 1, 1);
                Life[1].color = new Color(1, 1, 1, 1);
                Life[2].color = new Color(1, 1, 1, 1);             
                break;
   
            default:
                Life[0].color = new Color(0, 0, 0, 0);
                Life[1].color = new Color(0, 0, 0, 0);
                Life[2].color = new Color(0, 0, 0, 0);            
                break;
        }
    }


    


}
