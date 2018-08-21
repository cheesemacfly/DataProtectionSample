using Microsoft.AspNetCore.DataProtection.Repositories;
using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace WebApplication1
{
    public class DataProtectionKeyRepository : IXmlRepository
    {
        public IReadOnlyCollection<XElement> GetAllElements()
        {            
            return null;
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
