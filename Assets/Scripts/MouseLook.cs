using UnityEngine;

public class MouseLook : MonoBehaviour
{
    [SerializeField]
    private float mouseSensitivity = 100f;
    private float xRotation = 0f;
    private float yRotation = 0f;
    private void Start()
 {
 Cursor.lockState=CursorLockMode.Locked;
 Cursor.visible = false;
 Vector3 initalRotation = transform.localRotation.eulerAngles;
 xRotation = initalRotation.x;
 yRotation = initalRotation.y;
 }
   private void Update()
   {
      float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
      float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;
      xRotation -= mouseY;
      yRotation += mouseX;
      xRotation = Mathf.Clamp(xRotation, -90f, 90f);
      transform.localRotation = Quaternion.Euler(xRotation, yRotation, 0f);
   }
}
