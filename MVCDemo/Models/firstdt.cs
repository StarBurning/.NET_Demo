//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace MVCDemo.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class firstdt
    {
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        public Nullable<int> Age { get; set; }
        public Nullable<System.DateTime> Add_Date { get; set; }
    }
}
