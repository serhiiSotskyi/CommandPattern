using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class ColorCreator 
{
    public static Color CreateRandomColor()
    {
        float randonR = UnityEngine.Random.Range(0,1f);
        float randonG = UnityEngine.Random.Range(0, 1f);
        float randonB = UnityEngine.Random.Range(0, 1f);

        Color newColor = new Color(randonR, randonG, randonB, 1);

        return newColor;
    } 
}
