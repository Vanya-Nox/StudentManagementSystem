using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRG272_Project_Milestone2.BusinessLogic
{
    internal class Modules
    {
        public int ModuleCode { get; set; }
        public string ModuleName { get; set; }
        public string ModuleDescription { get; set; }
        public string OnlineResources { get; set; }

        public Modules(int moduleCode, string moduleName, string moduleDescription, string onlineResources)
        {
            ModuleCode = moduleCode;
            ModuleName = moduleName;
            ModuleDescription = moduleDescription;
            OnlineResources = onlineResources;
        }

        public Modules(string text1, string text2, string text3, string text4)
        {
        }

        public Modules()
        {
        }

        public override string ToString()
        {
            return $"ModuleCode: {ModuleCode} ModuleName: {ModuleName} Description: {ModuleDescription} OnlineResources: {OnlineResources}";
        }
    }
}
