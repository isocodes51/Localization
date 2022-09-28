using System;
using Localization.Concrete;
using System.Resources;

namespace Localization
{
    class Program
    {
        static void Main(string[] args)
        {
            LocalizationStringManager localizationStringManager = new LocalizationStringManager();
            localizationStringManager.Add("Hello1", "Hello World1", "jp-JP");
            localizationStringManager.GetAll("jp-JP");


        }
    }
}
