﻿using Microsoft.EntityFrameworkCore;
using ShasthoBondhu.Data;
using ShasthoBondhu.Data.Entities;
using ShasthoBondhu.Dto;
using ShasthoBondhu.Service.Interfaces;

namespace ShasthoBondhu.Service.Services
{
    public sealed class PatientService(IShasthoBondhuDbContext context) : IPatientService
    {
        private readonly IShasthoBondhuDbContext _context = context;

        public async Task<List<PatientDto>> GetAllAsync()
        {
            var patients = await _context.Patients
                 .Select(p => new PatientDto
                 {
                     Name = p.Name,
                     Gender = p.Gender,
                     DateOfBirth = p.DateOfBirth,
                     Image = p.Image,
                     Address = p.Address,
                     Phone = p.Phone,
                     Email = p.Email
                 })
                 .ToListAsync();

            return patients;
        }

        public async Task<PatientDto?> GetByIdAsync(int id)
        {
            var patient = await _context.Patients
                .Where(p => p.Id == id)
                .Select(p => new PatientDto
                {
                    Name = p.Name,
                    Gender = p.Gender,
                    DateOfBirth = p.DateOfBirth,
                    Image = p.Image,
                    Address = p.Address,
                    Phone = p.Phone,
                    Email = p.Email
                })
                .SingleOrDefaultAsync();

            return patient;
        }

        public async Task<(bool success, int patientId)> AddAsync(PatientDto patient)
        {
            var newPatient = new Patient
            {
                Name = patient.Name,
                Gender = patient.Gender,
                DateOfBirth = patient.DateOfBirth,
                Image = patient.Image,
                Address = patient.Address,
                Phone = patient.Phone,
                Email = patient.Email,
                CreatedAt = DateTime.UtcNow,
                CreatedBy = "Not defined"
            };

            await _context.Patients.AddAsync(newPatient);
            var result = await _context.SaveChangesAsync();
            return (result > 0, newPatient.Id);
        }
    }
}
