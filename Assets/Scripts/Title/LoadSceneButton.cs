using UnityEngine;
using UnityEngine.SceneManagement; // �� ������ ���� ���ӽ����̽�

public class LoadSceneButton : MonoBehaviour
{
    public string sceneNameToLoad; // �ε��� ���� �̸�

    // ���� �ε��ϴ� �Լ�
    public void LoadScene()
    {
        SceneManager.LoadScene(sceneNameToLoad);
    }
}