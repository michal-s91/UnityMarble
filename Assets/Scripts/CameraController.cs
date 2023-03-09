using UnityEngine;

namespace Marble
{

    public class CameraController : MonoBehaviour
    {
        #region Fields

        [SerializeField]
        private float _speed = 20;

        #endregion

        #region Unity Methods

        private void Awake()
        {
            Controls.OnCameraRotation += OnCameraRotation;
        }

        private void OnDestroy()
        {
            Controls.OnCameraRotation -= OnCameraRotation;
        }

        #endregion

        #region Events

        private void OnCameraRotation(float direction)
        {
            gameObject.transform.Rotate(Vector3.up, _speed * direction * Time.deltaTime, Space.World);
        }

        #endregion
    }
}