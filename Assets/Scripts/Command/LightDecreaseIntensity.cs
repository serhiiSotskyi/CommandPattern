using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightDecreaseIntensity : ICommand
{
    float _increaseAmount = .1f;
    Light _light;

    public LightDecreaseIntensity(Light light)
    {
        _light = light;
    }

    public void Execute()
    {
        Debug.Log("Decrease intensity by: " + _increaseAmount);
        _light.intensity -= _increaseAmount;
    }

    public void Undo()
    {
        Debug.Log("Undo: Decrease intensity by: " + _increaseAmount);
        _light.intensity += _increaseAmount;
    }
}
