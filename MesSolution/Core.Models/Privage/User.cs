﻿using Component.Tools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    
    public class User:Entity
    {
        [Key,MaxLength(40)]
        
        public string usercode { get; set; }
        [Required,MaxLength(200)]
        public string userpwd { get; set; }
        [MaxLength(40)]
        public string username { get; set; }
        [MaxLength(40)]
        public string usertel { get; set; }
        [MaxLength(100)]
        public string useremail { get; set; }
        [MaxLength(40)]
        public string userdepart { get; set; }
        [Required,MaxLength(40)]
        public string muser { get; set; }
        [Required]
        public System.DateTime mdate { get; set; }
        [MaxLength(40)]
        public string eattribute1 { get; set; }
        [MaxLength(40)]
        public string userstat { get; set; }

        public UserStatus userStatus { get; set; }
        public virtual ICollection<UserGroup> UserGroups { get; set; }

        public enum UserStatus
        {
            ADD = 1,
            U = 2
        }
    }
}
