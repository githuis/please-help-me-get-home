using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerManager : MonoBehaviour
{
    public Image textBg;
    public Text txt;

    public Image dashImg;

    public bool isDead;

    private Movement _movement;

    private Jukebox jq;
    private CanvasStore cs;

    private void Awake()
    {
        _movement = GetComponent<Movement>();
    }

    void Start()
    {
        //ShowText("Move with Left stick/WASD. Dash with A/X/Spacebar. Hide by standing still. Take down enemies after hiding or dashing with B/O/E.");
        jq = FindObjectOfType<Jukebox>();
        cs = GameObject.FindGameObjectWithTag("Canvas").GetComponent<CanvasStore>();
        textBg = cs.textBg;
        txt = cs.txt;
        dashImg = cs.dashImg;
        HideText();

    }

    void Update()
    {

    }

    public void ShowText(string text)
    {
        textBg.enabled = true;
        txt.enabled = true;
        txt.text = text;
    }

    public void HideText()
    {
        textBg.enabled = false;
        txt.enabled = false;
    }

    public void KillPlayer()
    {
        jq.PlayDie();
        isDead = true;
        ShowText("you got Spooked!. Press Start/Escape to play again.");
    }
}
