using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnowBall : MonoBehaviour {

    [SerializeField]
    private float growthRate;
    [SerializeField]
    private float initalGrowthRate;

    private Rigidbody myRigidBoy;
    private SnowBallConfiguration snowballConfig;
	// Use this for initialization
	void Start ()
    {
        myRigidBoy = gameObject.GetComponent<Rigidbody>();
        snowballConfig = SnowBallConfiguration.Default();
	}
	
	// Update is called once per frame
	void Update ()
    {
        AdjustSizeByGrowthRate();
	}


    private void AdjustSizeByGrowthRate()
    {
        var currentScale = transform.localScale;
        currentScale += new Vector3(currentScale.x * snowballConfig.GrowthRate * Time.deltaTime, currentScale.y * snowballConfig.GrowthRate * Time.deltaTime, currentScale.z * snowballConfig.GrowthRate * Time.deltaTime);
        transform.localScale = currentScale;
    }

    private void OnCollisionEnter(Collision collision)
    {
        var newSnowBallConfig = collision.gameObject.GetComponent<AbstractGround>();
        if (newSnowBallConfig != null)
        {
            snowballConfig = newSnowBallConfig.GetBallConfiguration();
        }
    }
}
