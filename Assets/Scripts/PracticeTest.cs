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
            if (a[index] % 2 == 0)
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

    int[] array = new int[] { 2, 3, 5, 7, 11 };                     //1
    int[] array1 = new int[] { 2, 3, 6, 7, 11 };                    //0
    int[] array2 = new int[] { 2, 3, 4, 5, 6, 7, 8, 9, 10 };        //0
    int[] array3 = new int[] { 2, 4, 8, 16, 32 };                   //1
    int[] array4 = new int[] { 3, 9, 27, 7, 1, 1, 1, 1, 1 };        //1
    int[] array5 = new int[] { 7, 11, 77, 49 };                     //1
    int[] array6 = new int[] { 2 };                                 //1
    int[] array7 = new int[] { };                                   //1
    int[] array8 = new int[] { 7, 2, 7, 2, 7, 2, 7, 2, 3, 7, 7 };   //1



    public void callFunc()
    {
        Debug.Log(is235Array(array8));

    }

    public int is235Array(int[] a)
    {
        int isDivivdedByTwo = 0;
        int isDivivdedByThree = 0;
        int isDivivdedByFive = 0;

        int unableToDivide = 0;

        for (int i = 0; i < a.Length; i++)
        {
            if (a[i] % 2 == 0 || a[i] % 3 == 0 || a[i] % 5 == 0)
            {
                if (a[i] % 2 == 0)
                {
                    isDivivdedByTwo++;
                }
                    
                if (a[i] % 3 == 0)
                {
                    isDivivdedByThree++;
                }
                    
                if (a[i] % 5 == 0)
                {
                    isDivivdedByFive++;
                }    
            }
            else
            {
                unableToDivide++;
            }
        }

        if (isDivivdedByTwo + isDivivdedByThree + isDivivdedByFive + unableToDivide == a.Length)
            return 1;
        return 0;
    }
}
