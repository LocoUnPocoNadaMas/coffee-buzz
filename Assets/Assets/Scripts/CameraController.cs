using UnityEngine;

namespace Assets.Scripts
{
    public class CameraController : MonoBehaviour
    {
        [SerializeField] private Transform visionOrientation;
        [Header("Mouse Sensibility")]
        [SerializeField] private float sensX = 400;
        [SerializeField] private float sensY = 400;

        [Header("Clamping")]
        [SerializeField] private float minY = -90;
        [SerializeField] private float maxY = 90;
        
        private float _rotX;
        private float _rotY;
       

        // Start is called before the first frame update
        void Start()
        {
            // locked and hidden in mid of screen
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
        }


        // Update is called once per frame
        void Update()
        {
            var mouseX = Input.GetAxis("Mouse X") * Time.fixedDeltaTime * sensX;
            var mouseY = Input.GetAxis("Mouse Y") * Time.fixedDeltaTime * sensY;
            
            _rotY  += mouseX;
            _rotX  -= mouseY;
            
            _rotX = Mathf.Clamp(_rotX, minY, maxY);
            transform.rotation = Quaternion.Euler(_rotX, _rotY, 0);
            visionOrientation.rotation =  Quaternion.Euler(0, _rotY, 0);
        }
    }
}