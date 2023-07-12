using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEngine;

public class ClearCounter : MonoBehaviour
{


    [SerializeField] private KitchenOnjectSO kitchenObjectSO;
    [SerializeField] private Transform counterTopPoint;
    [SerializeField] KitchenObject kitchenObject;
    [SerializeField] ClearCounter secoundClearCounter;
    [SerializeField] bool testing;

    private void Update()
    {
        if (testing && Input.GetKeyDown(KeyCode.T))
        {
            if (kitchenObject!=null)
            {
                kitchenObject.SetClearCounter(secoundClearCounter);
                
            }
        }
    }

    public void Interact()
    {
        if (kitchenObject==null)
        {
            Transform kitchenObjectTransform = Instantiate(kitchenObjectSO.prefab, counterTopPoint);
            
            
            kitchenObjectTransform.GetComponent<KitchenObject>().SetClearCounter(this);
            kitchenObject.SetClearCounter(this);
        }
        else
        {
            Debug.Log(kitchenObject.GetClearCounter());
        }
    }
    public Transform GetKitchenObjectFollowTransform()
    {
        return counterTopPoint;
    }
    public void SetKitchenObject(KitchenObject kitchenObject)
    {
        this.kitchenObject = kitchenObject;
    }
    public KitchenObject GetKitchenObject()
    {
        return kitchenObject;
    }
    public void ClearKitchenObject()
    {
        kitchenObject=null;
    }
    public bool HasKitchenObject()
    {
        return kitchenObject!=null;
    }
}
