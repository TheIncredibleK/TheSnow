using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnowBall : MonoBehaviour {

    [SerializeField]
    private float shrinkSpeed;
    [SerializeField]
    private float acceleration;
    [SerializeField]
    private float shrinkDuration;
    [SerializeField]
    private ParticleSystem emitterWhenHit;
    private bool createdEmitter;
    private ParticleSystem currentEmitter;


    // Non Serializable
    private Rigidbody myRigidBoy;
    private SnowBallConfiguration snowballConfig;

    // Control Direction
    private float horizonal;
    [SerializeField]
    private bool HitByTree;
    private float countdown;

	// Use this for initialization
	void Start ()
    {
        myRigidBoy = gameObject.GetComponent<Rigidbody>();
        snowballConfig = SnowBallConfiguration.Default();
        currentEmitter = Instantiate(emitterWhenHit, transform.position, transform.rotation);
    }

	
	// Update is called once per frame
	void Update ()
    {
        AdjustSizeByGrowthRate();
        SetControls();
        Movement();
        CheckIfHitByTree();
    }

    private void CheckIfHitByTree()
    {
        if(HitByTree)
        {
            var shape = currentEmitter.shape;
            shape.radius = transform.localScale.x;
            currentEmitter.Play();
            
            var currentScale = transform.localScale;
            transform.localScale -= new Vector3(currentScale.x * shrinkSpeed * Time.deltaTime, currentScale.y * shrinkSpeed * Time.deltaTime, currentScale.z * shrinkSpeed * Time.deltaTime);
            countdown += Time.deltaTime;
        }

        if (countdown > shrinkDuration)
        {
            HitByTree = false;
            countdown = 0;
            currentEmitter.Stop();
        }
    }

    private void Movement()
    {
        myRigidBoy.AddForce(Vector3.right * acceleration * Time.deltaTime * horizonal * transform.localScale.x);
    }

    private void SetControls()
    {
        horizonal = Input.GetAxis("Horizontal");
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

        if(collision.gameObject.tag == GameConstants.TREE_TAG)
        {
            HitByTree = true;
        }
    }
}
