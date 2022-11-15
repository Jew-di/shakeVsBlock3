using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Hvost2 : MonoBehaviour
{
    public List<Transform> Tails; // массив координат хвоста
    [Range(0, 3)]
    public float BonesDistance; // дистанция между элементами хвоста
    public GameObject BonePrefab; // префаб хвоста
    [Range(0, 4)]
    public float Speed;
    private Transform _transform;

    public UnityEvent OnEat;

    private void Start()
    {
        _transform = GetComponent<Transform>();
    }

    private void Update()
    {
        MoveSnake(_transform.position + _transform.forward * Speed);

        float angel = Input.GetAxis("Horizontal");
        _transform.Rotate(0, angel, 0);
    }

    private void MoveSnake(Vector3 newPosition)
    {
        float sqrDistance = BonesDistance * BonesDistance;
        Vector3 previusPosition = _transform.position;

        foreach (var bone in Tails)
        {
            if((bone.position - previusPosition).sqrMagnitude > sqrDistance)
            {
                var temp = bone.position;
                bone.position = previusPosition;
                previusPosition = temp;

            }
            else
            {
                break;
            }
        }

        _transform.position = newPosition; 
        
    }
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Food")
        {
            Destroy(collision.gameObject);

            var bone = Instantiate(BonePrefab);
            Tails.Add(bone.transform);
        }
    }
}
