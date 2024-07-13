using System.Runtime.Serialization;
using OCALIPTUS.Domain.Enums;
using Microsoft.AspNetCore.Identity;
using OCALIPTUS.Domain.Entities;

namespace OCALIPTUS.Domain.Identity;

public class User : IdentityUser<long>
{
    public string FirstName { get; set; }
    public string Surname { get; set; }
    public string ProfilePhoto { get; set; }
    public DateTime Birthdate { get; set; }
    public int Age { get; set; }
    public string IdentityNumber { get; set; }

    public Gender Gender { get; set; }
    public Nationality Nationality { get; set; }
    public MemberStatus MemberStatus { get; set; }
    
    public string RefreshToken { get; set; }
    public DateTime RefreshTokenExpiredTime { get; set; }

    public DateTime CreatedAt { get; set; }
    public DateTime? UpdatedAt { get; set; }
    public long CreatedBy { get; set; }
    public long? UpdatedBy { get; set; }

    public List<Address> Addresses { get; set; }
    public List<Document> Documents { get; set; }
    public Staff Staff { get; set; }
    public Patient Patient { get; set; }


    [IgnoreDataMember]
    public string FullName
    {
        get { return $"{FirstName} {Surname}"; }
    }
}