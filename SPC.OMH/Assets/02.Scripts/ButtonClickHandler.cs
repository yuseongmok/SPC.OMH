using UnityEngine;
using UnityEngine.UI;

public class ButtonClickHandler : MonoBehaviour
{
    public Button buttonToDisable;

    private void Start()
    {
        // ��ư Ŭ�� �̺�Ʈ�� �Լ��� ����
        buttonToDisable.onClick.AddListener(DisableButton);
    }

    private void DisableButton()
    {
        // ��ư�� ��Ȱ��ȭ
        buttonToDisable.gameObject.SetActive(false);
    }
}
