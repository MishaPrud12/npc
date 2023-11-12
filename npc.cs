using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class npc : MonoBehaviour
{
    // Количество жизней NPC
    public int health = 5;
    // Уровень NPC
    public int level = 1;
    // Скорость NPC
    public float speed = 1.2f;

    void Start()
    {
        // Прибавляет к количеству жизней NPC уровень
        health += level;
        // Выводит в консоль количество жизней
        print(health);
    }

    void Update()
    {
        // Эта команда создает переменную newPosition и присваевает ей значение позиции NPC
        Vector3 newPosition = transform.position;
        // Эта команда прибавляет к позиции скорость умноженую на deltaTime
        newPosition.z += speed * Time.deltaTime;
        // Эта команда присваевает позиции обновленное значение
        transform.position = newPosition;
    }
}
