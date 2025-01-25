using UnityEngine;

public class PropellorController : MonoBehaviour
{
    // Сериализуемое поле для задания скорости вращения
    [SerializeField] private float rotationSpeed;

    // Метод Update вызывается каждый кадр
    void Update()
    {
        // Вращаем объект вокруг оси Z (Vector3.forward) с учетом скорости вращения и времени между кадрами (Time.deltaTime)
        transform.Rotate(Vector3.forward * rotationSpeed * Time.deltaTime);
    }
}