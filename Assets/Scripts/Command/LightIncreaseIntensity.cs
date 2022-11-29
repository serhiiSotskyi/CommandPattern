using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightIncreaseIntensity : ICommand
{
    float _increaseAmount = .1f;
    Light _light;

    public LightIncreaseIntensity(Light light)
    {
        _light = light;
    }

    public void Execute()
    {
        Debug.Log("Increase intensity by: " + _increaseAmount);
        _light.intensity += _increaseAmount;
    }

    public void Undo()
    {
        Debug.Log("Undo: Increase intensity by: " + _increaseAmount);
        _light.intensity -= _increaseAmount;
    }
}
