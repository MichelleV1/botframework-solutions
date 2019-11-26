// <auto-generated>
// Code generated by LUISGen
// Tool github: https://github.com/microsoft/botbuilder-tools
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>
using Newtonsoft.Json;
using System.Collections.Generic;
using Microsoft.Bot.Builder;
using Microsoft.Bot.Builder.AI.Luis;
namespace Luis
{
    public partial class CalendarLuis: IRecognizerConvert
    {
        public string Text;
        public string AlteredText;
        public enum Intent {
            AcceptEventEntry, 
            CancelCalendar, 
            ChangeCalendarEntry, 
            CheckAvailability, 
            ConnectToMeeting, 
            ContactMeetingAttendees, 
            CreateCalendarEntry, 
            DeleteCalendarEntry, 
            FindCalendarDetail, 
            FindCalendarEntry, 
            FindCalendarWhen, 
            FindCalendarWhere, 
            FindCalendarWho, 
            FindDuration, 
            FindMeetingRoom, 
            None, 
            RejectCalendar, 
            ShowNextCalendar, 
            ShowPreviousCalendar, 
            TimeRemaining
        };
        public Dictionary<Intent, IntentScore> Intents;

        public class _Entities
        {
            // Simple entities
            public string[] Subject;
            public string[] FromDate;
            public string[] FromTime;
            public string[] ToTime;
            public string[] MeetingRoom;
            public string[] Location;
            public string[] MoveEarlierTimeSpan;
            public string[] MoveLaterTimeSpan;
            public string[] ToDate;
            public string[] SlotAttribute;
            public string[] OrderReference;
            public string[] PositionReference;
            public string[] Message;
            public string[] Duration;
            public string[] DestinationCalendar;

            // Built-in entities
            public DateTimeSpec[] datetime;
            public string[] personName;
            public double[] ordinal;

            // Lists
            public string[][] PossessivePronoun;
            public string[][] RelationshipName;

            // Instance
            public class _Instance
            {
                public InstanceData[] Subject;
                public InstanceData[] FromDate;
                public InstanceData[] FromTime;
                public InstanceData[] ToTime;
                public InstanceData[] MeetingRoom;
                public InstanceData[] Location;
                public InstanceData[] MoveEarlierTimeSpan;
                public InstanceData[] MoveLaterTimeSpan;
                public InstanceData[] ToDate;
                public InstanceData[] SlotAttribute;
                public InstanceData[] OrderReference;
                public InstanceData[] PositionReference;
                public InstanceData[] Message;
                public InstanceData[] Duration;
                public InstanceData[] DestinationCalendar;
                public InstanceData[] datetime;
                public InstanceData[] personName;
                public InstanceData[] ordinal;
                public InstanceData[] PossessivePronoun;
                public InstanceData[] RelationshipName;
            }
            [JsonProperty("$instance")]
            public _Instance _instance;
        }
        public _Entities Entities;

        [JsonExtensionData(ReadData = true, WriteData = true)]
        public IDictionary<string, object> Properties {get; set; }

        public void Convert(dynamic result)
        {
            var app = JsonConvert.DeserializeObject<CalendarLuis>(JsonConvert.SerializeObject(result, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore }));
            Text = app.Text;
            AlteredText = app.AlteredText;
            Intents = app.Intents;
            Entities = app.Entities;
            Properties = app.Properties;
        }

        public (Intent intent, double score) TopIntent()
        {
            Intent maxIntent = Intent.None;
            var max = 0.0;
            foreach (var entry in Intents)
            {
                if (entry.Value.Score > max)
                {
                    maxIntent = entry.Key;
                    max = entry.Value.Score.Value;
                }
            }
            return (maxIntent, max);
        }
    }
}
