using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovemenStateManager : MonoBehaviour
{
    public float moveSpeed = 3;
    [HideInInspector] public Vector3 dir;
    float hzInput, vInput;
    CharacterController controller;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        GetDirectionAndMove();
    }
    void GetDirectionAndMove()
    {
        hzInput = Input.GetAxis("Horizontal");
        vInput = Input.GetAxis("Vertioval"); ;

        dir = transform.forward * vInput + transform.right * hzInput;
    }
    
}
