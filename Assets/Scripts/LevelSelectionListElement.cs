using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Marble
{

    public class LevelSelectionListElement : MonoBehaviour
    {
        #region Fields

        private bool _isUnlocked;
        private string _title;
        private string _sceneName;
        private List<bool> _unlockedStars;

        [SerializeField]
        private TextMeshProUGUI _titleTextMesh;
        [SerializeField]
        private List<GameObject> _starImages;

        #endregion

        #region Public Methods

        public void Fill(string title, string sceneName)
        {
            //_isUnlocked = isUnlocked;
            _title = title;
            _sceneName = sceneName;
            //_unlockedStars = unlockedStars;

            _titleTextMesh.text = _title;
            for (var i = 0; i < _starImages.Count; i++)
            {
                //_starImages[i].SetActive(unlockedStars[i]);
            }
        }

        public void OpenLevel()
        {
            SceneManager.LoadScene(_sceneName);
        }

        #endregion
    }
}