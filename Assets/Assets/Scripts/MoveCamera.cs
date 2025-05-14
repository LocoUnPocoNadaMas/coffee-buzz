using UnityEngine;

namespace Assets.Scripts
{
    public class MoveCamera : MonoBehaviour
    {
        [SerializeField] private Transform camera1StPerson;
        [SerializeField] private Transform camera3StPerson;
        [SerializeField] private PlayerController playerController;
        private Transform _currentCamera;


        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            _currentCamera = camera1StPerson;
            playerController.OnChangeCameraPosition += ChangeCameraPosition;
        }

        // Update is called once per frame
        void Update()
        {
            transform.position = _currentCamera.position;
        }


        private void ChangeCameraPosition(int i)
        {
            _currentCamera = i switch
            {
                1 => camera1StPerson,
                2 => camera3StPerson,
                _ => _currentCamera
            };
        }
    }
}