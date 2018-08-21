using Microsoft.AspNetCore.DataProtection.Repositories;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Xml.Linq;

namespace WebApplication1
{
    public class DataProtectionKeyRepository : IXmlRepository
    {
        public IReadOnlyCollection<XElement> GetAllElements()
        {            
            return new ReadOnlyCollection<XElement>(new List<XElement>());
        }

        public void StoreElement(XElement element, string friendlyName)
        {
            if (element == null)
            {
                throw new ArgumentNullException(nameof(element));
            }            
        }
    }

}
