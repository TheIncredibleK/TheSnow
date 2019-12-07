using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class AbstractGround : MonoBehaviour
{

    [SerializeField]
    protected float growthRate;

    protected SnowBallConfiguration SnowBallConfiguration;


    public SnowBallConfiguration GetBallConfiguration()
    {
        return SnowBallConfiguration;
    }
}
