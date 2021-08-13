using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Rotacao : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.gameObject.CompareTag("Heroi"))
        {
           DOTween.Init();
           transform.DORotate(new Vector3(0, 90, 0), 1).SetLoops(-1, LoopType.Incremental);
        }
    }



}
