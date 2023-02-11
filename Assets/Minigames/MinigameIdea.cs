using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinigameIdea : MonoBehaviour
{
    bool isActivate = false; //활성화 상태를 표현하는 변수
    public GameObject player; //이 미니게임에서의 플레이어 오브젝트

    SpriteRenderer render; //색 바꾸기용

    void Start()
    {
        render = GetComponent<SpriteRenderer>();
    }
    void Update()
    {
        if(isActivate)
        {
            render.color = new Color(1, 208/255f, 208/255f); //활성화시 색 바꾸기
            player.SetActive(true);
        }
        else
        {
            render.color = Color.white; //비활성화시 색 바꾸기
            player.SetActive(false);
        }
    }

    public void Activate() //미니게임을 활성화 시키는 함수
    {
        isActivate = true;
    }
}