using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnowBall : MonoBehaviour {

    [SerializeField]
    private float growthRate;

    private Rigidbody myRigidBoy;
	// Use this for initialization
	void Start ()
    {
        myRigidBoy = gameObject.GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update ()
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            GetBigger();
        }
	}


    private void GetBigger()
    {
        var currentScale = transform.localScale;
        currentScale += new Vector3(currentScale.x * growthRate * Time.deltaTime, currentScale.y * growthRate * Time.deltaTime, currentScale.z * growthRate * Time.deltaTime);
        transform.localScale = currentScale;
    }


}
