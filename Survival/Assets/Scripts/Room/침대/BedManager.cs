using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BedManager : MonoBehaviour
{
    public GameObject window;
    void Start()
    {
        
    }

    void Update()
    {
        transform.GetChild(0).GetComponent<Text>().text = "ħ�뿡�� �ֹ��ðڽ��ϱ�?\n\n�����ð�: " + (24 - GameManager.gameManager.time) + "�ð�\nHp, MT ȸ����: " + ((24 - GameManager.gameManager.time) / 2);
    }

    public void OnYesClicked()
    {
        GameManager.gameManager.hp += ((24 - GameManager.gameManager.time) / 2);
        GameManager.gameManager.mt += ((24 - GameManager.gameManager.time) / 2);
        GameManager.gameManager.time = 24;
        OnNoClicked();
    }

    public void OnNoClicked()
    {
        window.SetActive(false);
    }
}
