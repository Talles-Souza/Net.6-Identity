using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entities
{
    [Table("TB_MESSAGE")]
    public class Message : Notifies
    {
        [Column("MSN_ID")]
        public int Id { get; set; }
        [Column("MSN_TITLE")]
        [MaxLength(255)]
        public string Title { get; set; }
        [Column("MSN_ACTIVE")]
        public bool Active { get; set; }
        [Column("MSN_DATE_REGISTER")]
        public DateTime DateRegister { get; set; }
        [Column("MSN_CHANGE_DATE")]
        public DateTime ChangeDate { get; set; }

    }
}
