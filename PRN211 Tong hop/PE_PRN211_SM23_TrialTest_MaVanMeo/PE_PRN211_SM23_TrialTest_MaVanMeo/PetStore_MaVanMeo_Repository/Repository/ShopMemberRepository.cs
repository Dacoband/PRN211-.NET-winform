using PetStore_MaVanMeo_Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PetStore_MaVanMeo_Repository.Dao;

namespace PetStore_MaVanMeo_Repository.Repository;

public class ShopMemberRepository : IShopMemberRepository
{
    
    public IEnumerable<PetShopMember> GetPetShopMembers()
    
       => MemberDbContext.Instance.GetAllMembers();
    
}
