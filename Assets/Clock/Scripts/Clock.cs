using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clock : MonoBehaviour
{

    public ClockIndicator hours, minutes, seconds;
    public bool continuous;

    /// <summary>
    /// Awake is called when the script instance is being loaded.
    /// </summary>
    void Awake()
    {
        UpdateBars();
    }

    /// <summary>
    /// Update is called every frame, if the MonoBehaviour is enabled.
    /// </summary>
    void Update()
    {
        UpdateBars();
    }

    void UpdateBars()
    {
        if (continuous)
        {
            UpdateBarsContinuous();
        }
        else
        {
            UpdateBarsDiscrete();
        }
    }

    void UpdateBarsDiscrete()
    {
        DateTime currentTime = DateTime.Now;
        hours.UpdateRotation(currentTime.Hour);
        minutes.UpdateRotation(currentTime.Minute);
        seconds.UpdateRotation(currentTime.Second);
    }

    void UpdateBarsContinuous()
    {
        TimeSpan currentTime = DateTime.Now.TimeOfDay;
        hours.UpdateRotation((float)currentTime.TotalHours);
        minutes.UpdateRotation((float)currentTime.TotalMinutes);
        seconds.UpdateRotation((float)currentTime.TotalSeconds);
    }
}