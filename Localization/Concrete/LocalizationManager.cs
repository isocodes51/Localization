using System;
using System.Collections.Generic;
using System.Text;
using Localization.Abstract;
using System.Resources;
using System.Collections;
using System.Reflection;

namespace Localization.Concrete
{
    public class LocalizationManager : ILocalizationService<String>
    {
              

        public void Add(string key, string value,  string langShort)
        {
            using (ResourceWriter rw = new ResourceWriter("../../../Resources/Localization."+langShort+".resx"))
            {
                rw.AddResource(key, value); //Burada List yapılabilir.
                rw.Generate();
            }
        }



        public void GetAll(string langShort)
        {

            ResourceReader res = new ResourceReader("../../../Resources/Localization." + langShort + ".resx");
            IDictionaryEnumerator dict = res.GetEnumerator();
            while (dict.MoveNext())
            {
                Console.WriteLine("{0} {1}", dict.Key, dict.Value);
            }

        }
    }
}
