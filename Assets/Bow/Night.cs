using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.XR.Interaction.Toolkit;

public class Night : MonoBehaviour
{
    

    [SerializeField] InputActionProperty AButtonPress;

    [SerializeField]
    private GameObject objectToActivate;
    public GameObject objectToActivate2;
    private bool isButtonPressed = false;

    private void OnEnable()
    {
        AButtonPress.action.started += ButtonPressed;
        AButtonPress.action.canceled += ButtonUp;
    }

    private void ButtonPressed(InputAction.CallbackContext context)
    {
        if(AButtonPress.action.ReadValue<float>() ==1f && !isButtonPressed)
        {
            objectToActivate.SetActive(!objectToActivate.activeInHierarchy);
            objectToActivate2.SetActive(!objectToActivate2.activeInHierarchy);
            isButtonPressed = true;
        }
    }

    private void ButtonUp(InputAction.CallbackContext context)
    {
        isButtonPressed = false;
    }
}
