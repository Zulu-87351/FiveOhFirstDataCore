﻿using FiveOhFirstDataCore.Core.Account;
using FiveOhFirstDataCore.Core.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiveOhFirstDataCore.Core.Structures.Updates
{
    public class SlotUpdate : UpdateBase
    {
        public Slot NewSlot { get; set; }
        public Team? NewTeam { get; set; }
        public Role? NewRole { get; set; }
        public Flight? NewFlight { get; set; }

        public Slot OldSlot { get; set; }
        public Team? OldTeam { get; set; }
        public Role? OldRole { get; set; }
        public Flight? OldFlight { get; set; }

        public List<Trooper> ApprovedBy { get; set; } = new();
    }
}
