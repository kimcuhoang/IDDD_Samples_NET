﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using SaaSOvation.Common.Domain;
using SaaSOvation.Collaboration.Domain.Tenants;
using SaaSOvation.Collaboration.Domain.Collaborators;

namespace SaaSOvation.Collaboration.Domain.Calendars
{
    public class CalendarEntryParticipantInvited : IDomainEvent
    {
        public CalendarEntryParticipantInvited(
            Tenant tenant,
            CalendarId calendarId,
            CalendarEntryId calendarEntryId,
            Participant participant)
        {
            this.Tenant = tenant;
            this.CalendarId = calendarId;
            this.CalendarEntryId = calendarEntryId;
            this.Participant = participant;
        }

        public Tenant Tenant { get; private set; }
        public CalendarId CalendarId { get; private set; }
        public CalendarEntryId CalendarEntryId { get; private set; }
        public Participant Participant { get; private set; }

        public int EventVersion { get; set; }
        public DateTime OccurredOn { get; set; }
    }
}