using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class NextScenes : MonoBehaviour
{
    public string Scenes;  // ���� ���� �̸�

    private void Start()
    {
        Button button = GetComponent<Button>();
        button.onClick.AddListener(ChangeScene);
    }

    private void ChangeScene()
    {
        SceneManager.LoadScene(Scenes);
    }
}

