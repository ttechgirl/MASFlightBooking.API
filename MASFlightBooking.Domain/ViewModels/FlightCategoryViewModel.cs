﻿using MASFlightBooking.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MASFlightBooking.Domain.ViewModels
{
    public class FlightCategoryViewModel
    {
        public Status Status { get; set; }
        public FlightCategory FlightCategory { get; set; }

    }
}
