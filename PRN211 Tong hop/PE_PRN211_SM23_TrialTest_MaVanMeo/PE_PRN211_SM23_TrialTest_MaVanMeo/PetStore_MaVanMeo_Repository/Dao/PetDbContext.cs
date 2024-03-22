using Microsoft.EntityFrameworkCore;
using PetStore_MaVanMeo_Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetStore_MaVanMeo_Repository.Dao;

public class PetDbContext:PetShop2023DBContext
{
    private static PetDbContext instance = null;
    private static readonly object instanceLock = new object();
    private PetDbContext()
    {
        InitalizeContext();
    }

    protected virtual void InitalizeContext()
    {
        ChangeTracker.AutoDetectChangesEnabled = false;
        ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
    }

    public static PetDbContext Instance
    {
        get
        {
            lock (instanceLock)
            {
                if (instance == null)
                {
                    instance = new PetDbContext();
                }
                return instance;
            }
        }
    }

    //Lay all pets
    public Pet GetPetById(int id)
    {
        return this.Pets.FirstOrDefault(m => m.PetId.Equals(id));

    }
    public IEnumerable<Pet> GetAllPets()
    {
        return this.Pets.Include(p=>p.PetGroup).ToList();
    }
    public void UpdatePet(Pet pet)
    {
        this.Pets.Update(pet);
        this.SaveChanges();
    }
    public void DeletePet(int id)
    {
        var pet = this.Pets.FirstOrDefault(p => p.PetId == id);
        if (pet != null)
        {
            this.Pets.Remove(pet);
            this.SaveChanges();
        }

    }

    public void AddPet(Pet pet)
    {
        this.Pets.Add(pet);
        this.SaveChanges();
    }
    /*Lay ra all petgroup*/
    public IEnumerable<PetGroup> GetPetGroups()
     => this.PetGroups.ToList();
}
