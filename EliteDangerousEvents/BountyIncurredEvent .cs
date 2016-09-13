﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EliteDangerousEvents
{
    public class BountyIncurredEvent : Event
    {
        public const string NAME = "Bounty incurred";
        public static BountyIncurredEvent SAMPLE = new BountyIncurredEvent(DateTime.Now, "kill", "The Pilot's Federation", "Braben", 1000000M);

        [JsonProperty("crimetype")]
        public string crimetype { get; private set; }

        [JsonProperty("victim")]
        public string victim { get; private set; }

        [JsonProperty("faction")]
        public string faction { get; private set; }

        [JsonProperty("bounty")]
        public decimal bounty { get; private set; }

        public BountyIncurredEvent(DateTime timestamp, string crimetype, string faction, string victim, decimal bounty) : base(timestamp, NAME)
        {
            this.crimetype = crimetype;
            this.faction = faction;
            this.victim = victim;
            this.bounty = bounty;
        }
    }
}
