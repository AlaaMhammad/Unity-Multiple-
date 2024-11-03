using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultiplicationTable : MonoBehaviour
{
    // دالة ضرب تأخذ عددين وترجع ناتج ضربهما
    int Multiply(int a, int b)
    {
        return a * b;
    }

    // Start is called before the first frame update
    void Start()
    {
        // إنشاء حلقة من 1 إلى 10 لعرض جدول الضرب للعدد 5
        for (int i = 1; i <= 10; i++)
        {
            // استدعاء دالة Multiply للحصول على الناتج
            int result = Multiply(5, i);
            // طباعة الناتج في وحدة التحكم
            Debug.Log("5 x " + i + " = " + result);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}