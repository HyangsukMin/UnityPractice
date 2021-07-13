using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int age;
        age = 30;
        Debug.Log(age);
        
        float height1 = 160.5f;
        float height2;
        height2 = height1;
        Debug.Log(height2);
        
        string name;
        name = "Sera";
        Debug.Log(name);

        int answer;
        answer = 1 + 2;
        Debug.Log(answer);
        
        answer = 3 - 4;
        Debug.Log(answer);

        answer = 5 * 6;
        Debug.Log(answer);
        
        answer = 8 / 4;
        Debug.Log(answer);

        int n1 = 8;
        int n2 = 16;
        answer = n1 + n2;
        Debug.Log(answer);

        answer ++;
        Debug.Log(answer);

        string str1 = "Happy";
        string str2 = "Birthday";

        str1 += str2;
        Debug.Log(str1);

        string str = "happy";
        int num = 123;
        str += num;
        Debug.Log(str);
        }

    // Update is called once per frame
    void Update()
    {
        
    }
}
