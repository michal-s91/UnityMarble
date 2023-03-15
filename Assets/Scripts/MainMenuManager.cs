using System.Collections.Generic;
using UnityEngine;

namespace Marble
{

    public class MainMenuManager : MonoBehaviour
    {
        [SerializeField]
        private Levels _levels;
        [SerializeField]
        private GameObject _levelSelectionListElementPrefab;
        [SerializeField]
        private GameObject _levelListContent;
        private List<LevelSelectionListElement> _levelSelectionListElements;

        void Awake()
        {
            InitializeLevelMenuList();
        }

        private void InitializeLevelMenuList()
        {
            foreach (var levelData in _levels.LevelsData)
            {
                CreateLevelSelectionListElement(levelData);
            }
        }

        private LevelSelectionListElement CreateLevelSelectionListElement(LevelData levelData)
        {
            var instatiatedObject = Instantiate(_levelSelectionListElementPrefab);
            instatiatedObject.transform.SetParent(_levelListContent.transform);

            var levelSelectionElement = instatiatedObject.GetComponent<LevelSelectionListElement>();
            levelSelectionElement.Fill(levelData.Title, levelData.SceneName);

            return levelSelectionElement;

        }

        public void ExitUiButton()
        {
            Application.Quit();
        }
    }
}