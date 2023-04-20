using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Order_Checker : MonoBehaviour
{
    private static Order_Checker instance;
    public List<string> currentOrder;

    private void Awake()
    {
        instance = this;
    }

    public static Order_Checker GetInstance()
    {
        return instance;
    }

    private void Update()
    {
        if (currentOrder.Count == 0)
        {
        }
    }

    public void OrderCompleted()
    {
        Debug.Log("Order Completed!!!");

    }
    public void OrderNotCompleted()
    {
        Debug.Log("Order Not Completed!!!");

    }
}
