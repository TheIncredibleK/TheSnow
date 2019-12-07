using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParentPositionSetter : MonoBehaviour
{
    [SerializeField]
    public Transform follow;
    // Update is called once per frame
    void Update()
    {
        if (follow != null)
        {
            transform.position = follow.position - (follow.forward * follow.localScale.x) * 2;
        }
    }
}
