﻿using System.Collections.Generic;
using System.Threading.Tasks;
using UrbanEngine.Core.Application.Entities.ScheduleAggregate;
using UrbanEngine.Core.Application.Interfaces.Persistence.Data;
using UrbanEngine.Core.Common.Results;

namespace UrbanEngine.Core.Application.Schedules
{
    public class ScheduleService : IScheduleService
    {
        #region Local Fields

        private readonly IEventRepository _eventRepository; 

        #endregion

        #region Constructors

        public ScheduleService(IEventRepository eventRepository)
        {
            _eventRepository = eventRepository;
        }

        #endregion

        #region Implementation of IScheduleService

        public async Task<ScheduleResult<Event>> ScheduleEventAsync(Event eventDetail)
        {
            var scheduledEvent = await _eventRepository.CreateAsync(eventDetail);

            ScheduleResult<Event> scheduleResult = scheduledEvent?.Id > 0 ?
                new ScheduleResult<Event>(scheduledEvent, "event created", true) :
                new ScheduleResult<Event>(null, "failed to create event", false);

            return scheduleResult;
        }

        public Task<bool> DeleteEventAsync(long eventId, string reason)
        {
            throw new System.NotImplementedException();
        }

        public async Task<Event> GetEventDetail(long eventId)
        {
            var eventDetail = await _eventRepository.GetByIdAsync(eventId);
            return eventDetail;
        }
        
        public Task<IEnumerable<ScheduleResult<Event>>> ListScheduledEventsAsync(ScheduleFilter filter)
        {
            throw new System.NotImplementedException();
        }

        public Task<IEnumerable<ScheduleResult<EventSession>>> ListEventSessionsAsync(long eventId)
        {
            throw new System.NotImplementedException();
        }

        public Task<ScheduleResult<EventSession>> ScheduleEventSessionAsync(long eventId, EventSession sessionDetail)
        {
            throw new System.NotImplementedException();
        }

        public Task<bool> DeleteSessionAsync(long eventId, long sessionId, string reason)
        {
            throw new System.NotImplementedException();
        }

        Task<bool> IScheduleService.DeleteEventAsync(long eventId, string reason)
        {
            throw new System.NotImplementedException();
        }

        Task<bool> IScheduleService.DeleteEventSessionAsync(long eventId, long sessionId, string reason)
        {
            throw new System.NotImplementedException();
        }

        #endregion
    }
}
