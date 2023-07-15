using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStackController : MonoBehaviour
{
    public List<GameObject> CubeList = new List<GameObject>();
    private GameObject LastBlockObject;
    void Start()
    {

        UpdateCubeObject();
    }
    public void NewBlock(GameObject CubeObject)
    {
        transform.position = new Vector3(transform.position.x, transform.position.y + 1f, transform.position.z);
        CubeObject.transform.position = new Vector3(LastBlockObject.transform.position.x, LastBlockObject.transform.position.y - 1f, LastBlockObject.transform.position.z);
        CubeObject.transform.SetParent(transform);
        CubeList.Add(CubeObject);
        UpdateCubeObject();
    }

    public void Deleteblock(GameObject CubeObject)
    {
        CubeObject.transform.parent = null;
        CubeList.Remove(CubeObject);
        UpdateCubeObject();
    }

    public void UpdateCubeObject()
    {
        LastBlockObject = CubeList[CubeList.Count - 1];
    }
}
