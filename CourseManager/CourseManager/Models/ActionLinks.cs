//------------------------------------------------------------------------------
// <auto-generated>
//    此代码是根据模板生成的。
//
//    手动更改此文件可能会导致应用程序中发生异常行为。
//    如果重新生成代码，则将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace CourseManager.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    
    public partial class ActionLinks
    {
        [Key]
        [Required]
        public int id { get; set; }
        [StringLength(20)]
        [Display(Name = "名称")]
        public string Name { get; set; }
        [StringLength(20)]
        [Display(Name = "控制器")]
        public string Controller { get; set; }
        [StringLength(20)]
        [Display(Name = "动作")]
        public string Action { get; set; }
        [Display(Name = "序号")]
        public Nullable<int> order { get; set; }
    }
}
