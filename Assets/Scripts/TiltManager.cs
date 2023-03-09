using UnityEngine;

namespace Marble
{

    public class TiltManager : MonoBehaviour
    {
        #region Fields

        [SerializeField]
        private Tilt _activeTilt;

        #endregion

        #region Unity Methods
        
        void FixedUpdate()
        {
            Quaternion deltaRotation = Quaternion.Euler(Controls.MovementInput * _activeTilt.RotationSpeed * Time.deltaTime);
            _activeTilt.Rotate(deltaRotation);
        }

        #endregion
    }
}