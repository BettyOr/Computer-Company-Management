﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CCM.Domain.Abstract;

namespace CCM.Domain.Entities.Components
{
    /// <summary>
    /// Modela el disco duro de la PC
    /// </summary>
    public class HardDrive : IBrand
    {
        #region Properties
        /// <summary>
        /// Modelo del disco duro
        /// </summary>
        public string Model;
        /// <summary>
        /// Capacidad de almacenamiento del disco duro
        /// </summary>
        public float Storage { get; set; }
        /// <summary>
        /// Marca del disco duro
        /// </summary>
        public string Brand { get; }
        #endregion

       public HardDrive(string model, string brand, float storage) 
        { 
            Model = model; 
            Brand = brand; 
            Storage = storage; }
    }
 }
