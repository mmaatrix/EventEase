using System.Collections.Generic;
using System.Linq;
using EventEase.Models;

namespace EventEase.Services
{
    public class SessionState
    {
        private readonly List<RegistrationModel> _registrations = new();
        private readonly List<EventModel> _events = new();

        public IReadOnlyList<EventModel> Events => _events;
        public IReadOnlyList<RegistrationModel> Registrations => _registrations;

        public void SeedEvents(IEnumerable<EventModel> items)
        {
            _events.Clear();
            _events.AddRange(items);
        }

        public void AddEvent(EventModel item)
        {
            _events.Add(item);
        }

        public void AddRegistration(RegistrationModel model)
        {
            var existing = _registrations.FirstOrDefault(r => r.Email == model.Email && r.EventTitle == model.EventTitle);
            if (existing == null)
            {
                _registrations.Add(model);
            }
        }

        public void ToggleAttendance(RegistrationModel model)
        {
            var existing = _registrations.FirstOrDefault(r => r.Email == model.Email && r.EventTitle == model.EventTitle);
            if (existing != null)
            {
                existing.IsPresent = !existing.IsPresent;
            }
        }

        public int PresentCount => _registrations.Count(r => r.IsPresent);
        public int AbsentCount => _registrations.Count(r => !r.IsPresent);
    }
}
