﻿using System.Collections.Generic;

namespace Donuts.Models
{
    internal class Setting<T>
    {
        public string Name
        {
            get; set;
        }
        public string TooltipText
        {
            get; set;
        }
        public T Value
        {
            get; set;
        }
        public T DefaultValue
        {
            get; set;
        }
        public T MinValue
        {
            get; set;
        }
        public T MaxValue
        {
            get; set;
        }
        public List<T> Options
        {
            get; set;
        }

        public Setting(string name, string tooltipText, T value, T defaultValue, T minValue = default(T), T maxValue = default(T), List<T> options = null)
        {
            Name = name;
            TooltipText = tooltipText;
            Value = value;
            DefaultValue = defaultValue;
            MinValue = minValue;
            MaxValue = maxValue;
            Options = options ?? new List<T>();
        }
    }
}