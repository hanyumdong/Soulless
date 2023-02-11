using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GameManager : MonoBehaviour
{
    Text timer;

    public int stageTime = 10; //스테이지 넘어가는 시간, 난이도 상승 주기

    float time; // 시간
    int sec; // 초
    int min; // 분

    int difficulty; //현재 난이도(미니게임의 수나 미니게임의 난이도 결정)

    List<int> stageNum = new List<int>(); //스테이지 순서를 저장할 리스트
    List<GameObject> stage = new List<GameObject>(); //stageNum 리스트에 따라 결정될 실제 게임 오브젝트이 나열된 리스트

    void Start()
    {
        for(;  stageNum.Count < 6;) //6개가 채워질 때까지 반복해서 채우기 시도
        {
            int random = Random.Range(1, 7); //1~6까지의 랜덤값 반환
            if(!stageNum.Contains(random)) //리스트에 없는 값이라면 리스트에 추가
            {
                stageNum.Add(random);
            }
        }

        for(int i = 0; i < 6; i++) //실제 게임오브젝트를 저장할 배열 채우기
        {
            string name = "Game" + stageNum[i].ToString();
            GameObject obj = GameObject.Find(name);
            stage.Add(obj);
        }

        timer = GameObject.Find("Timer").GetComponent<Text>(); //바꿀 텍스트 설정
        time = 0; // 초기화
        sec = 0;
        min = 0;
        difficulty = 0;

        InvokeRepeating("AddDifficulty", 0, stageTime); //씬 시작 0초 후부터 stageTime(초) 간격으로 addDifficulty 함수 실행
    }

    void Update()
    {
        time += Time.deltaTime; // 실제 계산
        sec = (int)time; // 소숫점 없애고 초로 계산
        if (sec >= 60) // 만약 60초가 되면 (만약을 대비해 이상으로 설정해둠)
        {
            min++; // 분 증가
            time = 0; // 초 초기화
        }

        timer.text = min.ToString("00") + ":" + sec.ToString("00");
    }

    void AddDifficulty() //난이도를 올리는 함수
    {
        if(difficulty < 6) //난이도가 6이하이면 모든 미니게임이 열린 상태가 아니니 열어줘야 함. 배열순으로 미니게임 오픈
        {
            GameObject obj = stage[difficulty];
            Debug.Log(stageNum[difficulty] + "번 활성화\n");
            obj.GetComponent<MinigameIdea>().Activate();
        }

        difficulty++; //난이도 상승, 실제로는 각 미니게임 매니저의 함수를 이용하거나 변수를 바꿔 난이도 상승
        Debug.Log("현재 난이도:" + difficulty + "\n");
    }
}
