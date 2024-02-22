using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CCM.Domain.Abstract;

namespace CCM.Domain.Entities.Components
{
    /// <summary>
    /// Modela una Motherboard de la PC
    /// </summary>
    public class MotherBoard : IBrand
    {
        #region Properties
        /// <summary>
        /// Modela el modelo de la motherboard
        /// </summary>
        public string Model { get; set; }
        /// <summary>
        /// Marca de la motherboard
        /// </summary>
        public string Brand { get;}
        #endregion
        MotherBoard(string model, string brand) 
        { 
            Model = model; 
            Brand = brand;
        }
    }
}
