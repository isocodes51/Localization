using System;
using System.Collections.Generic;
using System.Text;

namespace Localization.Abstract
{
    public interface ILocalizationService<T>
    {
      
        void Add(T key, T value, string langShort);
        void GetAll(string langShort);
    }
}
