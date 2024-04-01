using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamFollow : MonoBehaviour
{

    [SerializeField] private Transform toFollowObject;
    [SerializeField] private Vector3  offset;

    private Transform tr;
    
    void Start()
    {
        this.tr = transform;
    }
    
    void LateUpdate()
    {
        this.tr.position = this.toFollowObject.position + this.offset;
    }
}
