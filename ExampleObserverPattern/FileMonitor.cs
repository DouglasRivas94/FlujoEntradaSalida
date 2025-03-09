using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleObserverPattern
{
    public class FileMonitor
    {
        private readonly List<IFileObserver> _observers = new List<IFileObserver>();

        public void Subscribe(IFileObserver observer)
        {
            _observers.Add(observer);
        }
        public void UnSubscribe(IFileObserver observer)
        {
            _observers.Remove(observer);
        }
        public void FileChanged(string filePath)
        {
            foreach (IFileObserver observer in _observers)
            {
                observer.Notify($"El archivo {filePath} ha sido modificado.");
            }
        }
    }
}
