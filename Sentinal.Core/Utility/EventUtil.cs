using CloudNative.CloudEvents;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace Sentinal.Core.Utility
{
    public class EventUtil
    {

        #region Public Methods

        public static async Task<CloudEvent> Pack<T>([Required] T evt, Uri source, CloudEventType type, string? subject)
        {
            return await Task.Run(() =>
            {
                var eventSubject = subject ?? $"{evt?.GetType()?.BaseType?.Name} submitted: {evt?.GetType().Name}";
                return new CloudEvent()
                {
                    Data = evt,
                    Id = Guid.NewGuid().ToString(),
                    Time = DateTime.Now,
                    Subject = eventSubject,
                    Type = type.ToString(),
                };
            });
        }

        public static async Task<T> Unpack<T>([Required] CloudEvent cloudEvent)
        {
            return await Task.Run(() =>
            {
                return JsonConvert.DeserializeObject<T>(cloudEvent?.Data?.ToString());
            });
        }

        #endregion

    }

    public enum CloudEventType
    {
        DomainEvent,
        DomainEventHandler,
        DomainException,
    }

}
