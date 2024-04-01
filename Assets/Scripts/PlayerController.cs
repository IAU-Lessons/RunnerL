using System;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Win32.SafeHandles;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    [SerializeField] private float  speed = 5f;

    private Transform tr;
    private Animator _animator;
    
    void Start()
    {
        this.tr = transform;
        this._animator = GetComponent<Animator>();
    }
    
    void Update()
    {

        if (!GameManager.Instance.isGameStarted) return;
        
        float horizontal = Input.GetAxis("Horizontal");
        
        this._animator.SetBool("iswalk", true);

        this.tr.position += this.tr.forward * speed * Time.deltaTime;
        this.tr.Translate(speed * horizontal * Time.deltaTime, 0, 0);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Finish")
        {
            this._animator.SetBool("isdance", true);
            GameManager.Instance.isGameStarted = false;
        }        
    }

}
