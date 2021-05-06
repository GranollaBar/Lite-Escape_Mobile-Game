using System.Diagnostics;
using UnityEngine;

public class LightsFlash25 : MonoBehaviour
{
    public GameObject light1;
    public GameObject light2;
    public GameObject light3;
    public GameObject light4;
    public GameObject light5;
    public GameObject light6;
    public GameObject light7;
    public GameObject light8;
    public GameObject light9;
    public GameObject light10;
    public GameObject light11;
    public GameObject light12;
    public GameObject light13;
    public GameObject light14;
    public GameObject light15;
    public GameObject light16;
    public GameObject light17;
    public GameObject light18;
    public GameObject light19;
    public GameObject light20;
    public GameObject light21;
    public GameObject light22;
    public GameObject light23;
    public GameObject light24;
    public GameObject light25;
    public GameObject light26;
    public GameObject light27;
    public GameObject light28;
    public GameObject light29;
    public GameObject light30;

    private Stopwatch timer = new Stopwatch();

    private void Start()
    {
        light1.SetActive(false);
        light2.SetActive(false);
        light3.SetActive(false);
        light4.SetActive(false);
        light5.SetActive(false);
        light6.SetActive(false);
        light7.SetActive(false);
        light8.SetActive(false);
        light9.SetActive(false);
        light10.SetActive(false);
        light11.SetActive(false);
        light12.SetActive(false);
        light13.SetActive(false);
        light14.SetActive(false);
        light15.SetActive(false);
        light16.SetActive(false);
        light17.SetActive(false);
        light18.SetActive(false);
        light19.SetActive(false);
        light20.SetActive(false);
        light21.SetActive(false);
        light22.SetActive(false);
        light23.SetActive(false);
        light24.SetActive(false);
        light25.SetActive(false);
        light26.SetActive(false);
        light27.SetActive(false);
        light28.SetActive(false);
        light29.SetActive(false);
        light30.SetActive(false);

        timer.Start();
    }

    public void Update()
    {
        Countdown();
    }

    public void Countdown()
    {
        if (timer.ElapsedMilliseconds >= 1500)
        {
            light1.SetActive(true);
            light2.SetActive(true);
            light3.SetActive(true);
            light4.SetActive(true);
            light5.SetActive(true);
            light6.SetActive(true);
            light7.SetActive(true);
            light8.SetActive(true);
            light9.SetActive(true);
            light10.SetActive(true);
            light11.SetActive(true);
            light12.SetActive(true);
            light13.SetActive(true);
            light14.SetActive(true);
            light15.SetActive(true);
            light16.SetActive(true);
            light17.SetActive(true);
            light18.SetActive(true);
            light19.SetActive(true);
            light20.SetActive(true);
            light21.SetActive(true);
            light22.SetActive(true);
            light23.SetActive(true);
            light24.SetActive(true);
            light25.SetActive(true);
            light26.SetActive(true);
            light27.SetActive(true);
            light28.SetActive(true);
            light29.SetActive(true);
            light30.SetActive(true);
        }

        if (timer.ElapsedMilliseconds >= 3500)
        {
            light1.SetActive(false);
            light2.SetActive(false);
            light3.SetActive(false);
            light4.SetActive(false);
            light5.SetActive(false);
            light6.SetActive(false);
            light7.SetActive(false);
            light8.SetActive(false);
            light9.SetActive(false);
            light10.SetActive(false);
            light11.SetActive(false);
            light12.SetActive(false);
            light13.SetActive(false);
            light14.SetActive(false);
            light15.SetActive(false);
            light16.SetActive(false);
            light17.SetActive(false);
            light18.SetActive(false);
            light19.SetActive(false);
            light20.SetActive(false);
            light21.SetActive(false);
            light22.SetActive(false);
            light23.SetActive(false);
            light24.SetActive(false);
            light25.SetActive(false);
            light26.SetActive(false);
            light27.SetActive(false);
            light28.SetActive(false);
            light29.SetActive(false);
            light30.SetActive(false);

            timer.Restart();
        }
    }
}
