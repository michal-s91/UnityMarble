using UnityEngine;

namespace Marble
{

    public class Tilt : MonoBehaviour
    {
        #region Fields

        private Rigidbody _rigidbody;
        [SerializeField]
        private float _rotationSpeed = 20;

        #endregion

        #region Fields

        public float RotationSpeed { get { return _rotationSpeed; } }

        #endregion

        #region Unity Methods

        private void Awake()
        {
            _rigidbody = GetComponent<Rigidbody>();
            
        }

        #endregion

        #region Public Methods

        public void Rotate(Quaternion deltaRotation)
        {
            _rigidbody.MoveRotation(deltaRotation);
        }

        #endregion
    }
}