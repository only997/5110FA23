using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace ContosoCrafts.WebSite.Models
{
    
    /// <summary>
    /// ProductTypeEnum is a enum (Class) that will categorize various types
    /// of costumes
    /// </summary>
    public enum ProductTypeEnum
    {
        Undefined = 0,
        Scary = 1,
        Kids = 5,
        Adult = 130,
        Princess = 55,
    }

    /// <summary>
    /// ProductTypeEnumExtensions is a static class with Display functionality
    /// of costumes
    /// </summary>
    public static class ProductTypeEnumExtensions
    {

        /// <summary>
        /// Function of Addrating to a particular productId
        /// </summary>
        /// <param name="data">This is a ProductTypeEnum </param>
        /// <returns></returns>
        public static string DisplayName(this ProductTypeEnum data)
        {
            return data switch
            {
                ProductTypeEnum.Scary => "Scary Costumes",
                ProductTypeEnum.Kids => "Kids",
                ProductTypeEnum.Adult => "Adult",
                ProductTypeEnum.Princess => "Princess",

                // Default, Unknown
                _ => "",
            };
        }
    }

}
