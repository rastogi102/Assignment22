using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace Assignment22
{
    public class PropertyMapper
    {
        public static void MapProperties(Source source, Destination destination)
        {
            Type sourceType = typeof(Source);
            Type destinationType = typeof(Destination);

            PropertyInfo[] sourceProperties = sourceType.GetProperties();
            PropertyInfo[] destinationProperties = destinationType.GetProperties();

            foreach (PropertyInfo sourceProperty in sourceProperties)
            {
                PropertyInfo matchingDestinationProperty = Array.Find(destinationProperties, prop => prop.Name == sourceProperty.Name && prop.PropertyType == sourceProperty.PropertyType);

                if (matchingDestinationProperty != null)
                {
                    object valueToAssign = sourceProperty.GetValue(source);
                    matchingDestinationProperty.SetValue(destination, valueToAssign);
                }
            }
        }
    }
}
