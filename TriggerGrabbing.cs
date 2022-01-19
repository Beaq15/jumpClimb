using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerGrabbing : MonoBehaviour
{
    public GameObject rootPos;
    void OnTriggerEnter(Collider obj)
    {
        obj.GetComponentInParent<ClimbUp>().GrabEdge(rootPos.transform);
    }
}
