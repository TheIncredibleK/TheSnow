using System;
public class SnowyGround : AbstractGround
{

    // Start is called before the first frame update
    void Start()
    {
        growthRate = 0.05f;
        SnowBallConfiguration = new SnowBallConfiguration(growthRate);
    }
}
