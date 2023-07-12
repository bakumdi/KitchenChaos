using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using UnityEngine;

public class KitchenObject : MonoBehaviour
{
    [SerializeField] KitchenOnjectSO kitchenObjectSO;
    [SerializeField] ClearCounter clearCounter;

    public KitchenOnjectSO GetKitchenObjectSO() 
    {
        return  kitchenObjectSO; 
    }
    
    public void SetClearCounter(ClearCounter clearCounter)
    {
        if (this.clearCounter != null) 
        {
            this.clearCounter.ClearKitchenObject();
        }
        this.clearCounter = clearCounter;
        if (clearCounter.HasKitchenObject())
        {
            Debug.LogError("Counter already has a kitchenObject");
        }
        clearCounter.SetKitchenObject(this);
        transform.parent = clearCounter.GetKitchenObjectFollowTransform();
        transform.localPosition = Vector3.zero;
    }
    public ClearCounter GetClearCounter() 
    {
        return this.clearCounter; 
    }
}
