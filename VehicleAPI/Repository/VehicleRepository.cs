﻿//using Microsoft.EntityFrameworkCore;
using VehicleAPI.Models;
using VehicleAPI.Repository.IRepository;

namespace VehicleAPI.Repository
{
    public class VehicleRepository : IVehicleRepository
    {
        //private readonly ApplicationDbContext _context;
        //public VehicleRepository(ApplicationDbContext context)
        //{
        //    _context=context;
        //}
        //public async Task AddVehicle(Vehicle vehicle)
        //{
        //    await _context.Vehicles.AddAsync(vehicle);
        //    await _context.SaveChangesAsync();

        //}

        //public async Task DeleteVehicle(int id)
        //{
        //    var vehicleInDb = await _context.Vehicles.FindAsync(id);
        //    _context.Vehicles.Remove(vehicleInDb);
        //    await _context.SaveChangesAsync();
        //}

        //public async Task<Vehicle> GetVehicleById(int id)
        //{
        //    return await _context.Vehicles.FirstOrDefaultAsync(s => s.Id == id);
        //}

        public async Task<List<Vehicle>> GetVehicles()
        {
            //return await _context.Vehicles.ToListAsync();

            var result = new List<Vehicle>()
            {
                new Vehicle
                {
                    Id = 1,
                    Name = "Peter",
                    ImageUrl = "Mount Fort"
                },
                new Vehicle
                {
                    Id = 2,
                    Name = "Micheal",
                    ImageUrl = "Secret Heart"
                },
                new Vehicle {
                    Id = 3,
                    Name = "Steve",
                    ImageUrl = "Bishop Memorial"
                }
            };

            return result;

        }

        //public async Task UpdateVehicle(int id, Vehicle vehicle)
        //{
        //    _context.Vehicles.Update(vehicle);
        //  await  _context.SaveChangesAsync();
        //}
    }
}
