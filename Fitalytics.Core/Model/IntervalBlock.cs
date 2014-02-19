// 
// Copyright (C) 2103 Georgios Antikatzidis 
// 
//  All rights reserved
// 
// Module Fitalytics.Core 

using System;
using System.Dynamic;
using System.Runtime.Remoting.Metadata.W3cXsd2001;

namespace Fitalytics.Core.Model
{
    public enum RunOrWalk
    {   
        RUN,
        WALK
    }

    public class IntervalBlock
    {
        public RunOrWalk IntervalType { get; set; }
        public int DurationInMs { get; set; }
        public string Name { get; set; }


        public IntervalBlock(RunOrWalk type, int duration, string name)
        {
            this.DurationInMs = duration;
            this.IntervalType = type;
            this.Name = name;
        }


        public TimeSpan Duration
        {
            get { return TimeSpan.FromMilliseconds(DurationInMs); }
        }
    }


}