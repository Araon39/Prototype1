using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//этот скрипт нужен для камеры что бы та летала за машинкой
public class FollowPlayer : MonoBehaviour
{
    // Переменная для хранения ссылки на объект игрока
    [SerializeField] private GameObject player;

    // Смещение относительно позиции игрока (например, для камеры)
    [SerializeField] private Vector3 offset = new Vector3();

    // Start вызывается перед первым обновлением кадра
    void Start()
    {
        // Здесь можно инициализировать что-то, если нужно
    }

    // Update вызывается каждый кадр
    void Update()
    {
        // Проверяем, существует ли объект игрока
        if (player != null)
        {
            // Устанавливаем позицию текущего объекта в позицию игрока с добавленным смещением
            transform.position = player.transform.position + offset;
        }
    }
}
