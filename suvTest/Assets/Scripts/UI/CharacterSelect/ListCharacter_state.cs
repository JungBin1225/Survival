using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ListCharacter_state : MonoBehaviour
{
    GameManager gameManager;

    CharacterList characterList;
    public Animation anim;

    public int num;
    public int characterType;
    public string characterName;
    public GameObject mesh;
    private Material material;

    // Start is called before the first frame update
    void Start()
    {

        //anim = gameObject.GetComponent<Animation>();
        //material = GetComponentInChildren<Renderer>().material;
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();

        material = mesh.GetComponent<Renderer>().material;
        characterList = GameObject.Find("CharacterList").GetComponent<CharacterList>();
        
        if (num==0)
        {
            if(gameManager.characterDic[characterName]==true)
            {
                material.color = Color.white;
                anim.Play("Running");
                Debug.Log("Start");
            }
            else
            {
                material.color = Color.black;
            }
            
        }
        else
        {
            material.color = Color.black;
        }


    }

    // Update is called once per frame
    void Update()
    {


    }

    public void characterRotationLeft()
    {
        if (num == 0)
        {
            num = 4;
            characterList.characterList[num] = this;
            this.transform.localPosition = characterList.listPos[4];
        }
        else
        {
            num--;
            characterList.characterList[num] = this;
            this.transform.localPosition = characterList.listPos[num];

        }

        //
        if (num == 0)
        {
            if(gameManager.characterDic[characterName] == true)
            {
                material.color = Color.white;
                anim.Play("Running");
            }
            else
            {
                material.color = Color.black;
            }
                
        }
        else if (num != 0)
        {
            material.color = Color.black;
            anim.Stop("Running");
        }
        //StartCoroutine(ListCharacterMoveLeft());

    }






    public void characterRotationRight()
    {
        if (num == 4)
        {
            num = 0;
            characterList.characterList[num] = this;
            this.transform.localPosition = characterList.listPos[0];
        }
        else
        {
            num++;
            characterList.characterList[num] = this;
            this.transform.localPosition = characterList.listPos[num];

        }

        //
        if (num == 0)
        {
            material.color = Color.white;
            anim.Play("Idle");
        }
        else if (num != 0)
        {
            material.color = Color.black;
            anim.Stop("Idle");
        }



    }

/*
    IEnumerator ListCharacterMoveLeft()
    {
        if (num == 0)
        {
            transform.position += characterList.listPos[4] * Time.deltaTime;
        }
        else
        {
            transform.position += characterList.listPos[num--] * Time.deltaTime;
        }


        yield return 0;
    }

    IEnumerator ListCharacterMoveRight()
    {



        yield return 0;
    }*/
}
