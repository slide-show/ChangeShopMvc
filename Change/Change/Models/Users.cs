//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Change.Models
{
    using System;
    using System.Collections.Generic;
    //
    using System.ComponentModel.DataAnnotations;
    public partial class Users
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Users()
        {
            this.Appraise = new HashSet<Appraise>();
            this.Delivery = new HashSet<Delivery>();
            this.Favorite = new HashSet<Favorite>();
            this.Orders = new HashSet<Orders>();
        }
    
        public int UserId { get; set; }
        [Display(Name = "登录名")]
        [Required(ErrorMessage = "{0}是必填项")]
        public string UserName { get; set; }
        [Display(Name = "密码")]
        [Required(ErrorMessage = "{0}是必填项")]
        public string Pwd { get; set; }
        [Display(Name = "邮箱")]
        public string Email { get; set; }
        [Display(Name = "昵称")]
        public string Nick { get; set; }
        [Display(Name = "默认地址ID")]
        public Nullable<int> DeliveryID { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Appraise> Appraise { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Delivery> Delivery { get; set; }
        public virtual Delivery Delivery1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Favorite> Favorite { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Orders> Orders { get; set; }
    }
}