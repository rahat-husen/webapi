//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace event_api.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class EventInfo
    {
        public int EventId { get; set; }
        public string EventName { get; set; }
        public string EventTime { get; set; }
        public Nullable<System.DateTime> EventDate { get; set; }
        public string EventDesc { get; set; }
        public string EventAddress { get; set; }
        public string EventCity { get; set; }
        public string EventState { get; set; }
        public string EventImage { get; set; }
        public Nullable<int> UserId { get; set; }
        public Nullable<int> NoOfSeats { get; set; }
    
        public virtual UserInfo UserInfo { get; set; }
    }
}