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
    
    public partial class SpecificationIngridient
    {
        public int id { get; set; }
        public int ProductId { get; set; }
        public int IngridientId { get; set; }
        public string Amount { get; set; }
    
        public virtual Ingridient Ingridient { get; set; }
        public virtual Product Product { get; set; }
    }
}
