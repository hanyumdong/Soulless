using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Text timeRecord;

    public float time; // 시간
    int sec; // 초
    int min; // 분
    // Start is called before the first frame update
    void Start()
    {
        time = 0; // 초기화
        sec = 0;
        min = 0;
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime; // 실제 계산
        sec = (int)time; // 소숫점 없애고 초로 계산
        if (sec == 60) // 만약 60초가 되면
        {
            min++; // 분 증가
            time = 0; // 초 초기화
        }
        timeRecord.text = "버틴 시간" + min.ToString("00") + ":" + sec.ToString("00");
    }
}
