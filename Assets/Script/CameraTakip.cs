using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class CameraTakip : MonoBehaviour
{
    [SerializeField] private Transform HeroTarget;
    private Vector3 Offset;
    private Vector3 NewPosition;
    [SerializeField] private float LerpValue;
    void Start()
    {
        Offset = transform.position - HeroTarget.position;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        SetCameraFollow();
    }

    private void SetCameraFollow()
    {
        NewPosition = Vector3.Lerp(transform.position, new Vector3(0, HeroTarget.position.y, HeroTarget.position.z) + Offset, LerpValue * Time.deltaTime);
        transform.position = NewPosition; 
    }
}
