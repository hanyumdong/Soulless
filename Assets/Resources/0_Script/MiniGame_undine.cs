using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiniGame_undine : MonoBehaviour
{
    public Transform shield; // ���� ��ġ��
    public Transform player1; // �÷��̾� 1 ��ġ��
    public Transform arrow; // ȭ��ǥ

    public GameObject arrow_; // ȭ��ǥ ������Ʈ

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
            shield.position = new Vector3(0, 1.5f, 0); // ����
            shield.eulerAngles = new Vector3(0, 0, 0); // ȸ�� �ʱ�ȭ
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            shield.position = new Vector3(0, -1.5f, 0); // �Ʒ���
            shield.eulerAngles = new Vector3(0, 0, 0); // ȸ�� �ʱ�ȭ
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            shield.position = new Vector3(-1.5f, 0, 0); // ����
            shield.eulerAngles = new Vector3(0, 0, 90); // 90�� ȸ��
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            shield.position = new Vector3(1.5f, 0, 0); // ������
            shield.eulerAngles = new Vector3(0, 0, 90); // 90�� ȸ��
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
