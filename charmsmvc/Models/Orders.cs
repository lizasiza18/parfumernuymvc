//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace charmsmvc.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Orders
    {
        public int Id { get; set; }
        public string фамилия { get; set; }
        public string имя { get; set; }
        public string отчество_ { get; set; }
        public string паспорт { get; set; }
        public string телефон { get; set; }
        public string адрес { get; set; }
        public string товары { get; set; }
        public string сумма { get; set; }
        public Nullable<System.DateTime> дата_заказа { get; set; }
    }
}
