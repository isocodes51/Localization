using System;
using Localization.Concrete;
using System.Resources;

namespace Localization
{
    class Program
    {
        static void Main(string[] args)
        {
            LocalizationManager localizationManager = new LocalizationManager();
            localizationManager.Add("Hello1", "Hello World1", "jp-JP");
            localizationManager.GetAll("jp-JP");


        }
    }
}
