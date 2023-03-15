using System.Collections.Generic;
using UnityEngine;

namespace Marble
{
    public class Levels : MonoBehaviour
    {
        [SerializeField]
        private List<LevelData> _levelsData;

        public List<LevelData> LevelsData { get { return _levelsData; } }
    }

    [System.Serializable]
    public struct LevelData
    {
        [SerializeField]
        private string _title;
        [SerializeField]
        private string _sceneName;

        public string Title { get { return _title; } }
        public string SceneName { get { return _sceneName; } }
    }
}