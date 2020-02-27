using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClockIndicator : MonoBehaviour
{
    public enum TimeComponentType
    {
        hours,
        minutes,
        seconds
    }

    public TimeComponentType type;

    private const float degreesPerHour = 30f;
    private const float degreesPerMinute = 6f;
    private const float degreesPerSecond = 6f;

    public void UpdateRotation(float timeComponent)
    {
        float rotation = 0;
        switch (this.type)
        {
            case TimeComponentType.hours:
                rotation = Degree(timeComponent);
                break;
            case TimeComponentType.minutes:
                rotation = Degree(timeComponent);
                break;
            case TimeComponentType.seconds:
                rotation = Degree(timeComponent);
                break;
        }
        this.transform.localRotation = Quaternion.Euler(0f, rotation, 0f);
    }
    private float Degree(float timeComponent)
    {
        float degreesPerComponent = 0f;
        switch (this.type)
        {
            case TimeComponentType.hours:
                degreesPerComponent = degreesPerHour;
                break;
            case TimeComponentType.minutes:
                degreesPerComponent = degreesPerMinute;
                break;
            case TimeComponentType.seconds:
                degreesPerComponent = degreesPerSecond;
                break;
        }
        return timeComponent * degreesPerComponent;
    }
}