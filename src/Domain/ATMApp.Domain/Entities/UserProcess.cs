using ATMApp.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMApp.Domain.Entities
{
    public class UserProcess : IBaseEntity
    {
        public int Id { get; set; }
        public int TransactionNumber { get; set; }
        public decimal Amount { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? DeleteDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public Status Status { get; set; }
        public Process Process { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
    }
}
