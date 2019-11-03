using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class resolution : MonoBehaviour {

    private Vector2 deviceResolution;//new device resolution vector
    private Vector2 standardResolution;// standard resolution scale
    private Vector3 multiplier;//the final vector scale for resize
    // public reference to objects to me resized
    //texts
    public GameObject menuTitle, statHighScore, statDistance, statNumber, gameTitle, score, highScore, gameOver,cup,nautilus,version;
    //buttons
    public GameObject pause, mute;
    //panels
    public GameObject mainMenuPanel,statsPanel,aboutPanel,gameover,menuBackground,level;
    //others
    public GameObject menuScreen,background,fish;
    public 
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
        //texts
        menuTitle.transform.localScale = scalingFunction(menuTitle.transform.localScale);
        gameTitle.transform.localScale = scalingFunction(gameTitle.transform.localScale);
        score.transform.localScale = scalingFunction(score.transform.localScale);
        highScore.transform.localScale = scalingFunction(highScore.transform.localScale);
        cup.transform.localScale = scalingFunction(cup.transform.localScale);
        nautilus.transform.localScale = scalingFunction(nautilus.transform.localScale);
        version.transform.localScale = scalingFunction(version.transform.localScale);
        level.transform.localScale = scalingFunction(level.transform.localScale);
        //buttons
        pause.transform.localScale = scalingFunction(pause.transform.localScale);
        mute.transform.localScale = scalingFunction(mute.transform.localScale);
        //panels
        mainMenuPanel.transform.localScale = scalingFunction(mainMenuPanel.transform.localScale);
        statsPanel.transform.localScale = transform.localScale = scalingFunction(statsPanel.transform.localScale);
        aboutPanel.transform.localScale = transform.localScale = scalingFunction(aboutPanel.transform.localScale);
        gameover.transform.localScale = transform.localScale = scalingFunction(gameover.transform.localScale);
        menuBackground.transform.localScale = transform.localScale = scalingFunction(menuBackground.transform.localScale);
        //others
        fish.transform.localScale = scalingFunction(fish.transform.localScale);
    }
    private void reposition()
    {
        //menuScreen
        menuScreen.transform.position = new Vector3(0,-5,0);
        //texts
        menuTitle.GetComponent<RectTransform>().anchoredPosition = positionFunction(menuTitle.GetComponent<RectTransform>().anchoredPosition);
        gameTitle.GetComponent<RectTransform>().anchoredPosition = positionFunction(gameTitle.GetComponent<RectTransform>().anchoredPosition);
        score.GetComponent<RectTransform>().anchoredPosition = positionFunction(score.GetComponent<RectTransform>().anchoredPosition);
        highScore.GetComponent<RectTransform>().anchoredPosition = positionFunction(highScore.GetComponent<RectTransform>().anchoredPosition);
        cup.GetComponent<RectTransform>().anchoredPosition = positionFunction(cup.GetComponent<RectTransform>().anchoredPosition);
        nautilus.GetComponent<RectTransform>().anchoredPosition = positionFunction(nautilus.GetComponent<RectTransform>().anchoredPosition);
        version.GetComponent<RectTransform>().anchoredPosition = positionFunction(version.GetComponent<RectTransform>().anchoredPosition);
        level.GetComponent<RectTransform>().anchoredPosition = positionFunction(level.GetComponent<RectTransform>().anchoredPosition);
        //buttons
        pause.GetComponent<RectTransform>().anchoredPosition = positionFunction(pause.GetComponent<RectTransform>().anchoredPosition);
        mute.GetComponent<RectTransform>().anchoredPosition = positionFunction(mute.GetComponent<RectTransform>().anchoredPosition);
        //panels
        mainMenuPanel.GetComponent<RectTransform>().anchoredPosition = positionFunction(mainMenuPanel.GetComponent<RectTransform>().anchoredPosition);
        statsPanel.GetComponent<RectTransform>().anchoredPosition = positionFunction(statsPanel.GetComponent<RectTransform>().anchoredPosition);
        aboutPanel.GetComponent<RectTransform>().anchoredPosition = positionFunction(aboutPanel.GetComponent<RectTransform>().anchoredPosition);
        gameover.GetComponent<RectTransform>().anchoredPosition = positionFunction(gameover.GetComponent<RectTransform>().anchoredPosition);
        menuBackground.GetComponent<RectTransform>().anchoredPosition = positionFunction(menuBackground.GetComponent<RectTransform>().anchoredPosition);
        //others
        fish.GetComponent<RectTransform>().anchoredPosition = positionFunction(fish.GetComponent<RectTransform>().anchoredPosition);

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
