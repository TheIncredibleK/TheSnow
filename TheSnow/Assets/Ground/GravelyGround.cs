using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravelyGround : AbstractGround
{
    // Start is called before the first frame update
    void Start()
    {
        SnowBallConfiguration = new SnowBallConfiguration(growthRate);
    }
}
