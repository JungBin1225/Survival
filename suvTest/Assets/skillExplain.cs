using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class skillExplain : MonoBehaviour
{
    public Sprite skillImg;
    public Text skillText;

    public GameObject skillExplainBox;
    private PlayerController player;
    

    // Start is called before the first frame update
    void Start()
    {
        skillImg = this.GetComponent<Image>().sprite;
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>();
       
    }


    public void checkSkillChangeImgUI()
    {
        
        skillImg = this.GetComponent<Image>().sprite;
        //Debug.Log(skillImg.name);
        if(skillImg==null)
        {

        }
        else
        {
            if (skillImg.name.Contains("Ball"))
            {

                skillText.text = "��ų ��Lv"+player.ballLV.ToString()+": ������ ���� �ڵ����� �������ִ� ���� ��ȯ(+������ ���� �� ���� �߰�)";
            }
            else if (skillImg.name.Contains("KnockBack"))
            {
                skillText.text = "��ų �˹�Lv" + player.knockbackLV.ToString() + ": ���� �������� ������ ������ ������ ���� ��ó����";
            }
            else if (skillImg.name.Contains("Nautilus"))
            {
                skillText.text = "��ų ��ƿ����Lv" + player.nautilusLV.ToString() + ": ���� �������� ���� �����ϴ� ���ٱ⸦ �߻��Ѵ�";
            }
            else if (skillImg.name.Contains("Taunt"))
            {
                skillText.text = "��ų ����LV" + player.tauntLV.ToString() + ": ������ �����ϴ� ���߹�ü�� �����Ѵ�";
            }
            else if (skillImg.name.Contains("Virus"))
            {
                skillText.text = "��ų ���̷���Lv" + player.virusLV.ToString() + ": ���鿡�� ������ �������� �ִ� ���� �Ѹ���";
            }
        }


    }
    

    public void OnPointerEnter()
    {
        skillExplainBox.SetActive(true);
    }
    public void OnPointerExit()
    {
        skillExplainBox.SetActive(false);
    }


    // Update is called once per frame
    void Update()
    {
        checkSkillChangeImgUI();

    }
}
