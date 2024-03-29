﻿using System.Diagnostics;
using UnityEngine;

public class LightsFlash10 : MonoBehaviour
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

            timer.Restart();
        }
    }
}
