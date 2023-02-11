using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GameManager : MonoBehaviour
{
    Text timer;

    public int stageTime = 10; //�������� �Ѿ�� �ð�, ���̵� ��� �ֱ�

    float time; // �ð�
    int sec; // ��
    int min; // ��

    int difficulty; //���� ���̵�(�̴ϰ����� ���� �̴ϰ����� ���̵� ����)

    List<int> stageNum = new List<int>(); //�������� ������ ������ ����Ʈ
    List<GameObject> stage = new List<GameObject>(); //stageNum ����Ʈ�� ���� ������ ���� ���� ������Ʈ�� ������ ����Ʈ

    void Start()
    {
        for(;  stageNum.Count < 6;) //6���� ä���� ������ �ݺ��ؼ� ä��� �õ�
        {
            int random = Random.Range(1, 7); //1~6������ ������ ��ȯ
            if(!stageNum.Contains(random)) //����Ʈ�� ���� ���̶�� ����Ʈ�� �߰�
            {
                stageNum.Add(random);
            }
        }

        for(int i = 0; i < 6; i++) //���� ���ӿ�����Ʈ�� ������ �迭 ä���
        {
            string name = "Game" + stageNum[i].ToString();
            GameObject obj = GameObject.Find(name);
            stage.Add(obj);
        }

        timer = GameObject.Find("Timer").GetComponent<Text>(); //�ٲ� �ؽ�Ʈ ����
        time = 0; // �ʱ�ȭ
        sec = 0;
        min = 0;
        difficulty = 0;

        InvokeRepeating("AddDifficulty", 0, stageTime); //�� ���� 0�� �ĺ��� stageTime(��) �������� addDifficulty �Լ� ����
    }

    void Update()
    {
        time += Time.deltaTime; // ���� ���
        sec = (int)time; // �Ҽ��� ���ְ� �ʷ� ���
        if (sec >= 60) // ���� 60�ʰ� �Ǹ� (������ ����� �̻����� �����ص�)
        {
            min++; // �� ����
            time = 0; // �� �ʱ�ȭ
        }

        timer.text = min.ToString("00") + ":" + sec.ToString("00");
    }

    void AddDifficulty() //���̵��� �ø��� �Լ�
    {
        if(difficulty < 6) //���̵��� 6�����̸� ��� �̴ϰ����� ���� ���°� �ƴϴ� ������� ��. �迭������ �̴ϰ��� ����
        {
            GameObject obj = stage[difficulty];
            Debug.Log(stageNum[difficulty] + "�� Ȱ��ȭ\n");
            obj.GetComponent<MinigameIdea>().Activate();
        }

        difficulty++; //���̵� ���, �����δ� �� �̴ϰ��� �Ŵ����� �Լ��� �̿��ϰų� ������ �ٲ� ���̵� ���
        Debug.Log("���� ���̵�:" + difficulty + "\n");
    }
}
