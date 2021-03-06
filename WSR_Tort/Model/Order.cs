//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WSR_Tort.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Order
    {
        public int Id { get; set; }
        public System.DateTime Date { get; set; }
        public string Name { get; set; }
        public Nullable<int> ProductId { get; set; }
        public Nullable<int> BuyerId { get; set; }
        public Nullable<int> ManagerId { get; set; }
        public Nullable<decimal> Price { get; set; }
        public Nullable<System.DateTime> DateOfEnd { get; set; }
        public byte[] Image { get; set; }
    
        public virtual Product Product { get; set; }
        public virtual Role Role { get; set; }
        public virtual Role Role1 { get; set; }
    }
}
