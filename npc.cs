using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class npc : MonoBehaviour
{
    // ���������� ������ NPC
    public int health = 5;
    // ������� NPC
    public int level = 1;
    // �������� NPC
    public float speed = 1.2f;

    void Start()
    {
        // ���������� � ���������� ������ NPC �������
        health += level;
        // ������� � ������� ���������� ������
        print(health);
    }

    void Update()
    {
        // ��� ������� ������� ���������� newPosition � ����������� �� �������� ������� NPC
        Vector3 newPosition = transform.position;
        // ��� ������� ���������� � ������� �������� ��������� �� deltaTime
        newPosition.z += speed * Time.deltaTime;
        // ��� ������� ����������� ������� ����������� ��������
        transform.position = newPosition;
    }
}
