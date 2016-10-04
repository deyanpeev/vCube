﻿namespace  SocialUnion.Web.Models.Drivers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Linq.Expressions;

    using SocialUnion.Models;
    using SocialUnion.Web.Models.Trips;

    public class DriverWithTripsViewModel
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public int NumberOfUpcomingTrips { get; set; }

        public int NumberOfTotalTrips { get; set; }

        public IEnumerable<TripInfoViewModel> Trips { get; set; }
    }
}