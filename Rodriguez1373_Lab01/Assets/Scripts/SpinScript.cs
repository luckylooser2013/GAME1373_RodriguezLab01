using UnityEngine;
using UnityEngine.InputSystem;

public class SpinScript : MonoBehaviour
{
    public Vector3 spinSpeed;
    Transform transf;

    Mouse mouse = Mouse.current;

    private void Update()
    {
        if (mouse.leftButton.wasPressedThisFrame)
        {
            Spin();
        }
    }

    void Spin()
    {
        
        gameObject.transform.Rotate(spinSpeed);
    }

}
