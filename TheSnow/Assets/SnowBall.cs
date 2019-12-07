using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnowBall : MonoBehaviour {

    [SerializeField]
    private float growthRate;
    [SerializeField]
    private float initalGrowthRate;
    private Rigidbody myRigidBoy;
	// Use this for initialization
	void Start ()
    {
        myRigidBoy = gameObject.GetComponent<Rigidbody>();

	}
	
	// Update is called once per frame
	void Update ()
    {

        if (Input.GetKey(KeyCode.Space))
        {
            AdjustSizeByGrowthRate();
        }
	}


    private void AdjustSizeByGrowthRate()
    {
        var currentScale = transform.localScale;
        currentScale += new Vector3(currentScale.x * growthRate * Time.deltaTime, currentScale.y * growthRate * Time.deltaTime, currentScale.z * growthRate * Time.deltaTime);
        transform.localScale = currentScale;
    }


    private void SetGrowthRate(float newGrowthRate)
    {
        growthRate = newGrowthRate;
    }

}
