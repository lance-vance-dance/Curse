//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Curse
{
    using System;
    using System.Collections.Generic;
    
    public partial class Orders
    {
        public int Id { get; set; }
        public Nullable<int> KlientID { get; set; }
        public Nullable<int> TourID { get; set; }
        public Nullable<int> HotelID { get; set; }
        public string Status { get; set; }
    
        public virtual Hotel Hotel { get; set; }
        public virtual Klients Klients { get; set; }
        public virtual Tour Tour { get; set; }
    }
}
