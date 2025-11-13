using UnityEngine;

namespace XREAL
{
    public class StartGame : MonoBehaviour
    {
        public void GameStart()
        {
            LevelManager.Instance.LoadSceneAsync("Assignment_VR_2");
        }
    }
}
