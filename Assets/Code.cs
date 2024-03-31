using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Code : MonoBehaviour
{
    private void Awake()
    {
        Queue queue = new Queue();
        for(int i = 0; i < 5; ++ i)
        {
            queue.Enqueue(i);
        }
        Debug.Log($"Queue Count : {queue.Count}");
		Debug.Log($"���� 0�� ��� : {queue.Peek()}");
        object data = queue.Dequeue();
		Debug.Log($"ť���� �������� ������ : {data}");
		Debug.Log($"Queue Count : {queue.Count}");
        queue.Clear();
		Debug.Log($"Queue Count : {queue.Count}");
	}
}
