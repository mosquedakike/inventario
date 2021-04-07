﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities
{
    class WherehouseEntity
    {
        [Key]
        [StringLength(50)]
        public string WherehouseId { get; set; }

        [Required]
        [StringLength(100)]
        public string WharehouseName { get; set; }

        [Required]
        [StringLength(100)]
        public string WherehouseAddress { get; set; }

        //Relacion con almacenamient (StorageEntity)
        public ICollection<StorageEntity> Storages { get; set; }
    }
}
