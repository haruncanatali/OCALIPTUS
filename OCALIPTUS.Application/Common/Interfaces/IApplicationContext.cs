using Microsoft.EntityFrameworkCore;
using OCALIPTUS.Domain.Entities;
using OCALIPTUS.Domain.Identity;

namespace OCALIPTUS.Application.Common.Interfaces;

public interface IApplicationContext
{
    #region Identities

    public DbSet<User> Users { get; set; }
    public DbSet<Role> Roles { get; set; }
    public DbSet<UserRole> UserRoles { get; set; }

    #endregion

    #region Entities

    public DbSet<Address> Addresses { get; set; }
    public DbSet<Appointment> Appointments { get; set; }
    public DbSet<AppointmentDocument> AppointmentDocuments { get; set; }
    public DbSet<Department> Departments { get; set; }
    public DbSet<Diagnosis> Diagnoses { get; set; }
    public DbSet<Document> Documents { get; set; }
    public DbSet<Medicine> Medicines { get; set; }
    public DbSet<Patient> Patients { get; set; }
    public DbSet<Staff> Staves { get; set; }

    #endregion

    Task<int> SaveChangesAsync(CancellationToken cancellationToken);
}