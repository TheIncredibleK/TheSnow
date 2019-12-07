using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnowBallConfiguration : MonoBehaviour
{
    public float GrowthRate { get; }

    public SnowBallConfiguration(float growthRate)
    {
        GrowthRate = growthRate;
    }

    public static SnowBallConfiguration Default()
    {
        return new SnowBallConfiguration(0);
    }
}
