using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallBoy : MonoBehaviour
{

    [SerializeField]
    private GameObject prefabToGenerate;
    [SerializeField]
    private GameObject follower;
    [SerializeField]
    private GameObject camera;
    // Start is called before the first frame update
    void Start()
    {
        var player = Instantiate(prefabToGenerate, transform.position + (Vector3.up * prefabToGenerate.transform.localScale.y), transform.rotation);
        var emptyFollower = Instantiate(follower);
        emptyFollower.GetComponent<ParentPositionSetter>().follow = player.transform;
        camera.GetComponent<CameraFollower>().target = emptyFollower.transform;
        player.GetComponent<SnowBall>().normalizedForward = follower.transform;
    }
}
