using Rubicon_Admin.BuisnessLogic.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rubicon_Admin.BuisnessLogic.Core.Interfaces
{
    public interface IUserService
    {
        Task<UserInformationBlo> RegisterWithPhone(string numberPrefix, string number, string password);
    }
}
