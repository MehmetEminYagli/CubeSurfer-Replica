using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{


    //cubeislemleri
    [SerializeField] private PlayerStackController controller;
    private Vector3 direction = Vector3.forward;
    private bool isStack = false;
    private RaycastHit hit;
    
    void Start()
    {
        controller =    GameObject.FindObjectOfType<PlayerStackController>();
    }


    private void FixedUpdate()
    {
        if (Physics.Raycast(transform.position,direction , out hit, 1f))
        {
            if (!isStack)
            {
                isStack = true;
                controller.NewBlock(gameObject);
                setDirection();
            }
            if (hit.transform.name == "Engel")
            {
                controller.Deleteblock(gameObject);
            }
        }
    }

    private void setDirection()
    {
        direction = Vector3.back;
    }

    




}
