using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//этот скрипт для управления игроком / машинкой
public class PlayerController : MonoBehaviour
{
    // Задаем скорость движения игрока
    [SerializeField] private float speed = 20;
    // Задаем скорость вращения игрока
    [SerializeField] private float rotation = 10;
    [SerializeField] private float vInput;
    [SerializeField] private float hInput;

    // Start вызывается один раз при старте сцены или объекта
    void Start()
    {
        // Здесь можно инициализировать переменные, если нужно
    }

    // Update вызывается каждый кадр
    void Update()
    {
        // Получаем вертикальное движение (вперед/назад) от игрока
        vInput = Input.GetAxis("Vertical");

        // Двигаем игрока вперед или назад по оси Z
        // Time.deltaTime делает движение независимым от частоты кадров
        transform.Translate(Vector3.forward * Time.deltaTime * speed * vInput);

        // Получаем горизонтальное движение (влево/вправ) от игрока
        hInput = Input.GetAxis("Horizontal");

        // Вращаем игрока по оси Y в зависимости от горизонтального ввода
        // Вращение умножается на vInput, чтобы движение вперед/назад влияло на вращение
        transform.Rotate(Vector3.up * Time.deltaTime * rotation * hInput * vInput);
    }
}
