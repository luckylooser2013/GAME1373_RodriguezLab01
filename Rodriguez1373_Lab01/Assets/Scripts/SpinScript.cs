using UnityEngine;
using UnityEngine.InputSystem;

public class SpinScript : MonoBehaviour
{
    public Vector3 spinSpeed;
    Transform transf;

    Touchscreen touch = Touchscreen.current;
    Mouse mouse = Mouse.current;

    private void Update()
    {
        if (mouse.leftButton.wasPressedThisFrame)
        {
            Spin();
        }
        
        if (touch.press.wasPressedThisFrame)
        {
            Spin();
        }
    }

    void Spin()
    {
        
        gameObject.transform.Rotate(spinSpeed);
    }

}
