using UnityEngine;
using System.Collections.Generic;
using System.Diagnostics;

public class Level6Text : MonoBehaviour
{
    public Animator titleTransition;
    public Animator text1Transition;
    public Animator text2Transition;
    public Animator text3Transition;
    public Animator text4Transition;
    public Animator text5Transition;
    public Animator text6Transition;
    public Animator text7Transition;

    public GameObject titleText;
    public GameObject text1;
    public GameObject text2;
    public GameObject text3;
    public GameObject text4;
    public GameObject text5;
    public GameObject text6;
    public GameObject text7;

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

