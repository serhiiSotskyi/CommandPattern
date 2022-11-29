using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightColorChange : ICommand
{

    Light _light;
    Color _originalColor;
    Color _newColor;

    public LightColorChange(Light light, Color newColor)
    {
        _light = light;
        _originalColor = light.color;
        _newColor = newColor;
    }

    public void Execute()
    {
        Debug.Log("Assigned new color: " + _newColor);
        _light.color = _newColor;
    }

    public void Undo()
    {
        Debug.Log("Assigned back to the original color: " + _originalColor);
        _light.color = _originalColor;
    }
}
