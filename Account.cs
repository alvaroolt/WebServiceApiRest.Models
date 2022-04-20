using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebServiceApiRest.Models
{
    public class Account
    {
        [Key]
        public int id { get; set; }
        public int money { get; set; }
        public int user_id { get; set; }

        public Account() { }

        public Account(int id, int money, int user_id)
        {
            this.id = id;
            this.money = money;
            this.user_id = user_id;
        }

        public Account(int money, int user_id)
        {
            this.money = money;
            this.user_id = user_id;
        }
    }
}
