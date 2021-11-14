using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DoorManager : MonoBehaviour
{
    public GameObject canvas;
    public GameObject yesButton;

    void Start()
    {
        
    }

    void Update()
    {
        if(GameManager.gameManager.time < 360)
        {
            transform.GetChild(0).GetComponent<Text>().text = "���� �ð��� 6�ð� �̸��̹Ƿ� ������ ���� �� �����ϴ�.";
            yesButton.GetComponent<Button>().interactable = false;
        }
        else
        {
            transform.GetChild(0).GetComponent<Text>().text = "������ �����ðڽ��ϱ�?";
            yesButton.GetComponent<Button>().interactable = true;
        }
        
    }

    public void OnYesCilcked()
    {
        OnNoClicked();
        SceneManager.LoadScene("Outside");
    }

    public void OnNoClicked()
    {
        canvas.SetActive(false);
    }
}
