namespace Events
{
    using System;
    using Wintellect.PowerCollections;

    public class EventHolder
    {
        private readonly MultiDictionary<string, Event> byTitle = new MultiDictionary<string, Event>(true);
        private readonly OrderedBag<Event> byDate = new OrderedBag<Event>();

        public void AddEvent(DateTime date, string title, string location)
        {
            Event newEvent = new Event(date, title, location);
            this.byTitle.Add(title.ToLower(), newEvent);
            this.byDate.Add(newEvent);
            Messages.EventAdded();
        }

        // Deletes all events with a given title, performs a case insensitive search
        public void DeleteEvents(string titleToDelete)
        {
            string title = titleToDelete.ToLower();
            int removed = 0;
            foreach (var eventToRemove in this.byTitle[title])
            {
                removed++;
                this.byDate.Remove(eventToRemove);
            }

            this.byTitle.Remove(title);
            Messages.EventDeleted(removed);
        }

        public void ListEvents(DateTime date, int count)
        {
            OrderedBag<Event>.View eventsToShow = this.byDate.RangeFrom(new Event(date, string.Empty, string.Empty), true);
            int shown = 0;
            foreach (var eventToShow in eventsToShow)
            {
                if (shown == count)
                {
                    break;
                }

                Messages.PrintEvent(eventToShow);

                shown++;
            }

            if (shown == 0)
            {
                Messages.NoEventsFound();
            }
        }
    }
}
