using UnityEngine;

public class LightController : MonoBehaviour
{
    [SerializeField] Light _light = null;

    [Header("Inputs")]
    [SerializeField] KeyCode _toggleKey = KeyCode.Alpha1;
    [SerializeField] KeyCode _increaseIntensityKey = KeyCode.Alpha2;
    [SerializeField] KeyCode _decreaseIntensityKey = KeyCode.Alpha3;
    [SerializeField] KeyCode _randomColorKey = KeyCode.Alpha4;
    [SerializeField] KeyCode _undoKey = KeyCode.Z;

    CommandStack _commandStack = new CommandStack();

    private void Update()
    {
        DetectToogleInpit();
        DetectIncreaseIntensityInpit();
        DetectDecreaseIntensityInpit();
        DetectRandomColorInpit();
        DetectUndoInpit();
    }

    private void DetectToogleInpit()
    {
        if (Input.GetKeyDown(_toggleKey))
        {
            _commandStack.ExecuteCommand(new LightActiveToggle(_light));
        }
    }

    private void DetectIncreaseIntensityInpit()
    {
        if (Input.GetKeyDown(_increaseIntensityKey))
        {
            _commandStack.ExecuteCommand(new LightIncreaseIntensity(_light));
        }
    }

    private void DetectDecreaseIntensityInpit()
    {
        if (Input.GetKeyDown(_decreaseIntensityKey))
        {
            _commandStack.ExecuteCommand(new LightDecreaseIntensity(_light));
        }
    }

    private void DetectRandomColorInpit()
    {
        if (Input.GetKeyDown(_randomColorKey))
        {
            Color randomColor = ColorCreator.CreateRandomColor();
            _commandStack.ExecuteCommand(new LightColorChange(_light, randomColor));
        }
    }

    private void DetectUndoInpit()
    {
        if (Input.GetKeyDown(_undoKey))
        {
            _commandStack.UndoLastCommand();
        }
    }

}
