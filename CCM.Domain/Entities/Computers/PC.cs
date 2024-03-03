using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CCM.Domain.Entities.Components;

namespace CCM.Domain.Entities.Computers
{
    /// <summary>
    /// Modela una computadora
    /// </summary>
    public class PC
    {
        #region Properties
        /// <summary>
        /// Modela el disco duro de la PC
        /// </summary>
        public HardDrive HardDrive { get; set; }
        /// <summary>
        /// Modela la motherboard de la PC
        /// </summary>
        public MotherBoard MotherBoard { get; set; }
        /// <summary>
        /// Modela el microprocesador de la PC
        /// </summary>
        public Microprocesor Microprocesors { get; set; }
        /// <summary>
        /// Modela la memoria RAM de la PC
        /// </summary>
        public RAM RAM { get; set; }
        #endregion 
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

    }
}
