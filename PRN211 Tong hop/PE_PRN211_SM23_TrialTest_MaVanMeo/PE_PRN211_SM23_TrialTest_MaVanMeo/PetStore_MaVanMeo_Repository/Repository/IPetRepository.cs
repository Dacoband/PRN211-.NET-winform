using PetStore_MaVanMeo_Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetStore_MaVanMeo_Repository.Repository;

public interface IPetRepository
{
    IEnumerable<Pet> GetAllPets();
    IEnumerable<PetGroup> GetAllPetGroups();
    Pet GetPetById(int id);
    void AddPet(Pet pet);
    void UpdatePet(Pet pet);
    void DeletePet(Pet pet);
    void DeletePet(int id);
}
