using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using MelderErfassung.DomainModel.Events;

namespace MelderErfassung.DomainModel
{
    public class EventHub
    {
        private List<object> _eventHandlers = new List<object>();

        public void RegisterEventHandler<TEvent>(IEventHandler<TEvent> handler)
        {
            _eventHandlers.Add(handler);
        }

        public void Publish(IEvent eventToHandle)
        {
            var handlers = _eventHandlers
                .Where(handler => handler
                                      .GetType()
                                      .GetTypeInfo().ImplementedInterfaces
                                      .First()
                                      .GenericTypeArguments
                                      .FirstOrDefault() == eventToHandle.GetType());

            foreach (var eventHandler in handlers)
            {
                dynamic d = eventHandler;
                d.Handle((dynamic) eventToHandle);
            }
        }
    }
}