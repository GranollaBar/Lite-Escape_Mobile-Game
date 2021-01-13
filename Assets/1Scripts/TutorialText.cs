using UnityEngine;

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

    private float titleTime = 1f;
    private float text1Time = 3f;
    private float text2Time = 5f;
    private float text3Time = 7f;
    private float text4Time = 9f;
    private float text5Time = 11f;
    private float text6Time = 13f;
    private float text7Time = 15f;
    private float text8Time = 17f;
    private float text9Time = 19f;
    private float text10Time = 21f;
    private float text11Time = 23f;
    private float text12Time = 25f;

    private float transitionTime = 1f;

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

    private void Start()
    {
        titleText.SetActive(false);
        text1.SetActive(false);
        text2.SetActive(false);
        text3.SetActive(false);
        text4.SetActive(false);
        text5.SetActive(false);
        text6.SetActive(false);
        text7.SetActive(false);
        text8.SetActive(false);
        text9.SetActive(false);
        text10.SetActive(false);
        text11.SetActive(false);
        text12.SetActive(false);
    }

    public System.Collections.IEnumerator TitleFade()
    {
        titleTransition.SetTrigger("Title Start");
        yield return new WaitForSeconds(transitionTime);
    }
    public System.Collections.IEnumerator text1Fade()
    {
        text1Transition.SetTrigger("text1 Start");
        yield return new WaitForSeconds(transitionTime);
    }
    public System.Collections.IEnumerator text2Fade()
    {
        text2Transition.SetTrigger("text2 Start");
        yield return new WaitForSeconds(transitionTime);
    }
    public System.Collections.IEnumerator text3Fade()
    {
        text3Transition.SetTrigger("text3 Start");
        yield return new WaitForSeconds(transitionTime);
    }
    public System.Collections.IEnumerator text4Fade()
    {
        text4Transition.SetTrigger("text4 Start");
        yield return new WaitForSeconds(transitionTime);
    }
    public System.Collections.IEnumerator text5Fade()
    {
        text5Transition.SetTrigger("text5 Start");
        yield return new WaitForSeconds(transitionTime);
    }
    public System.Collections.IEnumerator text6Fade()
    {
        text6Transition.SetTrigger("text6 Start");
        yield return new WaitForSeconds(transitionTime);
    }
    public System.Collections.IEnumerator text7Fade()
    {
        text7Transition.SetTrigger("text7 Start");
        yield return new WaitForSeconds(transitionTime);
    }
    public System.Collections.IEnumerator text8Fade()
    {
        text8Transition.SetTrigger("text8 Start");
        yield return new WaitForSeconds(transitionTime);
    }
    public System.Collections.IEnumerator text9Fade()
    {
        text9Transition.SetTrigger("text9 Start");
        yield return new WaitForSeconds(transitionTime);
    }
    public System.Collections.IEnumerator text10Fade()
    {
        text10Transition.SetTrigger("text10 Start");
        yield return new WaitForSeconds(transitionTime);
    }
    public System.Collections.IEnumerator text11Fade()
    {
        text11Transition.SetTrigger("text11 Start");
        yield return new WaitForSeconds(transitionTime);
    }
    public System.Collections.IEnumerator text12Fade()
    {
        text12Transition.SetTrigger("text12 Start");
        yield return new WaitForSeconds(transitionTime);
    }


    public void Update()
    {
        if(Time.deltaTime >= 1)
        {
            titleText.SetActive(true);

            titleTime -= Time.deltaTime;
            if (titleTime <= 0)
            {
                StartCoroutine(TitleFade());
            }
        }

        if (Time.deltaTime >= 3)
        {
            text1.SetActive(true);

            text1Time -= Time.deltaTime;
            if (text1Time <= 0)
            {
                StartCoroutine(text1Fade());
            }
        }

        if (Time.deltaTime >= 5)
        {
            text2.SetActive(true);

            text2Time -= Time.deltaTime;
            if (text2Time <= 0)
            {
                StartCoroutine(text2Fade());
            }
        }

        if (Time.deltaTime >= 7)
        {
            text3.SetActive(true);

            text3Time -= Time.deltaTime;
            if (text3Time <= 0)
            {
                StartCoroutine(text3Fade());
            }
        }

        if (Time.deltaTime >= 9)
        {
            text4.SetActive(true);

            text4Time -= Time.deltaTime;
            if (text4Time <= 0)
            {
                StartCoroutine(text4Fade());
            }
        }

        if (Time.deltaTime >= 11)
        {
            text5.SetActive(true);

            text5Time -= Time.deltaTime;
            if (text5Time <= 0)
            {
                StartCoroutine(text5Fade());
            }
        }

        if (Time.deltaTime >= 13)
        {
            text6.SetActive(true);

            text6Time -= Time.deltaTime;
            if (text6Time <= 0)
            {
                StartCoroutine(text6Fade());
            }
        }

        if (Time.deltaTime >= 15)
        {
            text7.SetActive(true);

            text7Time -= Time.deltaTime;
            if (text7Time <= 0)
            {
                StartCoroutine(text7Fade());
            }
        }

        if (Time.deltaTime >= 17)
        {
            text8.SetActive(true);

            text8Time -= Time.deltaTime;
            if (text8Time <= 0)
            {
                StartCoroutine(text8Fade());
            }
        }

        if (Time.deltaTime >= 19)
        {
            text9.SetActive(true);

            text9Time -= Time.deltaTime;
            if (text9Time <= 0)
            {
                StartCoroutine(text9Fade());
            }
        }

        if (Time.deltaTime >= 21)
        {
            text10.SetActive(true);

            text10Time -= Time.deltaTime;
            if (text10Time <= 0)
            {
                StartCoroutine(text10Fade());
            }
        }

        if (Time.deltaTime >= 23)
        {
            text11.SetActive(true);

            text11Time -= Time.deltaTime;
            if (text11Time <= 0)
            {
                StartCoroutine(text11Fade());
            }
        }

        if (Time.deltaTime >= 25)
        {
            text12.SetActive(true);

            text12Time -= Time.deltaTime;
            if (text12Time <= 0)
            {
                StartCoroutine(text12Fade());
            }
        }
    }
}

