using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiniGame_undine : MonoBehaviour
{
    public Transform shield; // 방패 위치값
    public Transform player1; // 플레이어 1 위치값
    public Transform arrow; // 화살표

    public GameObject arrow_; // 화살표 오브젝트

    public int arrowSpeed;
    bool isArrowAppear;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            shield.position = new Vector3(0, 1.5f, 0); // 윗쪽
            shield.eulerAngles = new Vector3(0, 0, 0); // 회전 초기화
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            shield.position = new Vector3(0, -1.5f, 0); // 아랫쪽
            shield.eulerAngles = new Vector3(0, 0, 0); // 회전 초기화
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            shield.position = new Vector3(-1.5f, 0, 0); // 왼쪽
            shield.eulerAngles = new Vector3(0, 0, 90); // 90도 회전
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            shield.position = new Vector3(1.5f, 0, 0); // 오른쪽
            shield.eulerAngles = new Vector3(0, 0, 90); // 90도 회전
        }
    }
    private void LateUpdate()
    {
        arrow.position = Vector3.Lerp(arrow.position, player1.position, arrowSpeed * Time.deltaTime);
    }

    void ArrowAppear()
    {
        //Instantiate(arrow_, )
    }
}
