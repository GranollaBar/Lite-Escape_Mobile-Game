using System.Diagnostics;
using System.Collections.Generic;
using UnityEngine;

public class Level16Text : MonoBehaviour
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

    private List<StoryTextItem> tutorialItems = new List<StoryTextItem>();

    private Stopwatch timer = new Stopwatch();

    public void Start()
    {
        StoryTextItem item = new StoryTextItem();
        item.textTransition = titleTransition;
        item.titleTime = 1f;
        item.transitionTime = 1f;
        item.titleText = titleText;
        tutorialItems.Add(item);

        item = new StoryTextItem();
        item.textTransition = text1Transition;
        item.titleTime = 3f;
        item.transitionTime = 1f;
        item.titleText = text1;
        tutorialItems.Add(item);

        item = new StoryTextItem();
        item.textTransition = text2Transition;
        item.titleTime = 5f;
        item.transitionTime = 1f;
        item.titleText = text2;
        tutorialItems.Add(item);

        item = new StoryTextItem();
        item.textTransition = text3Transition;
        item.titleTime = 7f;
        item.transitionTime = 1f;
        item.titleText = text3;
        tutorialItems.Add(item);

        item = new StoryTextItem();
        item.textTransition = text4Transition;
        item.titleTime = 9f;
        item.transitionTime = 1f;
        item.titleText = text4;
        tutorialItems.Add(item);

        item = new StoryTextItem();
        item.textTransition = text5Transition;
        item.titleTime = 11f;
        item.transitionTime = 1f;
        item.titleText = text5;
        tutorialItems.Add(item);

        item = new StoryTextItem();
        item.textTransition = text6Transition;
        item.titleTime = 13f;
        item.transitionTime = 1f;
        item.titleText = text6;
        tutorialItems.Add(item);

        item = new StoryTextItem();
        item.textTransition = text7Transition;
        item.titleTime = 15f;
        item.transitionTime = 1f;
        item.titleText = text7;
        tutorialItems.Add(item);

        item = new StoryTextItem();
        item.textTransition = text8Transition;
        item.titleTime = 17f;
        item.transitionTime = 1f;
        item.titleText = text8;
        tutorialItems.Add(item);

        item = new StoryTextItem();
        item.textTransition = text9Transition;
        item.titleTime = 19f;
        item.transitionTime = 1f;
        item.titleText = text9;
        tutorialItems.Add(item);

        item = new StoryTextItem();
        item.textTransition = text10Transition;
        item.titleTime = 21f;
        item.transitionTime = 1f;
        item.titleText = text10;
        tutorialItems.Add(item);

        item = new StoryTextItem();
        item.textTransition = text11Transition;
        item.titleTime = 23f;
        item.transitionTime = 1f;
        item.titleText = text11;
        tutorialItems.Add(item);

        item = new StoryTextItem();
        item.textTransition = text12Transition;
        item.titleTime = 25f;
        item.transitionTime = 1f;
        item.titleText = text12;
        tutorialItems.Add(item);

        item = new StoryTextItem();
        item.textTransition = text13Transition;
        item.titleTime = 27f;
        item.transitionTime = 1f;
        item.titleText = text13;
        tutorialItems.Add(item);

        DisableAllText();
        timer.Start();
    }

    public void Update()
    {
        foreach (StoryTextItem tutItem in tutorialItems)
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
        foreach (StoryTextItem tutItem in tutorialItems)
        {
            tutItem.titleText.SetActive(false);
        }
    }
}
