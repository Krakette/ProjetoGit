using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Derrota : MonoBehaviour
{
    public static Derrota instance;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;

        }
    }

    public bool derrota;

    [SerializeField]
    private Text continuar;

    [SerializeField]
    private Animator fade;

    [SerializeField]
    private Image fadeimg;

    // Start is called before the first frame update
    void Start()
    {
        derrota = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(Vida.instance.vida <= 0 && Vitoria.instance.vitoria == false)
        {
            derrota = true;

            fade.Play("Fade");
            continuar.color = new Color(1, 1, 1, 1);


            if(Input.GetKeyDown(KeyCode.C))
            {
                Vida.instance.vida = 3;
                fadeimg.color = new Color(0, 0, 0, 0);
                fade.Play("VAZIO");
                continuar.color = new Color(1, 1, 1, 0);
                transform.position = MoveFoxy.instance.posInicial;
                derrota = false;
            }


        }
     
    }
}
