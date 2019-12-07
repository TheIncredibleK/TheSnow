using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParentPositionSetter : MonoBehaviour
{
    [SerializeField]
    private Transform follow;
    // Update is called once per frame
    void Update()
    {
        transform.position = follow.position - (follow.forward * follow.localScale.x) * 2;   
    }
}
