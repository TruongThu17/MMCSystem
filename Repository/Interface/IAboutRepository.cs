using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Interface
{
    public interface IAboutRepository
    {
        About FindAbout();
         void UpdateAbout(About a);
         void CreateAbout(About a);
    }
}
