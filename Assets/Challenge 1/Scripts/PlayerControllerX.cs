using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    [SerializeField] private float speed; // скорость движения игрока
    [SerializeField] private float rotationSpeed; // скорость вращения игрока

    // Start is called before the first frame update
    void Start()
    {
        // Этот метод вызывается один раз при старте игры.
        // Здесь можно инициализировать переменные или настройки.
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // Получаем вертикальный и горизонтальный ввод от пользователя
        // Это значения от -1 до 1 (например, для стрелок клавиатуры или джойстика)
        float verticalInput = Input.GetAxis("Vertical"); // Вверх/вниз (W/S или стрелки вверх/вниз)
        float horizontalInput = Input.GetAxis("Horizontal"); // Влево/вправ (A/D или стрелки влево/вправ)

        // Двигаем самолет вперед на постоянной скорости
        // Vector3.forward — это вектор (0, 0, 1), указывающий в направлении оси Z
        // Мы умножаем на скорость и Time.deltaTime для независимости от частоты кадров
        transform.Translate(Vector3.forward * speed * Time.deltaTime);

        // Вращаем самолет вверх/вниз в зависимости от вертикального ввода
        // Используем ось X для наклона, вращаем по осям по вертикали
        transform.Rotate(Vector3.right * rotationSpeed * Time.deltaTime * verticalInput);

        // Вращаем самолет влево/вправ в зависимости от горизонтального ввода
        // Используем ось Z для наклона влево/вправ
        // Умножаем на -1, чтобы изменить направление вращения
        transform.Rotate(Vector3.forward * rotationSpeed * Time.deltaTime * horizontalInput * -1);
    }
}
