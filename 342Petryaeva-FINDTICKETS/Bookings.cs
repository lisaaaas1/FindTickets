//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace _342Petryaeva_FINDTICKETS
{
    using System;
    using System.Collections.Generic;
    
    public partial class Bookings
    {
        public int id { get; set; }
        public Nullable<int> ID_User { get; set; }
        public Nullable<int> ID_Ticket_Type { get; set; }
        public Nullable<int> ID_Flight { get; set; }
    
        public virtual Flight Flight { get; set; }
        public virtual Ticket_Type Ticket_Type { get; set; }
        public virtual Users Users { get; set; }
    }
}
