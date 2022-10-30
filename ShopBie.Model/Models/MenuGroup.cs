using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopBie.Model.Models
    {
        [Table("MenuGroups")]
        public class MenuGroup
        {
            [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { set; get; }

            [Required]
            [MaxLength(50)]
            public string Name { set; get; }

            //IEnumerable --> connection kiểu Menu
            // Menu truy vấn sang MenuGroup.Menus) --> lấy đc các danh sách các Menus thuộc group này
            public virtual IEnumerable<Menu> Menus { set; get; }
        }
 }
