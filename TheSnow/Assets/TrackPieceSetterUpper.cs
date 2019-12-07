using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrackPieceSetterUpper : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i < transform.childCount; i++)
        {
            var child = transform.GetChild(i);
            child.gameObject.AddComponent<SnowyGround>();
            child.gameObject.AddComponent<Rigidbody>();
            child.gameObject.GetComponent<Rigidbody>().useGravity = false;
            child.gameObject.GetComponent<Rigidbody>().isKinematic = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
