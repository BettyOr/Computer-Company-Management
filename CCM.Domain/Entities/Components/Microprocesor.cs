using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CCM.Domain.Abstract;
using CCM.Domain.Entities.Types;

namespace CCM.Domain.Entities.Components
{
    /// <summary>
    /// Modela el microprocesador de la PC
    /// </summary>
    public class Microprocesor : IBrand
    {
        #region Properties
        /// <summary>
        /// Modelo del microprocesador
        /// </summary>
        public string Model;
        /// <summary>
        /// Velocidad del microprocesador
        /// </summary>
        public int ProcessorSpeed;
        /// <summary>
        /// Marca del microprocesador
        /// </summary>
        public string Brand { get; }
        #endregion

        public Microprocesor(string model, int processorSpeed, string brand)
        {
            Model = model;
            ProcessorSpeed = processorSpeed;
            Brand = brand;
        }
    }
}
