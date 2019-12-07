using System;
public class SnowyGround : AbstractGround
{


    // Start is called before the first frame update
    void Start()
    {
        SnowBallConfiguration = new SnowBallConfiguration(growthRate);
    }
}
