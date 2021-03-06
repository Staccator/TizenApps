﻿using System;

namespace Pedometer.Services
{
    /// <summary>
    /// Represents arguments of event triggered when pedometer changes data
    /// </summary>
    public class PedometerUpdatedEventArgs : EventArgs
    {
        /// <summary>
        /// Calories burned
        /// </summary>
        public int Calories { get; private set; }

        /// <summary>
        /// Steps made
        /// </summary>
        public int Steps { get; private set; }

        /// <summary>
        /// Average speed
        /// </summary>
        public int SpeedAverage { get; private set; }

        /// <summary>
        /// Distance covered
        /// </summary>
        public int Distance { get; private set; }

        /// <summary>
        /// Initalizes PedometerUpdatedEventArgs class instance
        /// </summary>
        /// <param name="calories">Calories burned</param>
        /// <param name="steps">Steps made</param>
        /// <param name="speedAverage">Average speed</param>
        /// <param name="distance">Distance covered</param>
        public PedometerUpdatedEventArgs(int calories, int steps, int speedAverage, int distance)
        {
            Calories = calories;
            Steps = steps;
            SpeedAverage = speedAverage;
            Distance = distance;
        }
    }
}