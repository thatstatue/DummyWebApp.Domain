﻿using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DummyWebApp.Domain.Entities
{
    public class Amenity
    {


        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        //[DisplayName ("Villa Number")]
        public int Id { get; set; }
        
        public required string Name { get; set; }
        public string? Description { get; set; }

        [DisplayName("Villa Name")]
        [ForeignKey(nameof(Villa))]
        public int VillaId { get; set; }
        [ValidateNever]
        public Villa Villa { get; set; }
        
    }
}
