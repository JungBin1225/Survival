using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tutorial_1Manager : MonoBehaviour
{
    public int flowCount;
    public GameObject tutoTextBoxGameObj;
    public GameObject horizontalAxisController;
    public GameObject horizontalAxisControllerParent;

    public GameObject forwardController;
    public GameObject backController;
    public GameObject nextStage;
    
    public int showCount=0;
    public int clickCount;
    tutorialTextBox tutoTextBox;
    Coroutine col;
    // Start is called before the first frame update
    void Start()
    {
        //col = StartCoroutine(showHorizontalController());
        
        tutoTextBoxGameObj.SetActive(true);
        tutoTextBox = GameObject.Find("tutoTextBox").GetComponent<tutorialTextBox>();


    }
    IEnumerator delay()
    {
        
        yield return new WaitForSeconds(0.5f);
        horizontalAxisController.SetActive(false);
        
    }
    IEnumerator delay2()
    {
        
        /*if(showCount<=2)
        {
            backController.SetActive(true);
            forwardController.SetActive(true);
        }
        else
        {
            backController.SetActive(false);
            forwardController.SetActive(false);
        }*/
        
        backController.SetActive(true);
        forwardController.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        
        backController.SetActive(false);
        forwardController.SetActive(false);
        if(showCount==1)
        {
            forwardController.SetActive(true);
            backController.SetActive(true);
        }
       
        

    }


    //invokeȣ���̶� �޼ҵ带 ���� �������� ����;

    public void showHorizontalController()
    {
        if(showCount>=2)
        {
            CancelInvoke("showHorizontalController");
            showCount = 0;
        }
        horizontalAxisController.SetActive(true);
        StartCoroutine(delay());
        showCount++;
    }
    public void showForwardBackController()
    {
        if (showCount >= 3)
        {
            
            CancelInvoke("showForwardBackController");
            showCount = 0;
            forwardController.SetActive(true);
            backController.SetActive(true);

        }
        StartCoroutine(delay2());
        showCount++;

    }


    // Update is called once per frame
    void Update()
    {

        
    }

    //�¿� �ü� ���� ��ư ǥ��
    public void flow_1()
    {
        tutoTextBoxGameObj.SetActive(false);

        horizontalAxisControllerParent.SetActive(true);


        InvokeRepeating("showHorizontalController", 0.5f, 1);



    }
    


/*    ������
- ����, ���� �ڿ������� ���ư��ݾ�!��

AI
- �����ñ� �̸��ϴ�.���� ��ư���� �յڷ� �̵��غ��ñ� �ٶ��ϴ�.��
*/
    public void flow_2()
    {
        clickCount = 0;
        tutoTextBoxGameObj.SetActive(true);
        tutoTextBox.textFlow2();
    }

    //�յ� �̵� ��Ʈ�ѷ� ���̱�
    public void flow_3()
    {
        tutoTextBoxGameObj.SetActive(false);
        InvokeRepeating("showForwardBackController", 0.5f, 1);
        
    }

    //�յڷ� �̵� �� 
/*    AI
- �����ϼ̽��ϴ�.���� ����� �ٸ� ������ �̵��� ��Ż�� �̵��� ���ʽÿ�.��

*/
    public void flow_4()
    {
        tutoTextBoxGameObj.SetActive(true);
        tutoTextBox.textFlow3();
    }

    //��Ż ���� �� �̵� �� Ʃ�丮��2�� �̵�
    public void flow_5()
    {
        tutoTextBoxGameObj.SetActive(false);
        nextStage.SetActive(true);
    }

    public void OnPauseClicked(GameObject menu)
    {
        menu.SetActive(true);
    }
}
