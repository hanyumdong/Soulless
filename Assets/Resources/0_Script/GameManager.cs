using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Text timeRecord;

    public float time; // �ð�
    int sec; // ��
    int min; // ��
    // Start is called before the first frame update
    void Start()
    {
        time = 0; // �ʱ�ȭ
        sec = 0;
        min = 0;
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime; // ���� ���
        sec = (int)time; // �Ҽ��� ���ְ� �ʷ� ���
        if (sec == 60) // ���� 60�ʰ� �Ǹ�
        {
            min++; // �� ����
            time = 0; // �� �ʱ�ȭ
        }
        timeRecord.text = "��ƾ �ð�" + min.ToString("00") + ":" + sec.ToString("00");
    }
}
