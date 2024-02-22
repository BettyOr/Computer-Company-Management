using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CCM.Domain.Abstract;

namespace CCM.Domain.Entities.Components
{
    
    /// <summary>
    /// Modela la memoria RAM de la PC
    /// </summary>
    public class RAM : IBrand
    {
        #region Properties
        /// <summary>
        /// Tamaño de memoria de la RAM
        /// </summary>
        public int MemorySize { get; set; }
        /// <summary>
        /// Marca de la memoria RAM
        /// </summary>
        public string Brand { get; set; }
        #endregion
        RAM(int memorySize, string brand)           
        {
            MemorySize = memorySize;
            Brand = brand;
        }

    }
}
