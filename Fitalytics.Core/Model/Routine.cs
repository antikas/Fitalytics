// 
// Copyright (C) 2103 Georgios Antikatzidis 
// 
//  All rights reserved
// 
// Module Fitalytics.Core 

using System.Collections.Concurrent;

namespace Fitalytics.Core.Model
{
    public class Routine
    {
        private IntervalBlock[] _intervalBlocks;
        private string _name;

        public Routine()
        {
            this._intervalBlocks = new IntervalBlock[] {new IntervalBlock(RunOrWalk.WALK, 5*60*1000, "Warmup")};
        }

        public IntervalBlock[] IntervalBlocks
        {
            get { return _intervalBlocks; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
    }
}