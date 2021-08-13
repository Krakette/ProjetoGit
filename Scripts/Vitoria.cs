using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Vitoria : MonoBehaviour
{

    public static Vitoria instance;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;

        }
    }

    [SerializeField]
    private Text continuar;

    [SerializeField]
    private Animator fade;

    [SerializeField]
    private Image fadeimg;

    public bool vitoria;

    // Start is called before the first frame update
    void Start()
    {
        vitoria = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(vitoria == true && Derrota.instance.derrota == false)
        {
            fade.Play("Fade");
            continuar.color = new Color(1, 1, 1, 1);


            if(Input.GetKeyDown(KeyCode.C))
            {
                Vida.instance.vida = 3;
                fadeimg.color = new Color(0, 0, 0, 0);
                fade.Play("VAZIO");
                continuar.color = new Color(1, 1, 1, 0);
                vitoria = false;
                transform.position = MoveFoxy.instance.posInicial;
            }


        }
       
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
 
    }
}
