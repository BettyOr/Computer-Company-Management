﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CCM.Domain.Abstract;
using CCM.Domain.Entities.Common;
using CCM.Domain.Entities.Types;

namespace CCM.Domain.Entities.Components
{
    /// <summary>
    /// Modela el disco duro de la PC
    /// </summary>
    public class HardDrive : Entity, IBrand
    {
        #region Properties
        /// <summary>
        /// Modelo del disco duro
        /// </summary>
        public string Model { get; }
        /// <summary>
        /// Capacidad de almacenamiento del disco duro
        /// </summary>
        public float Storage { get; } 
        /// <summary>
        /// Tipo de conexión del disco duro
        /// </summary>
        public ConnectionHardDriveType ConnectionHardDriveType { get; }
        /// <summary>
        /// Marca del disco duro
        /// </summary>
        public string Brand { get; }
        
        #endregion

        #region Constructors
        /// <summary>
        /// Requerido por EntityFrameworkCore para migraciones.
        /// </summary>
        protected HardDrive() { }

        /// <summary>
        /// Inicializa un objeto <see cref="HardDrive"/>.
        /// </summary>
        /// <param name="model"></param>
        /// <param name="brand"></param>
        /// <param name="storage"></param>
        /// <param name="connectionHardDriveType"></param>
        public HardDrive(string model, string brand, float storage, ConnectionHardDriveType connectionHardDriveType ) 
        { 
            Model = model; 
            Brand = brand; 
            Storage = storage;
            ConnectionHardDriveType = connectionHardDriveType;
        }
        #endregion
    }
}
