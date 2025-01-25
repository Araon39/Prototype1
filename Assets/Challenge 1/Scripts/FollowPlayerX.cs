using UnityEngine;

public class FollowPlayerX : MonoBehaviour
{
    // Ссылка на объект 'plane', за которым будет следить камера.
    [SerializeField] private GameObject plane;

    // Оффсет, который определяет, на каком расстоянии камера будет от объекта.
    [SerializeField] private Vector3 offset;

    // Метод, который вызывается каждый кадр.
    void Update()
    {
        // Код ниже делает следующее:
        // Камера будет следовать за объектом 'plane', поддерживая заданный оффсет.
        // Можно использовать комментарированный код для более сложного поведения камеры (с вращением).

        /*
        Vector3 rotOffset = plane.transform.rotation * offset; // Применяем вращение объекта 'plane' к оффсету
        transform.position = plane.transform.position + rotOffset; // Камера будет двигаться с учётом вращения
        transform.rotation = plane.transform.rotation; // Камера будет следовать за вращением объекта 'plane'
        */

        // Камера просто следует за объектом с заданным оффсетом без учёта вращения.
        transform.position = plane.transform.position + offset;
    }
}
