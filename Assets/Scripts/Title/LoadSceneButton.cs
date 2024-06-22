using UnityEngine;
using UnityEngine.SceneManagement; // 씬 관리를 위한 네임스페이스

public class LoadSceneButton : MonoBehaviour
{
    public string sceneNameToLoad; // 로드할 씬의 이름

    // 씬을 로드하는 함수
    public void LoadScene()
    {
        SceneManager.LoadScene(sceneNameToLoad);
    }
}