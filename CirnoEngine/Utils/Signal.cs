using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace CirnoEngine.Utils
{
    class Signal<I>
    {
        public List<Action<I>> listeners;

        public Signal()
        {
            listeners = new List<Action<I>>();
        }

        public void Dispatch(I thing)
        {
            foreach (Action<I> action in listeners)
            {
                action.Invoke(thing);
            }
        }

        public Action<I> this[int key]
        {
            get => listeners[key];
            set => listeners[key] = value;
        }
        public Action<I> Add(Action<I> action)
        {
            listeners.Add(action);
            return action;
        }

        public Action<I> Remove(Action<I> action)
        {
            listeners.Remove(action);
            return action;
        }

        public void Clear()
        {
            foreach (Action<I> action in listeners)
            {
                listeners.Remove(action);
            }
        }
    }
}
