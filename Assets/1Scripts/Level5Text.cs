using System.Diagnostics;
using System.Collections.Generic;
using UnityEngine;

public class Level5Text : MonoBehaviour
{
    public Animator titleTransition;
    public Animator text1Transition;
    public Animator text2Transition;

    public GameObject titleText;
    public GameObject text1;
    public GameObject text2;

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

        if (PlayerPrefs.GetInt("keepUpdating") == 1)
        {
            if (PlayerPrefs.GetInt("keepCounting") == 0)
            {
                timer.Start();
                PlayerPrefs.SetInt("keepUpdating", 0);
            }

            if (PlayerPrefs.GetInt("keepCounting") == 1)
            {
                timer.Stop();
                PlayerPrefs.SetInt("keepUpdating", 0);
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
