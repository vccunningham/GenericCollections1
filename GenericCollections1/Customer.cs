﻿using System;
using System.Collections.Generic;
using System.Text;

namespace GenericCollections1 {
    class Customer {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool Active { get; set; }

        public Customer(int Id, string Name, bool Active) {
            this.Id = Id;
            this.Name = Name;
            this.Active = Active;
        }

            public Customer() { }


            // this' means a property or method in a class. verifying a property name in a class
            
        }
    }


