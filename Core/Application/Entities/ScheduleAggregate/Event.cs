﻿using System;
using UrbanEngine.Core.Application.SharedKernel;

namespace UrbanEngine.Core.Application.Entities.ScheduleAggregate
{
    public class Event : Entity<long>
    {
        #region Properties 

        public string Title { get; private set; }
        public string Description { get; private set; }
        public DateTime? StartDate { get; private set; }
        public DateTime? EndDate { get; private set; }
        public EventType EventType { get; private set; }
        public string OrganizerId { get; private set; } 
        public long? VenueId { get; private set; }

        #endregion

        #region Navigation Properties

        public EventVenue Venue { get; private set; }

        #endregion

        #region Constructors

        protected Event()
        {

        }

        public Event(string title, string description, EventType eventType, DateTime? startDate, DateTime? endDate, string organizerId, long? venueId)
        {
            Title = title;
            Description = description;
            StartDate = startDate;
            EndDate = endDate;
            EventType = eventType;
            OrganizerId = organizerId;
            VenueId = venueId;
        }

        #endregion
    }
}