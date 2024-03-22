using PetStore_MaVanMeo_Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetStore_MaVanMeo_Repository.Repository;

public interface IShopMemberRepository
{
    IEnumerable<PetShopMember> GetPetShopMembers();
}
