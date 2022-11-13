using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hvost : MonoBehaviour
{
    public Transform SnakeHead; //ссылка на голову
    public GameObject hvost; //префаб хвоста
    public float CircleDiameter; //диаметр хвоста

    private List<Transform> snakeCircles = new List<Transform>(); //массив в котором будут лежать все эдлементы хвоста
    private List<Vector3> positions = new List<Vector3>(); // массив координат всех элементов хвоста. ƒолжен быть всегда на 1 единицу больше



    void Start()
    {
        positions.Add(SnakeHead.position); // задаЄм позицию головы в начале
        AddCircle(); // добавл€ем стартовое количество эллементов хвоста
        AddCircle();
        AddCircle();
    }

    
    void Update()
    {
        float distance = ((Vector3)SnakeHead.position - positions[0]).magnitude; //получаем расто€ние между текущим и последнем положением головы

        if (distance > CircleDiameter) // провер€ем отошла ли голова от хвоста бер€ диаметр
        {
            positions.Insert(0, SnakeHead.position); //нова€ позици€ головы
            positions.RemoveAt(positions.Count - 1); // удалили последний элимент, сдвинув тем самым змейку

            distance -= CircleDiameter; //избавл€емс€ от рывка

            for(int i = 0; i < snakeCircles.Count; i++)
            {
                snakeCircles[i].position = Vector3.Lerp(positions[i + 1], positions[i], distance / CircleDiameter);
            }
        }
    }

    public void AddCircle() // функци€ добавлени€ тела змеи
    {
        Transform circle = Instantiate(SnakeHead, positions[positions.Count - 1], Quaternion.identity, transform); // ƒобавление минус -1 к позиции последнего хвоста и заводим всЄ в переменную
        snakeCircles.Add(circle); // добавл€ем в массив всех элементов хвоста
        positions.Add(circle.position); // добавл€ем в массив позицию этого элемента хвоста
    }
}
