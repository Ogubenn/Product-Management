using System;
using İnterfaceExample.AbsstruckModel;

namespace İnterfaceExample.Models
{
        public class User:CommonProp
    { 

        public int Id { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public bool IsStatus { get; set; }
    }
}

