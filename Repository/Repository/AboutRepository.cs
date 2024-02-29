using Data.Models;
using DataAccess;
using Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repository
{
    public class AboutRepository : IAboutRepository
    {
        public About FindAbout() => AboutDAO.FindAbout();
    }
}
