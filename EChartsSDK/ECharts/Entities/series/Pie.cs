﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECharts.Entities.series
{
    public class Pie : ChartSeries<Pie>
    {
        public IList<string> center { get; set; }

        public object radius { get; set; }

        public int? startAngle { get; set; }

        public int? minAngle { get; set; }

        public bool? clockWise { get; set; }

        public NigRoseType? roseType { get; set; }

        public int? selectedOffset { get; set; }

        public SelectedModeType? selectedMode { get; set; }

        public bool? legendHoverLink { get; set; }

        public Pie LegendHoverLink(bool legendHoverLink)
        {
            this.legendHoverLink = legendHoverLink;
            return this;
        }

        public Pie SelectedMode(SelectedModeType selectedMode)
        {
            this.selectedMode = selectedMode;
            return this;
        }
    
        public Pie SelectedOffset(int selectedOffset)
        {
            this.selectedOffset = selectedOffset;
            return this;
        }

        public Pie RoseType(NigRoseType roseType)
        {
            this.roseType = roseType;
            return this;
        }

        public Pie ClockWise(bool clockWise)
        {
            this.clockWise = clockWise;
            return this;
        }

        public Pie MinAngle(int minAngle)
        {
            this.minAngle = minAngle;
            return this;
        }

        public Pie StartAngle(int startAngle)
        {
            this.startAngle = startAngle;
            return this;
        }

        public Pie Radius(string radius)
        {
            this.radius = radius;
            return this;
        }

        public Pie Center(IList<string> center)
        {
            this.center = center;
            return this;
        }

        public Pie() {
            this.type = ChartType.pie;
        }

        public Pie(string name):this() {
            this.name = name;
        }

    }
}
