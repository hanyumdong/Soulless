using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinigameIdea : MonoBehaviour
{
    bool isActivate = false; //Ȱ��ȭ ���¸� ǥ���ϴ� ����
    public GameObject player; //�� �̴ϰ��ӿ����� �÷��̾� ������Ʈ

    SpriteRenderer render; //�� �ٲٱ��

    void Start()
    {
        render = GetComponent<SpriteRenderer>();
    }
    void Update()
    {
        if(isActivate)
        {
            render.color = new Color(1, 208/255f, 208/255f); //Ȱ��ȭ�� �� �ٲٱ�
            player.SetActive(true);
        }
        else
        {
            render.color = Color.white; //��Ȱ��ȭ�� �� �ٲٱ�
            player.SetActive(false);
        }
    }

    public void Activate() //�̴ϰ����� Ȱ��ȭ ��Ű�� �Լ�
    {
        isActivate = true;
    }
}