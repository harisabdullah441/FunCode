using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class If_Else_Checker : MonoBehaviour
{
    private static If_Else_Checker instance;
    public List<string> ifItems;
    public List<string> elseItems;
    private List<int> orderRemoveLocation = new List<int>();
    bool ifItemPresent;
    bool elseItemPresent;

    private void Awake()
    {
        instance = this;
    }

    public static If_Else_Checker GetInstance()
    {
        return instance;
    }


    public void IfCheck()
    {
        for(int i = 0; i<ifItems.Count; i++)
        {
            ifItemPresent = false;
            for (int j = 0; j < Order_Checker.GetInstance().currentOrder.Count; j++)
            {
                if (ifItems[i] == Order_Checker.GetInstance().currentOrder[j])
                {
                    // The item on IF is present in order
                   
                    ifItemPresent = true;
                    //  Order_Checker.GetInstance().currentOrder.RemoveAt(j);
                    orderRemoveLocation.Add(j);
                    break;
                }
                
            }
            if (!ifItemPresent)
            {
                Order_Checker.GetInstance().OrderNotCompleted();
                return;
            }
        }
        if(ifItemPresent)
        {
            for(int i=0;i<orderRemoveLocation.Count;i++)
            {
                int placeToRemove = orderRemoveLocation[i];
                Debug.Log(placeToRemove);
              Order_Checker.GetInstance().currentOrder.RemoveAt(placeToRemove);
            }
            orderRemoveLocation.Clear();

        }
        if (ifItemPresent && Order_Checker.GetInstance().currentOrder.Count==0)
        {
            Order_Checker.GetInstance().OrderCompleted();
        }

    }
    public void ElseCheck()
    {
        for (int i = 0; i < elseItems.Count; i++)
        {
            elseItemPresent = false;
            for (int j = 0; j < Order_Checker.GetInstance().currentOrder.Count; j++)
            {
                if (elseItems[i] == Order_Checker.GetInstance().currentOrder[j])
                {
                    // The item on IF is present in order

                    elseItemPresent = true;
                    orderRemoveLocation.Add(j);
                    break;
                }

            }
            if (!elseItemPresent)
            {
                Order_Checker.GetInstance().OrderNotCompleted();
                return;
            }

        }

        if (elseItemPresent)
        {
            for (int i = 0; i < orderRemoveLocation.Count; i++)
            {
                int placeToRemove = orderRemoveLocation[i];
                Debug.Log(placeToRemove);
                Order_Checker.GetInstance().currentOrder.RemoveAt(placeToRemove);
            }
            orderRemoveLocation.Clear();
        }


        if (elseItemPresent && Order_Checker.GetInstance().currentOrder.Count == 0)
        {
            Order_Checker.GetInstance().OrderCompleted();
        }

    }

}
