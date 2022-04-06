using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PracticeTest : MonoBehaviour
{
    public float sensitivity = 2.0f;
    public float speedV = 2.0f;

    float yaw = 0.0f;
    float pitch = 0.0f;

    int[] anArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        yaw += sensitivity * Input.GetAxis("Mouse X");
        pitch -= sensitivity * Input.GetAxis("Mouse Y");

        transform.eulerAngles = new Vector3(pitch, yaw, 0.0f);
        //Debug.Log(f(anArray));
    }

    int f(int[] a)
    {
        int xSumOfEven = 0;
        int ySumOfOdd = 0;
        for (int index = 0; index < a.Length; index++)
        {
            if(a[index] % 2 == 0)
            {
                xSumOfEven += a[index];
            }
            else
            {
                ySumOfOdd += a[index];
            }
        }
        return ySumOfOdd - xSumOfEven;
    }
}
