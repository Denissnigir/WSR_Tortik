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
    
    public partial class SpecificationSemiProduct
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int SemiProductId { get; set; }
        public int Amount { get; set; }
    
        public virtual Product Product { get; set; }
        public virtual Product Product1 { get; set; }
    }
}
