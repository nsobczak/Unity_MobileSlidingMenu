using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class AddObject : MonoBehaviour
{
    #region Parameters
    [SerializeField] private String tagClickable = "ClickableObject";
    [SerializeField] private GameObject[] prefabObjModels;
    [SerializeField] private Toggle[] toggle;

    private GameObject obj;
    #endregion


    //____________________________________________________________________

    #region Buttons_functions

    public void AddObjectButtonClicked()
    {
        //trouver l'index du toggle actif
        int objectModelIndex = 0;
        //while (!toggle[objectModelIndex].isOn && objectModelIndex < toggle.Length)
        //    objectModelIndex++;

        //faire un switch sur l'index+1
        obj = prefabObjModels[objectModelIndex];
        Debug.Log("obj: " + obj);

        if (null != obj)
        {
            Vector3 newPosition = new Vector3(0, 0, 0);
            Quaternion newRotation = Quaternion.Euler(0, 0, 0);
            GameObject currentObj = Instantiate(obj, newPosition, newRotation);
            currentObj.tag = tagClickable;
            //ObjControl.objList.Add(obj);
        }
        else
            Debug.Log("obj is null");
    }
    #endregion
}
