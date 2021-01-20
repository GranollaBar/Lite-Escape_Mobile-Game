﻿using UnityEngine;
using System.Collections.Generic;
using System.Diagnostics;

public class TutorialText : MonoBehaviour
{
    public Animator titleTransition;
    public Animator text1Transition;
    public Animator text2Transition;
    public Animator text3Transition;
    public Animator text4Transition;
    public Animator text5Transition;
    public Animator text6Transition;
    public Animator text7Transition;
    public Animator text8Transition;
    public Animator text9Transition;
    public Animator text10Transition;
    public Animator text11Transition;
    public Animator text12Transition;
    public Animator text13Transition;
    public Animator text14Transition;
    public Animator text15Transition;
    public Animator text16Transition;
    public Animator text17Transition;
    public Animator text18Transition;
    public Animator text19Transition;

    public GameObject titleText;
    public GameObject text1;
    public GameObject text2;
    public GameObject text3;
    public GameObject text4;
    public GameObject text5;
    public GameObject text6;
    public GameObject text7;
    public GameObject text8;
    public GameObject text9;
    public GameObject text10;
    public GameObject text11;
    public GameObject text12;
    public GameObject text13;
    public GameObject text14;
    public GameObject text15;
    public GameObject text16;
    public GameObject text17;
    public GameObject text18;
    public GameObject text19;

    private List<TutorialItem> tutorialItems = new List<TutorialItem>();

    private Stopwatch timer = new Stopwatch();

    public void Start()
    {
        TutorialItem item = new TutorialItem();
        item.textTransition = titleTransition;
        item.titleTime = 1f;
        item.transitionTime = 1f;
        item.titleText = titleText;
        tutorialItems.Add(item);

        item = new TutorialItem();
        item.textTransition = text1Transition;
        item.titleTime = 3f;
        item.transitionTime = 1f;
        item.titleText = text1;
        tutorialItems.Add(item);

        item = new TutorialItem();
        item.textTransition = text2Transition;
        item.titleTime = 5f;
        item.transitionTime = 1f;
        item.titleText = text2;
        tutorialItems.Add(item);

        item = new TutorialItem();
        item.textTransition = text3Transition;
        item.titleTime = 7f;
        item.transitionTime = 1f;
        item.titleText = text3;
        tutorialItems.Add(item);

        item = new TutorialItem();
        item.textTransition = text4Transition;
        item.titleTime = 9f;
        item.transitionTime = 1f;
        item.titleText = text4;
        tutorialItems.Add(item);

        item = new TutorialItem();
        item.textTransition = text5Transition;
        item.titleTime = 11f;
        item.transitionTime = 1f;
        item.titleText = text5;
        tutorialItems.Add(item);

        item = new TutorialItem();
        item.textTransition = text6Transition;
        item.titleTime = 13f;
        item.transitionTime = 1f;
        item.titleText = text6;
        tutorialItems.Add(item);

        item = new TutorialItem();
        item.textTransition = text7Transition;
        item.titleTime = 15f;
        item.transitionTime = 1f;
        item.titleText = text7;
        tutorialItems.Add(item);

        item = new TutorialItem();
        item.textTransition = text8Transition;
        item.titleTime = 17f;
        item.transitionTime = 1f;
        item.titleText = text8;
        tutorialItems.Add(item);

        item = new TutorialItem();
        item.textTransition = text9Transition;
        item.titleTime = 19f;
        item.transitionTime = 1f;
        item.titleText = text9;
        tutorialItems.Add(item);

        item = new TutorialItem();
        item.textTransition = text10Transition;
        item.titleTime = 21f;
        item.transitionTime = 1f;
        item.titleText = text10;
        tutorialItems.Add(item);

        item = new TutorialItem();
        item.textTransition = text11Transition;
        item.titleTime = 23f;
        item.transitionTime = 1f;
        item.titleText = text11;
        tutorialItems.Add(item);

        item = new TutorialItem();
        item.textTransition = text12Transition;
        item.titleTime = 25f;
        item.transitionTime = 1f;
        item.titleText = text12;
        tutorialItems.Add(item);

        item = new TutorialItem();
        item.textTransition = text13Transition;
        item.titleTime = 27f;
        item.transitionTime = 1f;
        item.titleText = text13;
        tutorialItems.Add(item);

        item = new TutorialItem();
        item.textTransition = text14Transition;
        item.titleTime = 29f;
        item.transitionTime = 1f;
        item.titleText = text14;
        tutorialItems.Add(item);

        item = new TutorialItem();
        item.textTransition = text15Transition;
        item.titleTime = 31f;
        item.transitionTime = 1f;
        item.titleText = text15;
        tutorialItems.Add(item);

        item = new TutorialItem();
        item.textTransition = text16Transition;
        item.titleTime = 33f;
        item.transitionTime = 1f;
        item.titleText = text16;
        tutorialItems.Add(item);

        item = new TutorialItem();
        item.textTransition = text17Transition;
        item.titleTime = 35f;
        item.transitionTime = 1f;
        item.titleText = text17;
        tutorialItems.Add(item);

        item = new TutorialItem();
        item.textTransition = text18Transition;
        item.titleTime = 37f;
        item.transitionTime = 1f;
        item.titleText = text18;
        tutorialItems.Add(item);

        item = new TutorialItem();
        item.textTransition = text19Transition;
        item.titleTime = 39f;
        item.transitionTime = 1f;
        item.titleText = text19;
        tutorialItems.Add(item);

        DisableAllText();
        timer.Start();
    }

    public void Update()
    {
        foreach (TutorialItem tutItem in tutorialItems)
        {
            if (tutItem.alreadyShown)
            {
                continue;
            }

            if (timer.ElapsedMilliseconds >= (tutItem.titleTime * 2000))
            {
                DisableAllText();
                tutItem.titleText.SetActive(true);
                tutItem.alreadyShown = true; 
            }
        }
    }

    private void DisableAllText()
    {
        foreach (TutorialItem tutItem in tutorialItems)
        {
            tutItem.titleText.SetActive(false);
        }
    }
}

