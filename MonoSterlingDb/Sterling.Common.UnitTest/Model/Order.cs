using System;
using System.ComponentModel;
#if __ANDROID__
using Android.Runtime;
#else
using MonoTouch.Foundation;
#endif
namespace Sterling.Common.UnitTest
{
    [Preserve(AllMembers = true)]
    public class Order:INotifyPropertyChanged
    {

        private Guid id;
        private string description;
        private DateTime timeStamp;

        public Guid Id
        {
            get
            {
                return id;
            }
            set
            {
                id = value;NotifyPropertyChanged("Id");
            }
        }

        public string Description
        {
            get
            {
                return description;
            }
            set
            {
                description = value;NotifyPropertyChanged("Description");
            }
        }

        public DateTime TimeStamp
        {
            get
            {
                return timeStamp;
            }
            set
            {
                timeStamp = value; NotifyPropertyChanged("TimeStamp");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged(String propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (null != handler)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
}
