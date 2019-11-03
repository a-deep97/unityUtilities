using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class resolution : MonoBehaviour {

    private Vector2 deviceResolution;//new device resolution vector
    private Vector2 standardResolution;// standard resolution scale
    private Vector3 multiplier;//the final vector scale for resize
    // public reference to objects to me resized
    
    public GameObject object;//any gameobject to be resized or replaced a/c screen
    // Use this for initialization
	void Start ()
    {       
        standardResolution = new Vector2(800,480);
        deviceResolution = new Vector2(Screen.width, Screen.height);
        multiplier.Set((float)deviceResolution.x / (float)standardResolution.x, (float)deviceResolution.y / (float)standardResolution.y, 1);
        resize();
        reposition();
    }
    
    private void resize()
    {
       
        object.transform.localScale = scalingFunction(object.transform.localScale);
     }
    private void reposition()
    {
        object.GetComponent<RectTransform>().anchoredPosition = positionFunction(object.GetComponent<RectTransform>().anchoredPosition);
        
    }
    private Vector3 positionFunction(Vector3 pos)
    {
        return new Vector3(pos.x * multiplier.x, pos.y * multiplier.y, pos.z);
    }
    private Vector3 scalingFunction(Vector3 objectScale)
    {
        return new Vector3(objectScale.x * multiplier.x, objectScale.y * multiplier.y, objectScale.z);
    }

}
