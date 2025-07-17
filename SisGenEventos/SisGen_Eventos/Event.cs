using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SisGen_Eventos
{
    public class Event
    {
        public string Organizer {  get; private set; }
        public string EventName { get; private set; }
        public string EventPlace { get; private set; }
        public DateTime StartOfTheEvent { get; private set; }
        public DateTime? EndOfEvent { get; private set; }
        public bool EventStatus { get; private set; }

        public Event() { }

        public Event(string organizer, string eventName, string eventPlace, DateTime start)
        {
            Organizer = organizer;
            EventName = eventName;
            EventPlace = eventPlace;
            StartOfTheEvent = start;
            EventStatus = true;
        }

        public Event(string organizer, string eventName, string eventPlace, DateTime start, DateTime? end) : this(organizer, eventName, eventPlace, start)
        {
            EndOfEvent = end;
        }

        public void ChangeStatus()
        {
            EventStatus = false;
        }

        public void UpadateOrganizer(string name)
        {
            Organizer = name;
        }

        public void UpdateEventName(string nameOfEvent)
        {
            EventName = nameOfEvent;
        }

        public void UpdatePlace(string nameOfPlace)
        {
            EventPlace = nameOfPlace;
        }

        public void UpdateStartDate(DateTime start)
        {
            StartOfTheEvent = start;
        }

        public void UpdateEndDate(DateTime end)
        {
            EndOfEvent = end;
        }

        public override string ToString()
        {
            string duration = (EventStatus) ? "YES" : "NOT";
            return $"_Name of event organizer: {Organizer}\n" +
                   $"_Event name: {EventName}\n" +
                   $"_Event Place: {EventPlace}\n" +
                   $"_Start: {StartOfTheEvent}\n" +
                   $"_End: {EndOfEvent}\n" +
                   $"_In duration? {duration}";
        }
    }
}
