using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hvost : MonoBehaviour
{
    public Transform SnakeHead; //������ �� ������
    public GameObject hvost; //������ ������
    public float CircleDiameter; //������� ������

    private List<Transform> snakeCircles = new List<Transform>(); //������ � ������� ����� ������ ��� ��������� ������
    private List<Vector3> positions = new List<Vector3>(); // ������ ��������� ���� ��������� ������. ������ ���� ������ �� 1 ������� ������



    void Start()
    {
        positions.Add(SnakeHead.position); // ����� ������� ������ � ������
        AddCircle(); // ��������� ��������� ���������� ���������� ������
        AddCircle();
        AddCircle();
    }

    
    void Update()
    {
        float distance = ((Vector3)SnakeHead.position - positions[0]).magnitude; //�������� ��������� ����� ������� � ��������� ���������� ������

        if (distance > CircleDiameter) // ��������� ������ �� ������ �� ������ ���� �������
        {
            positions.Insert(0, SnakeHead.position); //����� ������� ������
            positions.RemoveAt(positions.Count - 1); // ������� ��������� �������, ������� ��� ����� ������

            distance -= CircleDiameter; //����������� �� �����

            for(int i = 0; i < snakeCircles.Count; i++)
            {
                snakeCircles[i].position = Vector3.Lerp(positions[i + 1], positions[i], distance / CircleDiameter);
            }
        }
    }

    public void AddCircle() // ������� ���������� ���� ����
    {
        Transform circle = Instantiate(SnakeHead, positions[positions.Count - 1], Quaternion.identity, transform); // ���������� ����� -1 � ������� ���������� ������ � ������� �� � ����������
        snakeCircles.Add(circle); // ��������� � ������ ���� ��������� ������
        positions.Add(circle.position); // ��������� � ������ ������� ����� �������� ������
    }
}
