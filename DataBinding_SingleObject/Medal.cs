using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBinding_SingleObject
{
    public enum MedalColor { Gold, Silver, Bronze }
    public class Medal
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected void Notify(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
        private MedalColor color;
        private string athlete;
        private bool isRecord;
        private string theEvent;
        private int year;

        public MedalColor Color
        {
            get { return color; }
            set
            {
                if (color != value)
                {
                    color = value;
                    Notify("Color");
                }
            }
        }
        public string Athlete
        {
            get { return athlete; }
            set
            {
                if (athlete != value)
                {
                    athlete = value;
                    Notify("Athlete");
                }
            }
        }
        public bool IsRecord
        {
            get { return isRecord; }
            set
            {
                if (isRecord != value)
                {
                    isRecord = value;
                    Notify("IsRecord");
                }
            }
        }
        public int Year
        {
            get { return year; }
            set
            {
                if (year != value)
                {
                    year = value;
                    Notify("Year");
                }
            }
        }
        public string TheEvent
        {
            get { return theEvent; }
            set
            {
                if (theEvent != value)
                {
                    theEvent = value;
                    Notify("TheEvent");
                }
            }
        }
        public override string ToString() => $"{Year} - {TheEvent} {(IsRecord ? "(R) " : "")}{Athlete} ({Color})";
    }
}
