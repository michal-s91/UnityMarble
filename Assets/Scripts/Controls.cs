using UnityEngine;

namespace Marble
{
    public class Controls : MonoBehaviour
    {
        #region Fields

        static private Vector3 _movementInput;

        #endregion

        #region Properties

        static public Vector3 MovementInput { get { return _movementInput; } }

        #endregion

        #region Events

        public delegate void RotateCamera(float direction);
        public static event RotateCamera OnCameraRotation;

        #endregion

        #region Unity Methods

        private void Update()
        {
            ControlCamera();
        }

        private void FixedUpdate()
        {
            _movementInput.x = Input.GetAxis("Horizontal");
            _movementInput.z = Input.GetAxis("Vertical");
        }

        #endregion

        #region Private Methods

        private void ControlCamera()
        {
            if (Input.GetKey(KeyCode.Q))
            {
                OnCameraRotation?.Invoke(1);
            }

            if (Input.GetKey(KeyCode.E))
            {
                OnCameraRotation?.Invoke(-1);
            }
        }

        #endregion
    }
}