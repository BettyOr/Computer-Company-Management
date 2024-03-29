﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CCM.Domain.Entities.Common;
using CCM.Domain.Entities.Components;

namespace CCM.Domain.Entities.Computers
{
    /// <summary>
    /// Modela una computadora
    /// </summary>
    public class PC : Entity
    {
        #region Properties
        /// <summary>
        /// Modela el disco duro de la PC
        /// </summary>
        [NotMapped]
        public HardDrive HardDrive { get; set; }
        /// <summary>
        /// Modela la motherboard de la PC
        /// </summary>
        [NotMapped]
        public MotherBoard MotherBoard { get; set; }
        /// <summary>
        /// Modela el microprocesador de la PC
        /// </summary>
        [NotMapped]
        public Microprocesor Microprocesors { get; set; }
        /// <summary>
        /// Modela la memoria RAM de la PC
        /// </summary>
        [NotMapped]
        public RAM RAM { get; set; }

        /// <summary>
        /// Id del disco duro
        /// </summary>
        public int HardDriveId { get; set; }
        /// <summary>
        /// Id del disco duro
        /// </summary>
        public int MicroprocesorId { get; set; }
        /// <summary>
        /// Id de la Motherboard
        /// </summary>
        public int MotherBoardId { get; set; }
        /// <summary>
        /// Id de la RAM
        /// </summary>
        public int RAMId { get; set; }

        #endregion 

        #region Constructors
        /// <summary>
        /// Requerido por EntityFrameworkCore para migraciones.
        /// </summary>
        protected PC() { }

        /// <summary>
        /// Inicializa un objeto <see cref="PC"/>
        /// </summary>
        /// <param name="rAM"></param>
        /// <param name="motherBoard"></param>
        /// <param name="hardDrive"></param>
        /// <param name="microprocesor"></param>
        public PC(RAM rAM, MotherBoard motherBoard, HardDrive hardDrive, Microprocesor microprocesor)
        {
            RAM = rAM;
            MotherBoard = motherBoard;
            HardDrive = hardDrive;
            Microprocesors = microprocesor;
        }
        #endregion
    }
}
