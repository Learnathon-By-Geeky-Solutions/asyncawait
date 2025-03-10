﻿namespace ShasthoBondhu.Models.DTO
{
    public class PatientDTO
    {
        public required string Name { get; set; }

        public byte[]? Image { get; set; }

        public string? Address { get; set; }

        public string? Phone { get; set; }

        public string? Email { get; set; }
    }
}
